// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// Marker type used only to anchor assembly discovery for <see cref="Iso20022ServiceCollectionExtensions"/>
/// — deliberately not any specific validator class, so assembly resolution keeps working even if
/// individual validators are renamed, moved, or removed.
/// </summary>
internal sealed class AssemblyMarker { }

/// <summary>
/// Registers every ISO 20022 FluentValidation validator in this assembly with an
/// <see cref="IServiceCollection"/> in one call.
/// </summary>
/// <remarks>
/// Every validator in this package is registered as <c>IValidator&lt;T&gt;</c> — the same
/// interface FluentValidation's own <c>AddValidatorsFromAssemblyContaining&lt;T&gt;()</c>
/// registers against — which is what lets .NET's built-in DI container select each validator's
/// dependency-injection constructor (the one taking <c>IValidator&lt;T&gt;</c> parameters for its
/// children) over its parameterless "default dependencies" convenience constructor: the container
/// picks the constructor with the most parameters among those where every parameter type is
/// itself resolvable, and once every child validator is registered as <c>IValidator&lt;T&gt;</c>,
/// that's always the DI constructor. See the FluentValidation project's own <c>CLAUDE.md</c> for
/// the constructor-selection background this design relies on.
/// </remarks>
public static class Iso20022ServiceCollectionExtensions
{
    /// <summary>
    /// Registers every ISO 20022 validator in this assembly as <c>IValidator&lt;T&gt;</c>.
    /// </summary>
    /// <param name="services">The service collection to register validators with.</param>
    /// <param name="lifetime">
    /// The DI lifetime to register validators with. Defaults to <see cref="ServiceLifetime.Scoped"/>,
    /// matching FluentValidation's own default. Validators are stateless, so
    /// <see cref="ServiceLifetime.Singleton"/> is also safe and can reduce allocations in
    /// high-throughput scenarios if that matters for your workload.
    /// </param>
    /// <param name="filter">
    /// Optional predicate over each concrete validator type (e.g. <c>typeof(Case6Validator)</c>) —
    /// return <see langword="true"/> to register that validator, <see langword="false"/> to skip
    /// it. Pass <see langword="null"/> (the default) to register every validator in the assembly.
    /// </param>
    /// <returns><paramref name="services"/>, for chaining.</returns>
    /// <remarks>
    /// If you filter out a validator that another registered validator depends on (e.g. filtering
    /// out <c>Case6Validator</c> while keeping <c>CaseAssignment6Validator</c>, which needs
    /// <c>IValidator&lt;Party50Choice_&gt;</c> but not <c>IValidator&lt;Case6&gt;</c>, is fine —
    /// but filtering out a validator that IS a direct dependency of one you keep is not), DI
    /// resolution of the dependent validator throws at first use, not at registration time — this
    /// is a deliberate fail-fast tradeoff, the same one <c>AddValidatorsFromAssemblyContaining</c>
    /// itself makes. Prefer the business-area overload below when you only want to narrow by ISO
    /// 20022 business area (camt, pain, ...): it automatically keeps every shared component/choice
    /// validator regardless of area, so this failure mode can't happen from area filtering alone.
    /// </remarks>
    public static IServiceCollection AddIso20022Validators(
        this IServiceCollection services,
        ServiceLifetime lifetime = ServiceLifetime.Scoped,
        Func<Type, bool>? filter = null
    )
    {
        services.AddExternalCodeRegistryDefault();

        return services.AddValidatorsFromAssemblyContaining<AssemblyMarker>(
            lifetime,
            filter is null ? null : scanResult => filter(scanResult.ValidatorType)
        );
    }

