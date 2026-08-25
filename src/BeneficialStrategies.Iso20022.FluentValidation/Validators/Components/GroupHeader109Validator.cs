// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader109"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _wYcAQTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Set of characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1); lexical form enforced by struct constructor — no rule needed</description></item>
///   <item><term>InstructingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InstructedAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>InstructingAgent</c> and <c>InstructedAgent</c> are each validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class GroupHeader109Validator : AbstractValidator<GroupHeader109>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>InstructingAgent</c> and <c>InstructedAgent</c> building blocks — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public GroupHeader109Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> instructingAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructedAgentValidator
    )
    {
        // MessageIdentification: required scalar, length enforced by struct constructor — no rule needed.
        // CreationDateTime: required, lexical form enforced by struct constructor — no rule needed.

        When(
            x => x.InstructingAgent is not null,
            () => RuleFor(x => x.InstructingAgent).SetValidator(instructingAgentValidator!)
        );

        When(
            x => x.InstructedAgent is not null,
            () => RuleFor(x => x.InstructedAgent).SetValidator(instructedAgentValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>InstructingAgent</c> and
    /// <c>InstructedAgent</c> are each validated by their own default
    /// <see cref="BranchAndFinancialInstitutionIdentification8Validator"/>. Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public GroupHeader109Validator()
        : this(
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator()
        ) { }
}
