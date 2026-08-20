// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

/// <summary>
/// Validates <see cref="CountryCode"/> against the currently-acceptable ISO 3166 alpha-2 country
/// codes.
/// </summary>
/// <remarks>
/// <see cref="CountryCode"/>'s own constructor enforces only the structural pattern
/// (<c>^[A-Z]{2}$</c>) — it does not know which two-letter combinations are actually assigned
/// countries under the current edition of ISO 3166. This validator adds that check via an
/// injected <see cref="IExternalCodeRegistry{TCode}"/> — see that interface's own remarks for why
/// this lives here and not in the struct itself, and <see cref="InMemoryExternalCodeRegistry{TCode}"/>
/// for the default registry's permissive-until-populated behavior (as of 2026-08-20,
/// <see cref="CountryCode"/> declares no known-value members, so the default registry is
/// permissive for this type until a caller populates it).
/// </remarks>
public class CountryCodeValidator : ExternalCodesetAbstractValidator<CountryCode>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the registry —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CountryCodeValidator(IExternalCodeRegistry<CountryCode> registry)
        : base(registry) { }

    /// <summary>
    /// Initializes a new instance using a default in-memory registry. Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public CountryCodeValidator() { }
}
