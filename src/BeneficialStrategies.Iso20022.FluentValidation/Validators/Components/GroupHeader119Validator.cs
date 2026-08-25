// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader119"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _282IcTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Set of characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1); lexical form enforced by struct constructor — no rule needed</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — required (1..1); pattern enforced by struct constructor — no rule needed</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1)</description></item>
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
public class GroupHeader119Validator : AbstractValidator<GroupHeader119>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>InstructingAgent</c> and <c>InstructedAgent</c> building blocks — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="instructingAgentValidator">
    /// Validator for the optional <c>InstructingAgent</c> building block
    /// (BranchAndFinancialInstitutionIdentification8, 0..1) — only invoked when present.
    /// </param>
    /// <param name="instructedAgentValidator">
    /// Validator for the optional <c>InstructedAgent</c> building block
    /// (BranchAndFinancialInstitutionIdentification8, 0..1) — only invoked when present.
    /// </param>
    public GroupHeader119Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> instructingAgentValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> instructedAgentValidator
    )
    {
        // MessageIdentification, NumberOfTransactions: required scalars, format/length enforced
        // by struct constructors — no rule needed.
        // CreationDateTime: required, lexical form enforced by struct constructor — no rule needed.
        // ControlSum: optional decimal, no spec-declared range constraint — no rule needed.

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
    public GroupHeader119Validator()
        : this(
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator()
        ) { }
}
