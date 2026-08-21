// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="BusinessInformationQueryDefinition3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1NvnkZlZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the query criteria.
/// <list type="table">
///   <item><term>QueryType</term><description>QueryType2Code — optional (0..1)</description></item>
///   <item><term>GeneralBusinessInformationCriteria</term><description>GeneralBusinessInformationCriteriaDefinition1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec. <c>QueryType</c> is a closed C#
/// enum — no rule needed.
///
/// Dependency injection: <c>GeneralBusinessInformationCriteria</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class BusinessInformationQueryDefinition3Validator : AbstractValidator<BusinessInformationQueryDefinition3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>GeneralBusinessInformationCriteria</c> building block — e.g. resolved
    /// from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="generalBusinessInformationCriteriaValidator">
    /// Validator for the optional <c>GeneralBusinessInformationCriteria</c> building block
    /// (GeneralBusinessInformationCriteriaDefinition1Choice_, 0..1) — only invoked when present.
    /// </param>
    public BusinessInformationQueryDefinition3Validator(
        IValidator<GeneralBusinessInformationCriteriaDefinition1Choice_> generalBusinessInformationCriteriaValidator
    )
    {
        When(
            x => x.GeneralBusinessInformationCriteria is not null,
            () =>
                RuleFor(x => x.GeneralBusinessInformationCriteria)
                    .SetValidator(generalBusinessInformationCriteriaValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies:
    /// <c>GeneralBusinessInformationCriteria</c> is validated by its own default validator
    /// (<see cref="GeneralBusinessInformationCriteriaDefinition1Choice_Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public BusinessInformationQueryDefinition3Validator()
        : this(new GeneralBusinessInformationCriteriaDefinition1Choice_Validator()) { }
}
