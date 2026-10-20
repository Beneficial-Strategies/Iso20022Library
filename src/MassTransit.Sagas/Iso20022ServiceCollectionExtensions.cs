// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using MassTransit.Configuration;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas;

/// <summary>
/// Marker type used only to anchor assembly discovery for <see cref="Iso20022ServiceCollectionExtensions"/>
/// — mirrors the sibling <c>BeneficialStrategies.Iso20022.FluentValidation</c> package's own
/// <c>AssemblyMarker</c> convention for structural consistency between the two packages'
/// registration surfaces, even though (unlike that package, which anchors a FluentValidation
/// library API call) this package's own hand-rolled scan below could just as easily anchor on
/// <see cref="Iso20022ServiceCollectionExtensions"/> itself. Kept as a distinct marker anyway so
/// the pattern reads identically in both places.
/// </summary>
internal sealed class AssemblyMarker { }

/// <summary>
/// Registers ISO 20022 Request-to-Pay sagas in this assembly in one call — the saga-package
/// counterpart to <c>BeneficialStrategies.Iso20022.Validation.Iso20022ServiceCollectionExtensions</c>
/// (<c>AddIso20022Validators</c>) in the FluentValidation package, with the same "register
/// everything, or narrow by ISO 20022 business area" shape.
/// </summary>
/// <remarks>
/// <para>
/// The mechanism differs from FluentValidation's out of genuine necessity, not by choice: every
/// validator implements the same <c>IValidator&lt;T&gt;</c> interface, so FluentValidation's own
/// <c>AssemblyScanner</c> can register all of them uniformly with one DI lifetime. MassTransit has
/// no equivalent "scan the assembly for sagas" API — <c>AddSagaStateMachine&lt;TStateMachine,
/// TInstance&gt;()</c> needs both concrete type arguments at the call site. This class closes that
/// gap itself: it finds every <see cref="MassTransitStateMachine{TSaga}"/> subclass in this
/// assembly via reflection, reads off its <c>TSaga</c> type argument, and invokes
/// <c>AddSagaStateMachine&lt;TStateMachine, TSaga&gt;()</c> through <see cref="MethodInfo.MakeGenericMethod"/>
/// once per discovered saga.
/// </para>
/// <para>
/// The extension target differs from FluentValidation's too, also out of necessity rather than
/// choice: FluentValidation's registration is "flat" (just add validators to the container), so
/// <c>this IServiceCollection</c> is the natural target. MassTransit's is nested — bus
/// configuration happens entirely inside one <c>AddMassTransit</c>/<c>AddMassTransitTestHarness</c>
/// call, and helpers like MassTransit's own <c>AddConsumersFromNamespaceContaining</c> operate on
/// the <em>inner</em> <see cref="IRegistrationConfigurator"/> passed to that call's configuration
/// delegate, not on <see cref="Microsoft.Extensions.DependencyInjection.IServiceCollection"/>
/// directly (an earlier version of this class got this wrong — extending
/// <c>IServiceCollection</c> and wrapping its own internal <c>AddMassTransit</c> call — which
/// throws <c>ArgumentException: Duplicate health checks were registered with the name(s):
/// masstransit-bus</c> the moment a caller composes it inside their own outer
/// <c>AddMassTransit</c>/<c>AddMassTransitTestHarness</c> call, exactly as
/// <c>AddConsumersFromNamespaceContaining</c> is meant to be used). This class follows
/// MassTransit's own convention instead: extend <see cref="IRegistrationConfigurator"/> directly,
/// so callers compose it the same way as any other MassTransit registration helper.
/// </para>
/// <para>
/// Repository configuration uses MassTransit's own <see cref="ISagaRepositoryRegistrationProvider"/>
/// abstraction (<c>x.SetSagaRepositoryProvider(...)</c>) rather than a per-call
/// <c>Action&lt;ISagaRegistrationConfigurator&lt;TSaga&gt;&gt;</c> lambda — that generic delegate
/// shape can't be written once for an unknown, reflection-discovered set of <c>TSaga</c> types, but
/// <see cref="ISagaRepositoryRegistrationProvider.Configure{TSaga}"/> is itself generic, so a single
/// provider instance (<c>InMemorySagaRepositoryRegistrationProvider</c>,
/// <c>EntityFrameworkSagaRepositoryRegistrationProvider</c>, or your own implementation) genuinely
/// configures every discovered saga uniformly. If different sagas need genuinely different
/// persistence (e.g. EF Core for one, MongoDB for another), use the strongly-typed
/// <c>AddCreditorEnrolmentSaga</c>/<c>AddDebtorActivationSaga</c> methods instead (see
/// <c>reda/Extensions/Iso20022SagaServiceCollectionExtensions.cs</c>) — this class's methods are
/// for the common case of one persistence strategy applied to every saga you register.
/// </para>
/// </remarks>
public static class Iso20022ServiceCollectionExtensions
{
    // The plain (TStateMachine, TSaga) instance method — used when a saga has no SagaDefinition.
    private static readonly MethodInfo AddSagaStateMachineMethod = typeof(IRegistrationConfigurator)
        .GetMethods()
        .First(m =>
            m.Name == nameof(IRegistrationConfigurator.AddSagaStateMachine)
            && m.GetGenericArguments().Length == 2
            && m.GetParameters().Length == 1
        );