    /// <summary>
    /// Registers ISO 20022 validators for only the given business areas (e.g. <c>"camt"</c>,
    /// <c>"pain"</c>) — matching the <c>Validators/{area}/</c> folder and
    /// <c>BeneficialStrategies.Iso20022.Validation.{area}</c> namespace convention documented in
    /// this project's own <c>CLAUDE.md</c>.
    /// </summary>
    /// <param name="services">The service collection to register validators with.</param>
    /// <param name="businessAreas">
    /// One or more ISO 20022 business area codes, e.g. <c>"camt"</c>, <c>"pain"</c>, <c>"pacs"</c>
    /// — case-sensitive, matching the lowercase folder/namespace name exactly. Only message
    /// validators from these areas are registered.
    /// </param>
    /// <param name="lifetime">
    /// The DI lifetime to register validators with. Defaults to <see cref="ServiceLifetime.Scoped"/>.
    /// </param>
    /// <returns><paramref name="services"/>, for chaining.</returns>
    /// <remarks>
    /// Component and choice validators (<c>Validation.Components</c>, <c>Validation.ChoiceValidators</c>)
    /// are always registered regardless of which areas are requested — message validators in any
    /// area may depend on them, and omitting them would break DI resolution for the very areas you
    /// asked to keep. Only the per-area message validators are actually filtered by
    /// <paramref name="businessAreas"/>.
    /// </remarks>
    public static IServiceCollection AddIso20022Validators(
        this IServiceCollection services,
        IEnumerable<string> businessAreas,
        ServiceLifetime lifetime = ServiceLifetime.Scoped
    )
    {
        var areas = new HashSet<string>(businessAreas, StringComparer.Ordinal);

        return services.AddIso20022Validators(
            lifetime,
            validatorType =>
            {
                var ns = validatorType.Namespace ?? string.Empty;
                const string prefix = "BeneficialStrategies.Iso20022.Validation.";
                if (!ns.StartsWith(prefix, StringComparison.Ordinal))
                {
                    return false;
                }

                var suffix = ns[prefix.Length..];
                return suffix is "Components" or "ChoiceValidators" || areas.Contains(suffix);
            }
        );
    }

    /// <summary>
    /// Registers ISO 20022 validators for exactly the transitive dependency closure of the given
    /// model types — computed once, via reflection over each validator's own constructors, rather
    /// than approximated by namespace like the business-area overload above.
    /// </summary>
    /// <param name="services">The service collection to register validators with.</param>
    /// <param name="rootTypes">
    /// The ISO 20022 <em>model</em> types you need validated — not validator types — typically one
    /// or more top-level message types, e.g. <c>typeof(CancelCaseAssignmentV05)</c>. Every
    /// component/choice type reachable from these roots through the validators' own
    /// dependency-injection constructors is included automatically; you don't need to enumerate
    /// what's underneath them yourself.
    /// </param>
    /// <param name="lifetime">
    /// The DI lifetime to register validators with. Defaults to <see cref="ServiceLifetime.Scoped"/>.
    /// </param>
    /// <returns><paramref name="services"/>, for chaining.</returns>
    /// <exception cref="ArgumentException">
    /// A type in <paramref name="rootTypes"/> has no validator in this assembly.
    /// </exception>
    /// <remarks>
    /// The dependency graph is built by finding, per validator, the constructor with the most
    /// parameters among constructors where every parameter is <c>IValidator&lt;T&gt;</c> — the
    /// same "most resolvable parameters wins" rule .NET's own container uses to pick the DI
    /// constructor (see this class's own remarks) — and reading off each such T. This assumes the
    /// two-constructor convention this project's own <c>CLAUDE.md</c> establishes for every
    /// validator (a DI constructor whose parameters are exclusively <c>IValidator&lt;T&gt;</c>,
    /// plus a parameterless convenience constructor); it is not a general-purpose DI-parameter
    /// resolver for arbitrary constructor shapes.
    ///
    /// A type in the closure that has no validator at all (e.g. a deliberately out-of-scope
    /// nested type — see the "Coverage Scoping Policy" section of this project's <c>CLAUDE.md</c>)
    /// is simply not registered and does not stop the walk; it's a dead end in the graph, exactly
    /// like it's a dead end in the validators' own <c>SetValidator</c> wiring.
    /// </remarks>
    public static IServiceCollection AddIso20022Validators(
        this IServiceCollection services,
        IEnumerable<Type> rootTypes,
        ServiceLifetime lifetime = ServiceLifetime.Scoped
    )
    {
        services.AddExternalCodeRegistryDefault();

        var byValidatedType = AssemblyScanner
            .FindValidatorsInAssemblyContaining<AssemblyMarker>()
            .ToDictionary(
                result => result.InterfaceType.GetGenericArguments()[0],
                result => (ValidatorType: result.ValidatorType, InterfaceType: result.InterfaceType)
            );

        var roots = rootTypes.ToList();
        foreach (var root in roots)
        {
            if (!byValidatedType.ContainsKey(root))
            {
                throw new ArgumentException(
                    $"No validator found for '{root.FullName}' in this assembly.",
                    nameof(rootTypes)
                );
            }
        }

        var reachable = new HashSet<Type>();
        var queue = new Queue<Type>(roots);
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            if (!reachable.Add(current) || !byValidatedType.TryGetValue(current, out var entry))
            {
                continue;
            }

            foreach (var dependency in GetInjectedValidatedTypes(entry.ValidatorType))
            {
                if (byValidatedType.ContainsKey(dependency) && !reachable.Contains(dependency))
                {
                    queue.Enqueue(dependency);
                }
            }
        }

