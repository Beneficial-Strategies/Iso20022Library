// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="DuplicateV07"/> (camt.034.001.07) per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3IjtTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The Duplicate message is used by financial institutions, with their own offices, and/or with
/// other financial institutions with which they have established bilateral agreements. It allows
/// the exchange of duplicate payment instructions.
///
/// Usage
/// This message must be sent in response to a RequestForDuplicate message. The Duplicate Data
/// element must contain a well formed XML document — XML special characters such as '&lt;' must be
/// used in a way that is consistent with XML well-formedness criteria.
///
/// <list type="table">
///   <item><term>Assignment</term><description>CaseAssignment6 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — optional (0..1)</description></item>
///   <item><term>Duplicate</term><description>ProprietaryData7 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry). The "well formed XML document" usage note applies to content inside
/// <see cref="ExternalSchema.SkipPayload"/> (reached via <c>Duplicate.Data.Any</c>), which
/// deliberately carries no properties and is not subject to further validation at this layer —
/// see <see cref="ProprietaryData6Validator"/>'s own remarks.
///
/// Dependency injection: <c>Assignment</c>, the optional <c>Case</c> building block,
/// <c>Duplicate</c>, and the <c>SupplementaryData</c> collection are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class DuplicateV07Validator : AbstractValidator<DuplicateV07>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Assignment</c> and <c>Duplicate</c> building blocks, the optional
    /// <c>Case</c> building block, and the <c>SupplementaryData</c> collection's item type — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="assignmentValidator">
    /// Validator for the required <c>Assignment</c> building block (CaseAssignment6, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the optional <c>Case</c> building block (Case6, 0..1) — only invoked when
    /// present.
    /// </param>
    /// <param name="duplicateValidator">
    /// Validator for the required <c>Duplicate</c> building block (ProprietaryData7, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public DuplicateV07Validator(
        IValidator<CaseAssignment6> assignmentValidator,
        IValidator<Case6> caseValidator,
        IValidator<ProprietaryData7> duplicateValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Assignment).SetValidator(assignmentValidator);

        When(x => x.Case is not null, () => RuleFor(x => x.Case).SetValidator(caseValidator!));

        RuleFor(x => x.Duplicate).SetValidator(duplicateValidator);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Assignment</c>, <c>Case</c>,
    /// <c>Duplicate</c>, and the <c>SupplementaryData</c> collection are each validated by their
    /// own default validator (<see cref="CaseAssignment6Validator"/>, <see cref="Case6Validator"/>,
    /// <see cref="ProprietaryData7Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public DuplicateV07Validator()
        : this(
            new CaseAssignment6Validator(),
            new Case6Validator(),
            new ProprietaryData7Validator(),
            new SupplementaryData1Validator()
        ) { }
}