    // The (TStateMachine, TSaga, TDefinition) extension method — used when a saga DOES have a
    // SagaDefinition (e.g. CreditorEnrolmentSagaDefinition), so retry/outbox/endpoint
    // configuration from that definition isn't silently dropped by registering generically
    // instead of through the strongly-typed AddCreditorEnrolmentSaga/AddDebtorActivationSaga
    // methods. This one is a STATIC extension method (on MassTransit.RegistrationExtensions), not
    // an instance method on IRegistrationConfigurator, so it's invoked differently below —
    // MakeGenericMethod(...).Invoke(null, [configurator, null]), not .Invoke(configurator, [null]).
    // global:: qualified deliberately — "MassTransit.RegistrationExtensions" unqualified would
    // resolve to BeneficialStrategies.Iso20022.MassTransit.RegistrationExtensions instead: this
    // file's own namespace (BeneficialStrategies.Iso20022.MassTransit.Sagas) has
    // "BeneficialStrategies.Iso20022.MassTransit" as a real ancestor segment, so C#'s
    // ancestor-namespace lookup finds that "MassTransit" before the real external package (the
    // same class of collision root CLAUDE.md documents for the Choices sub-namespace).
    private static readonly MethodInfo AddSagaStateMachineWithDefinitionMethod = typeof(
        global::MassTransit.RegistrationExtensions
    )
        .GetMethods(BindingFlags.Public | BindingFlags.Static)
        .First(m => m.Name == nameof(IRegistrationConfigurator.AddSagaStateMachine) && m.GetGenericArguments().Length == 3);

    private const string SagaNamespacePrefix = "BeneficialStrategies.Iso20022.MassTransit.Sagas.";

