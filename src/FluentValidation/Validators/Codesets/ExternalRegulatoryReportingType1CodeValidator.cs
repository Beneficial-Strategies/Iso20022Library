// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

/// <summary>
/// Validates <see cref="ExternalRegulatoryReportingType1Code"/> against the currently-acceptable
/// regulatory reporting type codes.
/// </summary>
/// <remarks>
/// <see cref="ExternalRegulatoryReportingType1Code"/>'s own constructor enforces only the
/// structural pattern (1-4 characters per MCP's published length facet) — it does not know which
/// combinations are actually assigned codes under the current edition of the external registry.
/// This validator adds that check via an injected <see cref="IExternalCodeRegistry{TCode}"/> —
/// see that interface's own remarks for why this lives here and not in the struct itself, and
/// <see cref="InMemoryExternalCodeRegistry{TCode}"/> for the default registry's
/// permissive-until-populated behavior (as of 2026-08-20,
/// <see cref="ExternalRegulatoryReportingType1Code"/> declares no known-value members, so the
/// default registry is permissive for this type until a caller populates it).
/// </remarks>
public class ExternalRegulatoryReportingType1CodeValidator
    : ExternalCodesetAbstractValidator<ExternalRegulatoryReportingType1Code>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the registry —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public ExternalRegulatoryReportingType1CodeValidator(
        IExternalCodeRegistry<ExternalRegulatoryReportingType1Code> registry
    )
        : base(registry) { }

    /// <summary>
    /// Initializes a new instance using a default in-memory registry. Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public ExternalRegulatoryReportingType1CodeValidator() { }
}
