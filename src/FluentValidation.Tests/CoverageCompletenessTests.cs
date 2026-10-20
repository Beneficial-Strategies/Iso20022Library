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
    /// <remarks>
    /// <c>FIToFIPaymentCancellationRequestV10</c> is deliberately NOT listed here despite the
    /// NuGet README having previously (incorrectly) claimed it as one of the fully-supported
    /// messages: attempting to add it here on 2026-08-20 (as part of mechanically verifying it
    /// for the first time, alongside the batch below) revealed 66 reachable model types with no
    /// wired validator — SupplementaryData1, CashAccount40, PostalAddress24, CountryCode, and 62
    /// others, mostly older-generation component types (PartyIdentification135,
    /// CashAccountType2Choice_, the Tax/Garnishment/DocumentLine family, etc.) this message's own
    /// graph reaches that no other in-scope message happens to need yet. That claim was never
    /// actually mechanically checked before this test existed. The README has been corrected to
    /// stop claiming it. Re-add it here once its real gap is closed — tracked as follow-up work,
    /// not attempted in the same pass that discovered it.
    /// </remarks>
    public static readonly Type[] FullySupportedMessages =
    [
        typeof(ICancelCaseAssignmentV05),
        typeof(IRequestForDuplicateV07),
        typeof(IMandateCopyRequestV04),
        typeof(ICaseStatusReportRequestV05),
        typeof(IPayInEventAcknowledgementV02),
        typeof(IDebitAuthorisationResponseV06),
        typeof(IRejectInvestigationV07),
        typeof(IMandateInitiationRequestV08),
        typeof(ICaseStatusReportV06),
        typeof(INotificationOfCaseAssignmentV06),
        typeof(IDeleteLimitV08),
        typeof(IDeleteStandingOrderV05),
        typeof(IDuplicateV07),
        typeof(IProprietaryFormatInvestigationV06),
        typeof(IGetCurrencyExchangeRateV04),
        typeof(IGetGeneralBusinessInformationV04),
        typeof(IDeleteReservationV07),
        typeof(ILiquidityCreditTransferV07),
        typeof(ILiquidityDebitTransferV07),
        typeof(IMandateCancellationRequestV08),
        typeof(IMandateSuspensionRequestV04),
        typeof(ICreateLimitV02),
        typeof(ICreateReservationV03),
        typeof(ICreateStandingOrderV03),
        typeof(IModifyStandingOrderV08),
        typeof(IModifyReservationV07),
        typeof(IMandateAcceptanceReportV08),
        typeof(IMandateAmendmentRequestV08),
        typeof(ICreditorPaymentActivationRequestV12),
        typeof(ICustomerPaymentReversalV13),
        typeof(ICustomerDirectDebitInitiationV12),
        typeof(ICustomerCreditTransferInitiationV13),
        typeof(ICustomerPaymentStatusReportV15),
        typeof(ICreditorPaymentActivationRequestStatusReportV12),
        typeof(IMultilateralSettlementRequestV02),
        typeof(IFinancialInstitutionDirectDebitV06),
        typeof(IFIToFIPaymentStatusRequestV07),
        typeof(IFIToFIPaymentReversalV14),
        typeof(IFIToFIPaymentStatusReportV16),
        typeof(IFIToFICustomerCreditTransferV14),
        typeof(IFinancialInstitutionCreditTransferV13),
        typeof(IFIToFICustomerDirectDebitV12),
        typeof(IPaymentReturnV15),
    ];

    [Theory]
    [MemberData(nameof(FullySupportedMessageCases))]
    public void FullySupportedMessage_EveryReachableModelTypeHasAWiredValidator(Type messageType)
    {
        var modelReachable = GetModelReachableTypes(messageType).Select(ToValidatedType).ToHashSet();
        var wiredClosure = GetWiredValidatedTypes(messageType);

        Assert.True(modelReachable.Count > 0, $"no model type is reachable from {messageType.Name}: the walk is not finding the model");
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
            foreach (var prop in PropertiesOf(current))
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

    /// <summary>
    /// The type a validator is written for: the interface of a component or choice record (a choice <c>Foo_</c> has
    /// <c>IFoo</c>), since the validators validate the interfaces; a code set is its own type.
    /// </summary>
    private static Type ToValidatedType(Type type)
    {
        if (!IsModelComponentOrChoice(type) || type.IsInterface)
        {
            return type;
        }

        var name = "I" + type.Name.TrimEnd('_');
        var iface = typeof(BeneficialStrategies.Iso20022.Components.IGroupHeader110).Assembly.GetType(type.Namespace + "." + name);
        return iface ?? throw new InvalidOperationException($"No interface {name} for {type.FullName}.");
    }

    // An interface lists only the members it declares itself; those of the interfaces it extends are its members too.
    private static IEnumerable<PropertyInfo> PropertiesOf(Type type) =>
        type.IsInterface
            ? new[] { type }.Concat(type.GetInterfaces()).SelectMany(i => i.GetProperties(BindingFlags.Public | BindingFlags.Instance)).GroupBy(p => p.Name).Select(g => g.First())
            : type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

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
        if (def.Name is "ValueList`1" or "SimpleValueList`1" or "ImmutableValueList`1" or "IEnumerable`1")
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