    /// <summary>
    /// Registers every ISO 20022 saga state machine in this assembly, plus each one's own fan-out
    /// consumers. Call this from inside your own <c>AddMassTransit</c>/<c>AddMassTransitTestHarness</c>
    /// configuration delegate — see this class's own remarks for why it can't wrap that call itself.
    /// </summary>
    /// <param name="configurator">
    /// The registration configurator your <c>AddMassTransit(x =&gt; ...)</c> or
    /// <c>AddMassTransitTestHarness(x =&gt; ...)</c> call already hands you.
    /// </param>
    /// <param name="repositoryProvider">
    /// The saga persistence strategy applied to every discovered saga uniformly — e.g.
    /// <c>new InMemorySagaRepositoryRegistrationProvider()</c> for tests/demos, or
    /// <c>new EntityFrameworkSagaRepositoryRegistrationProvider(r =&gt; r.UseSqlite(...))</c>
    /// (from <c>MassTransit.EntityFrameworkCore</c>) for real persistence.
    /// </param>
    /// <param name="filter">
    /// Optional predicate over each discovered saga's state machine type (e.g.
    /// <c>typeof(DebtorActivationServiceProviderStateMachine)</c>) — return <see langword="true"/>
    /// to register that saga, <see langword="false"/> to skip it. Pass <see langword="null"/> (the
    /// default) to register every saga in the assembly. Each registered saga's own fan-out
    /// consumers are always included alongside it automatically — <paramref name="filter"/> only
    /// needs to consider state machine types, never consumer types.
    /// </param>
    /// <returns><paramref name="configurator"/>, for chaining.</returns>
    public static IRegistrationConfigurator AddIso20022Sagas(
        this IRegistrationConfigurator configurator,
        ISagaRepositoryRegistrationProvider repositoryProvider,
        Func<Type, bool>? filter = null
    )
    {
        var discovered = DiscoverSagaStateMachines(filter).ToList();

        configurator.SetSagaRepositoryProvider(repositoryProvider);

        foreach (var (stateMachineType, sagaStateType, definitionType) in discovered)
        {
            if (definitionType is not null)
            {
                AddSagaStateMachineWithDefinitionMethod
                    .MakeGenericMethod(stateMachineType, sagaStateType, definitionType)
                    .Invoke(null, [configurator, null]);
            }
            else
            {
                AddSagaStateMachineMethod.MakeGenericMethod(stateMachineType, sagaStateType).Invoke(configurator, [null]);
            }
        }

        // Every fan-out consumer (e.g. CreditorEnrolmentRequestConsumer) whose containing "family"
        // namespace (BeneficialStrategies.Iso20022.MassTransit.Sagas.{area}.{Family}) matches one
        // of the sagas actually selected above — derived from the FILTERED saga list itself, not
        // by re-running the caller's filter against consumer types directly. That matters: filter
        // is documented as operating on saga state machine types (e.g. an identity check against
        // typeof(DebtorActivationServiceProviderStateMachine)), and a filter written that way would
        // trivially return false for every unrelated consumer type too — silently wiring a saga
        // with nothing to feed it events. Deriving inclusion from the resolved saga family
        // namespaces instead guarantees a registered saga always gets its own consumers,
        // regardless of what shape the caller's filter took. MassTransit's own
        // AddConsumersFromNamespaceContaining<T> does the actual assembly-wide discovery — unlike
        // saga registration, consumer registration needs only one generic type argument, so
        // MassTransit already provides this; no hand-rolled reflection needed for it.
        var registeredFamilyNamespaces = discovered
            .Select(d => d.StateMachineType.Namespace ?? string.Empty)
            .ToHashSet(StringComparer.Ordinal);

        configurator.AddConsumersFromNamespaceContaining<AssemblyMarker>(consumerType =>
            registeredFamilyNamespaces.Any(ns =>
                (consumerType.Namespace ?? string.Empty).StartsWith(ns + ".", StringComparison.Ordinal)
            )
        );

        return configurator;
    }

    /// <summary>
    /// Registers ISO 20022 sagas for only the given business areas (e.g. <c>"reda"</c>) — matching
    /// the <c>{area}/RequestToPay.../</c> folder and
    /// <c>BeneficialStrategies.Iso20022.MassTransit.Sagas.{area}.*</c> namespace convention this
    /// package uses (see this package's own README's "Project layout" section). Mirrors the
    /// FluentValidation package's <c>AddIso20022Validators(IEnumerable&lt;string&gt;, ...)</c>
    /// overload.
    /// </summary>
    /// <param name="configurator">See the other overload.</param>
    /// <param name="businessAreas">
    /// One or more ISO 20022 business area codes, e.g. <c>"reda"</c> — case-sensitive, matching
    /// the lowercase folder/namespace name exactly. Only sagas from these areas are registered.
    /// </param>
    /// <param name="repositoryProvider">See the other overload.</param>
    /// <returns><paramref name="configurator"/>, for chaining.</returns>
    public static IRegistrationConfigurator AddIso20022Sagas(
        this IRegistrationConfigurator configurator,
        IEnumerable<string> businessAreas,
        ISagaRepositoryRegistrationProvider repositoryProvider
    )
    {
        var areas = new HashSet<string>(businessAreas, StringComparer.Ordinal);

        return configurator.AddIso20022Sagas(
            repositoryProvider,
            stateMachineType => BusinessAreaOf(stateMachineType) is { } area && areas.Contains(area)
        );
    }

