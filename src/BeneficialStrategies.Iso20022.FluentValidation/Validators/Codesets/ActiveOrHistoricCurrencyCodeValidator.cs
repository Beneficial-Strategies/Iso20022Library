// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

/// <summary>
/// Validates <see cref="ActiveOrHistoricCurrencyCode"/> against the currently-acceptable ISO 4217
/// currency codes.
/// </summary>
/// <remarks>
/// <see cref="ActiveOrHistoricCurrencyCode"/>'s own constructor enforces only the structural
/// pattern (<c>^[A-Z]{3}$</c>) — it does not know which three-letter combinations are actually
/// assigned (active or historic/withdrawn) currency codes under ISO 4217. This validator adds
/// that check via an injected <see cref="IExternalCodeRegistry{TCode}"/> — see that interface's
/// own remarks for why this lives here and not in the struct itself, and
/// <see cref="InMemoryExternalCodeRegistry{TCode}"/> for the default registry's
/// permissive-until-populated behavior (as of 2026-08-20,
/// <see cref="ActiveOrHistoricCurrencyCode"/> declares no known-value members, so the default
/// registry is permissive for this type until a caller populates it).
/// </remarks>
public class ActiveOrHistoricCurrencyCodeValidator
    : ExternalCodesetAbstractValidator<ActiveOrHistoricCurrencyCode>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the registry —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public ActiveOrHistoricCurrencyCodeValidator(
        IExternalCodeRegistry<ActiveOrHistoricCurrencyCode> registry
    )
        : base(registry) { }

    /// <summary>
    /// Initializes a new instance using a default in-memory registry. Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public ActiveOrHistoricCurrencyCodeValidator() { }
}
