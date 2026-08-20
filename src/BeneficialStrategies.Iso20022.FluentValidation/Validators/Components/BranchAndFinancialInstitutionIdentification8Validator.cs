// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="BranchAndFinancialInstitutionIdentification8"/> per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _vxnQ0TEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Unique and unambiguous identification of a financial institution or a branch of a financial
/// institution.
/// <list type="table">
///   <item><term>FinancialInstitutionIdentification</term><description>FinancialInstitutionIdentification23 — required (1..1)</description></item>
///   <item><term>BranchIdentification</term><description>BranchData5 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>BranchIdentification</c> and <c>FinancialInstitutionIdentification</c>
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class BranchAndFinancialInstitutionIdentification8Validator
    : AbstractValidator<BranchAndFinancialInstitutionIdentification8>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>BranchIdentification</c> building block and the required
    /// <c>FinancialInstitutionIdentification</c> building block — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="branchIdentificationValidator">
    /// Validator for the optional <c>BranchIdentification</c> building block (BranchData5, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="financialInstitutionIdentificationValidator">
    /// Validator for the required <c>FinancialInstitutionIdentification</c> building block
    /// (FinancialInstitutionIdentification23, 1..1).
    /// </param>
    public BranchAndFinancialInstitutionIdentification8Validator(
        IValidator<BranchData5> branchIdentificationValidator,
        IValidator<FinancialInstitutionIdentification23> financialInstitutionIdentificationValidator
    )
    {
        When(
            x => x.BranchIdentification is not null,
            () => RuleFor(x => x.BranchIdentification).SetValidator(branchIdentificationValidator!)
        );

        RuleFor(x => x.FinancialInstitutionIdentification)
            .SetValidator(financialInstitutionIdentificationValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>BranchIdentification</c> and
    /// <c>FinancialInstitutionIdentification</c> are each validated by their own default
    /// validator (<see cref="BranchData5Validator"/>,
    /// <see cref="FinancialInstitutionIdentification23Validator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification8Validator()
        : this(new BranchData5Validator(), new FinancialInstitutionIdentification23Validator()) { }
}
