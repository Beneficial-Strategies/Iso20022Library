// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// Supplies the currently-acceptable values for one specific ISO 20022 external code set.
/// </summary>
/// <remarks>
/// External code sets (<see cref="IIsoExternalCode"/>) are, by ISO 20022's own definition,
/// maintained *outside* ISO 20022 — the registry can add codes without a new ISO 20022 schema
/// version. The struct-level constructor on an <see cref="IIsoExternalCode"/> type therefore
/// enforces only its structural constraint (length/pattern) and deliberately does not enforce
/// membership in any specific set of currently-registered values — accepting a syntactically valid
/// but non-existent code is not the same as accepting any string that happens to satisfy the
/// pattern, and this interface is where that distinction is actually enforced.
///
/// One registry per code set type — not one shared registry keyed by name — so each type can have
/// its own backing store: some in-memory (the default, see <see cref="InMemoryExternalCodeRegistry{TCode}"/>),
/// some database-backed, fetched from a reference-data service, etc. Register a custom
/// implementation for a specific <typeparamref name="TCode"/> via the normal DI container — see
/// <c>Iso20022ServiceCollectionExtensions</c> for how the default is wired and how to override it.
/// </remarks>
/// <typeparam name="TCode">The external code set type this registry answers for.</typeparam>
public interface IExternalCodeRegistry<TCode>
    where TCode : IIsoExternalCode
{
    /// <summary>
    /// Returns <see langword="true"/> if <paramref name="value"/> is currently an acceptable value
    /// for this code set.
    /// </summary>
    bool IsAcceptable(TCode value);
}
