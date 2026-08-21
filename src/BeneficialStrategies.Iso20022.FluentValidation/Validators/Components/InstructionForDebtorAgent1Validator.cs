// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="InstructionForDebtorAgent1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _WpOTg8saEemxFbEZK-FMzw
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Further information related to the processing of the payment instruction that may need to be
/// acted upon by the debtor's agent. The instruction may relate to a level of service, or may be
/// an instruction that has to be executed by the debtor's agent, or may be information required
/// by the debtor's agent.
/// <list type="table">
///   <item><term>Code</term><description>ExternalDebtorAgentInstruction1Code — optional (0..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="ExternalDebtorAgentInstruction1CodeValidator"/></description></item>
///   <item><term>InstructionInformation</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Code</c> is validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class InstructionForDebtorAgent1Validator : AbstractValidator<InstructionForDebtorAgent1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public InstructionForDebtorAgent1Validator(IValidator<ExternalDebtorAgentInstruction1Code> codeValidator)
    {
        When(x => x.Code is not null, () => RuleFor(x => x.Code!.Value).SetValidator(codeValidator));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public InstructionForDebtorAgent1Validator()
        : this(new ExternalDebtorAgentInstruction1CodeValidator()) { }
}
