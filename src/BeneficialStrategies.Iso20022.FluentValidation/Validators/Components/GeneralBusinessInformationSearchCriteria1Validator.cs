// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GeneralBusinessInformationSearchCriteria1"/> per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _51l8cZlZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the criteria used to search for business information.
/// <list type="table">
///   <item><term>Reference</term><description>Max35Text — optional collection (0..∞)</description></item>
///   <item><term>Subject</term><description>CharacterSearch1Choice_ — optional collection (0..∞)</description></item>
///   <item><term>Qualifier</term><description>InformationQualifierType1 — optional collection (0..∞)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>Reference</c>'s items are
/// already fully struct-enforced (Max35Text) — no rule needed beyond that.
///
/// Dependency injection: each item of <c>Subject</c> and <c>Qualifier</c> is validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class GeneralBusinessInformationSearchCriteria1Validator
    : AbstractValidator<GeneralBusinessInformationSearchCriteria1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Subject</c> and <c>Qualifier</c> collections' item types — e.g. resolved from a
    /// DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="subjectValidator">
    /// Validator for each item of the <c>Subject</c> collection (CharacterSearch1Choice_, 0..∞).
    /// </param>
    /// <param name="qualifierValidator">
    /// Validator for each item of the <c>Qualifier</c> collection (InformationQualifierType1, 0..∞).
    /// </param>
    public GeneralBusinessInformationSearchCriteria1Validator(
        IValidator<CharacterSearch1Choice_> subjectValidator,
        IValidator<InformationQualifierType1> qualifierValidator
    )
    {
        RuleForEach(x => x.Subject).SetValidator(subjectValidator);
        RuleForEach(x => x.Qualifier).SetValidator(qualifierValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Subject</c> and <c>Qualifier</c>
    /// are each validated by their own default validator (<see cref="CharacterSearch1Choice_Validator"/>,
    /// <see cref="InformationQualifierType1Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public GeneralBusinessInformationSearchCriteria1Validator()
        : this(new CharacterSearch1Choice_Validator(), new InformationQualifierType1Validator()) { }
}