        foreach (var validatedType in reachable)
        {
            var (validatorType, interfaceType) = byValidatedType[validatedType];
            services.Add(new ServiceDescriptor(interfaceType, validatorType, lifetime));
        }

        return services;
    }

    /// <summary>
    /// Returns the validated model types (<c>T</c> in <c>IValidator&lt;T&gt;</c>) that
    /// <paramref name="validatorType"/>'s own DI constructor depends on — see the remarks on
    /// the <c>AddIso20022Validators(IEnumerable&lt;Type&gt;, ServiceLifetime)</c> overload above
    /// for exactly what "DI constructor" means here.
    /// </summary>
    private static IEnumerable<Type> GetInjectedValidatedTypes(Type validatorType)
    {
        var diConstructorParameters = validatorType
            .GetConstructors()
            .Select(ctor => ctor.GetParameters())
            .Where(parameters => parameters.Length > 0 && parameters.All(IsValidatorParameter))
            .OrderByDescending(parameters => parameters.Length)
            .FirstOrDefault();

        return diConstructorParameters?.Select(p => p.ParameterType.GetGenericArguments()[0])
            ?? [];

        static bool IsValidatorParameter(ParameterInfo parameter) =>
            parameter.ParameterType.IsGenericType
            && parameter.ParameterType.GetGenericTypeDefinition() == typeof(IValidator<>);
    }

    /// <summary>
    /// Registers the open-generic default <see cref="IExternalCodeRegistry{TCode}"/> — one
    /// registration line covers every external code set type, present or future, via .NET's
    /// open-generic DI resolution. <see cref="ServiceCollectionDescriptorExtensions.TryAdd(IServiceCollection,ServiceDescriptor)"/>
    /// so calling <c>AddIso20022Validators</c> more than once, or a caller who registered their
    /// own open-generic default first, doesn't double-register. A caller overriding one specific
    /// code set (e.g. with a database-backed registry) registers
    /// <c>IExternalCodeRegistry&lt;TheirSpecificCode&gt;</c> afterward — the closed-generic
    /// registration wins for that one type via ordinary last-registration-wins resolution; every
    /// other type still falls back to this default.
    /// </summary>
    private static void AddExternalCodeRegistryDefault(this IServiceCollection services) =>
        services.TryAddSingleton(
            typeof(IExternalCodeRegistry<>),
            typeof(InMemoryExternalCodeRegistry<>)
        );
}
