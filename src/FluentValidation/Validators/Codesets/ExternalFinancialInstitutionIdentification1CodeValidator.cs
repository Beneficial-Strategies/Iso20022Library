// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

/// <summary>
/// Validates <see cref="ExternalFinancialInstitutionIdentification1Code"/> against the
/// currently-acceptable values of this external code set.
/// </summary>
/// <remarks>
/// <see cref="ExternalFinancialInstitutionIdentification1Code"/>'s own constructor enforces only
/// the structural pattern (1-4 characters) — it does not know which codes are actually registered
/// under the external financial institution identification scheme name list. This validator adds
/// that check via an injected <see cref="IExternalCodeRegistry{TCode}"/> — see that interface's
/// own remarks for why this lives here and not in the struct itself, and
/// <see cref="InMemoryExternalCodeRegistry{TCode}"/> for the default registry's
/// permissive-until-populated behavior (as of 2026-08-20, this type declares no known-value
/// members, so the default registry is permissive for this type until a caller populates it).
/// </remarks>
public class ExternalFinancialInstitutionIdentification1CodeValidator
    : ExternalCodesetAbstractValidator<ExternalFinancialInstitutionIdentification1Code>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the registry —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public ExternalFinancialInstitutionIdentification1CodeValidator(
        IExternalCodeRegistry<ExternalFinancialInstitutionIdentification1Code> registry
    )
        : base(registry) { }

    /// <summary>
    /// Initializes a new instance using a default in-memory registry. Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public ExternalFinancialInstitutionIdentification1CodeValidator() { }
}