    /// <summary>
    /// Finds every non-abstract <see cref="MassTransitStateMachine{TSaga}"/> subclass in this
    /// assembly, reading off each one's <c>TSaga</c> type argument by walking up
    /// <see cref="Type.BaseType"/> until it reaches the closed generic base — and, for each one,
    /// the matching <c>SagaDefinition&lt;TSaga&gt;</c> subclass in this assembly, if any (e.g.
    /// <c>CreditorEnrolmentSagaDefinition</c>), found the same way. A saga with no definition
    /// class yields <see langword="null"/> for <c>DefinitionType</c> — registration falls back to
    /// the plain (no-definition) overload for that one.
    /// </summary>
    private static IEnumerable<(Type StateMachineType, Type SagaStateType, Type? DefinitionType)> DiscoverSagaStateMachines(
        Func<Type, bool>? filter
    )
    {
        var allTypes = typeof(AssemblyMarker).Assembly.GetTypes();

        var definitionsBySagaType = allTypes
            .Where(t => t is { IsClass: true, IsAbstract: false })
            .Select(t => (DefinitionType: t, SagaType: GenericArgumentOfBase(t, typeof(SagaDefinition<>))))
            .Where(x => x.SagaType is not null)
            .ToDictionary(x => x.SagaType!, x => x.DefinitionType);

        foreach (var type in allTypes)
        {
            if (!type.IsClass || type.IsAbstract)
            {
                continue;
            }

            var sagaStateType = GenericArgumentOfBase(type, typeof(MassTransitStateMachine<>));
            if (sagaStateType is null || (filter is not null && !filter(type)))
            {
                continue;
            }

            definitionsBySagaType.TryGetValue(sagaStateType, out var definitionType);
            yield return (type, sagaStateType, definitionType);
        }
    }

    /// <summary>
    /// Walks <paramref name="type"/>'s <see cref="Type.BaseType"/> chain looking for a closed
    /// generic base whose open generic definition is <paramref name="openGenericBase"/> (e.g.
    /// <c>typeof(MassTransitStateMachine&lt;&gt;)</c>), returning that base's single type
    /// argument, or <see langword="null"/> if <paramref name="type"/> doesn't derive from it.
    /// </summary>
    private static Type? GenericArgumentOfBase(Type type, Type openGenericBase)
    {
        var baseType = type.BaseType;
        while (baseType is not null)
        {
            if (baseType.IsGenericType && baseType.GetGenericTypeDefinition() == openGenericBase)
            {
                return baseType.GetGenericArguments()[0];
            }

            baseType = baseType.BaseType;
        }

        return null;
    }

    /// <summary>
    /// Extracts the business area segment from a saga state machine's namespace (e.g.
    /// <c>BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment</c>
    /// → <c>"reda"</c>), or <see langword="null"/> if the type isn't under this package's own
    /// namespace at all (defensive — every type <see cref="DiscoverSagaStateMachines"/> finds is
    /// from this assembly, so this should always succeed in practice).
    /// </summary>
    private static string? BusinessAreaOf(Type stateMachineType)
    {
        var ns = stateMachineType.Namespace ?? string.Empty;
        if (!ns.StartsWith(SagaNamespacePrefix, StringComparison.Ordinal))
        {
            return null;
        }

        var afterPrefix = ns[SagaNamespacePrefix.Length..];
        var area = afterPrefix.Split('.')[0];
        return area.Length > 0 ? area : null;
    }
}
