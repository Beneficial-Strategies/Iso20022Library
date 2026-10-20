// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

/// <summary>
/// Validates <see cref="ExternalDebtorAgentInstruction1Code"/> against the currently-acceptable
/// debtor-agent instruction codes.
/// </summary>
/// <remarks>
/// <see cref="ExternalDebtorAgentInstruction1Code"/>'s own constructor enforces only the
/// structural pattern — it does not know which combinations are actually assigned codes under
/// the current edition of the external registry. This validator adds that check via an injected
/// <see cref="IExternalCodeRegistry{TCode}"/> — see that interface's own remarks for why this
/// lives here and not in the struct itself, and <see cref="InMemoryExternalCodeRegistry{TCode}"/>
/// for the default registry's auto-seeding behavior from the type's own known-value members (7
/// as of 2026-08-21, per the hybrid-struct pattern documented in the main library's own
/// <c>CLAUDE.md</c>).
/// </remarks>
public class ExternalDebtorAgentInstruction1CodeValidator
    : ExternalCodesetAbstractValidator<ExternalDebtorAgentInstruction1Code>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the registry —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public ExternalDebtorAgentInstruction1CodeValidator(
        IExternalCodeRegistry<ExternalDebtorAgentInstruction1Code> registry
    )
        : base(registry) { }

    /// <summary>
    /// Initializes a new instance using a default in-memory registry, auto-seeded from this
    /// type's own known-value members. Convenience constructor for callers not using a DI
    /// container.
    /// </summary>
    public ExternalDebtorAgentInstruction1CodeValidator() { }
}
