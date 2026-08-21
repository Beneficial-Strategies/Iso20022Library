// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="GeneralBusinessInformationCriteriaDefinition1Choice_"/> per the ISO
/// 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1VwUF5lZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the information that is searched either implicitly by recalling a previous query or
/// explicitly by defining the criteria.
/// <list type="table">
///   <item><term><see cref="GeneralBusinessInformationCriteriaDefinition1Choice.QueryName"/></term><description>Recalls the criteria defined in a preceding query — Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria"/></term><description>Defines the criteria based on which the information is extracted — NewQueryName (Max35Text, optional), SearchCriteria (GeneralBusinessInformationSearchCriteria1, optional), ReturnCriteria (GeneralBusinessInformationReturnCriteria1, optional)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below. Only the
/// <c>NewCriteria</c> variant gets an <see cref="InlineValidator{T}"/> — the <c>QueryName</c>
/// variant's <c>Value</c> is fully struct-enforced, so no validator is registered for it;
/// <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// leaves an unregistered variant type as always-valid by design (see
/// <see cref="Party50Choice_Validator"/>'s own remarks).
///
/// Dependency injection: <c>NewCriteria</c>'s <c>SearchCriteria</c> and <c>ReturnCriteria</c> are
/// each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> —
/// see the two constructors below.
/// </remarks>
public class GeneralBusinessInformationCriteriaDefinition1Choice_Validator
    : AbstractValidator<GeneralBusinessInformationCriteriaDefinition1Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>NewCriteria</c> variant's <c>SearchCriteria</c> and <c>ReturnCriteria</c>
    /// building blocks — e.g. resolved from a DI container — instead of this type constructing
    /// its own.
    /// </summary>
    /// <param name="searchCriteriaValidator">
    /// Validator for <see cref="GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria"/>'s
    /// optional <c>SearchCriteria</c> building block (GeneralBusinessInformationSearchCriteria1, 0..1).
    /// </param>
    /// <param name="returnCriteriaValidator">
    /// Validator for <see cref="GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria"/>'s
    /// optional <c>ReturnCriteria</c> building block (GeneralBusinessInformationReturnCriteria1, 0..1).
    /// </param>
    public GeneralBusinessInformationCriteriaDefinition1Choice_Validator(
        IValidator<GeneralBusinessInformationSearchCriteria1> searchCriteriaValidator,
        IValidator<GeneralBusinessInformationReturnCriteria1> returnCriteriaValidator
    )
    {
        var newCriteriaVariantValidator =
            new InlineValidator<Choices.GeneralBusinessInformationCriteriaDefinition1Choice.NewCriteria>();
        newCriteriaVariantValidator.When(
            x => x.SearchCriteria is not null,
            () => newCriteriaVariantValidator.RuleFor(x => x.SearchCriteria).SetValidator(searchCriteriaValidator!)
        );
        newCriteriaVariantValidator.When(
            x => x.ReturnCriteria is not null,
            () => newCriteriaVariantValidator.RuleFor(x => x.ReturnCriteria).SetValidator(returnCriteriaValidator!)
        );

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(newCriteriaVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>NewCriteria.SearchCriteria</c>
    /// and <c>NewCriteria.ReturnCriteria</c> are each validated by their own default validator
    /// (<see cref="GeneralBusinessInformationSearchCriteria1Validator"/>,
    /// <see cref="GeneralBusinessInformationReturnCriteria1Validator"/>). Convenience constructor
    /// for callers not using a DI container.
    /// </summary>
    public GeneralBusinessInformationCriteriaDefinition1Choice_Validator()
        : this(
            new GeneralBusinessInformationSearchCriteria1Validator(),
            new GeneralBusinessInformationReturnCriteria1Validator()
        ) { }
}
