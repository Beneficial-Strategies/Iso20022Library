// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// Mechanically enforces the two-state completeness model from the FluentValidation project's own
/// <c>CLAUDE.md</c>: a top-level message is only "fully supported" if <em>every</em> component and
/// choice type reachable from it — transitively, all the way down — has a validator wired in.
/// There is no partial third state for a message claimed as supported.
/// </summary>
/// <remarks>
/// This does not just re-check what <see cref="Iso20022ServiceCollectionExtensions"/>'s DI-closure
/// wiring already decided — it independently walks the raw ISO 20022 <em>model</em>'s own property
/// graph via reflection (not the validators' constructors) and cross-checks that against the
/// registered closure. That distinction matters: if a validator's constructor ever forgot to
/// declare a dependency it should have, the DI-closure walk alone wouldn't catch it (it only sees
/// what constructors actually declare) — this test would, because it starts from what the model
/// itself says is reachable, independent of what any validator claims.
/// </remarks>
public class CoverageCompletenessTests
{
    /// <summary>
    /// The messages this project currently claims are "fully supported" per the coverage-scoping
    /// policy. Add to this list only once a message's entire reachable graph is genuinely wired —
    /// this test will fail immediately if that's not true.
    /// </summary>
    public static readonly Type[] FullySupportedMessages =
    [
        typeof(CancelCaseAssignmentV05),
        typeof(RequestForDuplicateV07),
        typeof(MandateCopyRequestV04),
    ];

    [Theory]
    [MemberData(nameof(FullySupportedMessageCases))]
    public void FullySupportedMessage_EveryReachableModelTypeHasAWiredValidator(Type messageType)
    {
        var modelReachable = GetModelReachableTypes(messageType);
        var wiredClosure = GetWiredValidatedTypes(messageType);

        var gaps = modelReachable.Except(wiredClosure).ToList();

        Assert.True(
            gaps.Count == 0,
            $"{messageType.Name} claims full support, but {gaps.Count} model type(s) reachable "
                + $"from it have no validator wired into the DI closure: "
                + $"{string.Join(", ", gaps.Select(t => t.Name))}. Either wire them in, or remove "
                + $"{messageType.Name} from {nameof(FullySupportedMessages)} until they are."
        );
    }

    public static IEnumerable<object[]> FullySupportedMessageCases() =>
        FullySupportedMessages.Select(t => new object[] { t });

    /// <summary>
    /// Walks the ISO 20022 model's own property graph — not any validator's constructor — to find
    /// every Component/Choice type reachable from <paramref name="root"/>, plus every
    /// <see cref="IIsoExternalCode"/> leaf type reachable along the way (e.g.
    /// <see cref="Choices.FinancialIdentificationSchemeName1Choice.Code"/>'s <c>Value</c>, or a
    /// direct property like <c>PostalAddress27.Country</c>) — external code sets need their own
    /// registry-backed validator too (see <c>IExternalCodeRegistry{TCode}</c>), so they count
    /// toward completeness exactly like a Component or Choice does. Mirrors the exact scoping
    /// rules used elsewhere in this project's own analysis: unwraps
    /// <c>ValueList&lt;T&gt;</c>/<c>SimpleValueList&lt;T&gt;</c>/<c>ImmutableValueList&lt;T&gt;</c>
    /// collections and <c>Nullable&lt;T&gt;</c> (external code properties are typically
    /// <c>TCode?</c>), and only follows a Choice type via its abstract base
    /// (<c>BeneficialStrategies.Iso20022.Choices</c> namespace exactly) — never into a variant's
    /// own sub-namespace, since a property is never declared as a concrete variant type.
    /// External code types are leaves: found and recorded, but not recursed into.
    /// </summary>
    private static HashSet<Type> GetModelReachableTypes(Type root)
    {
        var reachable = new HashSet<Type>();
        var queue = new Queue<Type>();
        queue.Enqueue(root);
        var visited = new HashSet<Type> { root };

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            foreach (var prop in current.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var propType = Unwrap(prop.PropertyType);
                if (!visited.Add(propType))
                {
                    continue;
                }

                if (IsExternalCode(propType))
                {
                    reachable.Add(propType);
                }
                else if (IsModelComponentOrChoice(propType))
                {
                    reachable.Add(propType);
                    queue.Enqueue(propType);
                }
            }
        }

        return reachable;
    }

    private static Type Unwrap(Type type)
    {
        var underlying = Nullable.GetUnderlyingType(type);
        if (underlying is not null)
        {
            return underlying;
        }

        if (!type.IsGenericType)
        {
            return type;
        }

        var def = type.GetGenericTypeDefinition();
        if (def.Name is "ValueList`1" or "SimpleValueList`1" or "ImmutableValueList`1")
        {
            return type.GetGenericArguments()[0];
        }

        return type;
    }

    private static bool IsModelComponentOrChoice(Type type) =>
        type.Namespace is "BeneficialStrategies.Iso20022.Components" or "BeneficialStrategies.Iso20022.Choices";

    private static bool IsExternalCode(Type type) => typeof(IIsoExternalCode).IsAssignableFrom(type);

    /// <summary>
    /// Returns the validated model types actually wired into the DI closure for
    /// <paramref name="root"/>, via the same reflection-driven closure
    /// <see cref="Iso20022ServiceCollectionExtensions"/> uses for registration. Only closed
    /// <c>IValidator&lt;T&gt;</c> registrations count — <c>AddIso20022Validators</c> also
    /// registers the open-generic <c>IExternalCodeRegistry&lt;&gt;</c> default alongside the
    /// validators, which isn't itself a "T has a wired validator" signal and would otherwise show
    /// up as meaningless noise (an unbound generic parameter, not a real type) in the comparison.
    /// </summary>
    private static HashSet<Type> GetWiredValidatedTypes(Type root)
    {
        var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection();
        services.AddIso20022Validators(rootTypes: [root]);

        return services
            .Where(descriptor =>
                descriptor.ServiceType.IsGenericType
                && !descriptor.ServiceType.ContainsGenericParameters
                && descriptor.ServiceType.GetGenericTypeDefinition() == typeof(IValidator<>)
            )
            .Select(descriptor => descriptor.ServiceType.GetGenericArguments()[0])
            .Where(t => t != root)
            .ToHashSet();
    }
}
