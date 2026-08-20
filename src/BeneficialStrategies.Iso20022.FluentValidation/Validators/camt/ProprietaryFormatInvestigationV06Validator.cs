// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="ProprietaryFormatInvestigationV06"/> (camt.035.001.06) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3SUcTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The ProprietaryFormatInvestigation message type is used by financial institutions, with their
/// own offices, and/or with other financial institutions with which they have established
/// bilateral agreements.
///
/// Usage
/// The user should ensure that an existing standard message cannot be used before using the
/// proprietary message. As defined in the scope, this message may only be used when bilaterally
/// agreed. It is used as an envelope for a non standard message and provides means to manage an
/// exception or investigation which falls outside the scope or capability of any other formatted
/// message. The ProprietaryData element must contain a well formed XML document — XML special
/// characters such as '&lt;' must be used in a way that is consistent with XML well-formedness
/// criteria.
///
/// <list type="table">
///   <item><term>Assignment</term><description>CaseAssignment6 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — optional (0..1)</description></item>
///   <item><term>ProprietaryData</term><description>ProprietaryData7 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry). The "well formed XML document" usage note applies to content inside
/// <see cref="ExternalSchema.SkipPayload"/> (reached via <c>ProprietaryData.Data.Any</c>), which
/// deliberately carries no properties and is not subject to further validation at this layer —
/// see <see cref="ProprietaryData6Validator"/>'s own remarks.
///
/// Dependency injection: <c>Assignment</c>, the optional <c>Case</c> building block,
/// <c>ProprietaryData</c>, and the <c>SupplementaryData</c> collection are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class ProprietaryFormatInvestigationV06Validator : AbstractValidator<ProprietaryFormatInvestigationV06>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Assignment</c> and <c>ProprietaryData</c> building blocks, the
    /// optional <c>Case</c> building block, and the <c>SupplementaryData</c> collection's item
    /// type — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="assignmentValidator">
    /// Validator for the required <c>Assignment</c> building block (CaseAssignment6, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the optional <c>Case</c> building block (Case6, 0..1) — only invoked when
    /// present.
    /// </param>
    /// <param name="proprietaryDataValidator">
    /// Validator for the required <c>ProprietaryData</c> building block (ProprietaryData7, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public ProprietaryFormatInvestigationV06Validator(
        IValidator<CaseAssignment6> assignmentValidator,
        IValidator<Case6> caseValidator,
        IValidator<ProprietaryData7> proprietaryDataValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Assignment).SetValidator(assignmentValidator);

        When(x => x.Case is not null, () => RuleFor(x => x.Case).SetValidator(caseValidator!));

        RuleFor(x => x.ProprietaryData).SetValidator(proprietaryDataValidator);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Assignment</c>, <c>Case</c>,
    /// <c>ProprietaryData</c>, and the <c>SupplementaryData</c> collection are each validated by
    /// their own default validator (<see cref="CaseAssignment6Validator"/>,
    /// <see cref="Case6Validator"/>, <see cref="ProprietaryData7Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public ProprietaryFormatInvestigationV06Validator()
        : this(
            new CaseAssignment6Validator(),
            new Case6Validator(),
            new ProprietaryData7Validator(),
            new SupplementaryData1Validator()
        ) { }
}
