// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="CurrencyCriteriaDefinition1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _HxiIV5lZEeeE1Ya-LgRsuQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the information that is searched either implicitly by recalling a previous query or
/// explicitly by defining the criteria.
/// <list type="table">
///   <item><term><see cref="CurrencyCriteriaDefinition1Choice.QueryName"/></term><description>Recalls the criteria defined in a preceding query — Value: Max35Text (fully struct-enforced, no further rule needed)</description></item>
///   <item><term><see cref="CurrencyCriteriaDefinition1Choice.NewCriteria"/></term><description>Defines the criteria based on which the information is extracted — NewQueryName (Max35Text, optional), SearchCriteria (CurrencyExchangeSearchCriteria1 collection, 0..∞)</description></item>
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
/// Dependency injection: each item of <c>NewCriteria.SearchCriteria</c> is validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class CurrencyCriteriaDefinition1Choice_Validator : AbstractValidator<CurrencyCriteriaDefinition1Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>NewCriteria</c> variant's <c>SearchCriteria</c> item type — e.g. resolved from a
    /// DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="searchCriteriaValidator">
    /// Validator for each item of <see cref="CurrencyCriteriaDefinition1Choice.NewCriteria"/>'s
    /// <c>SearchCriteria</c> collection (CurrencyExchangeSearchCriteria1, 0..∞).
    /// </param>
    public CurrencyCriteriaDefinition1Choice_Validator(
        IValidator<CurrencyExchangeSearchCriteria1> searchCriteriaValidator
    )
    {
        var newCriteriaVariantValidator = new InlineValidator<Choices.CurrencyCriteriaDefinition1Choice.NewCriteria>();
        newCriteriaVariantValidator
            .RuleForEach(x => x.SearchCriteria)
            .SetValidator(searchCriteriaValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(newCriteriaVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>NewCriteria.SearchCriteria</c>
    /// items are validated by their own default validator
    /// (<see cref="CurrencyExchangeSearchCriteria1Validator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public CurrencyCriteriaDefinition1Choice_Validator()
        : this(new CurrencyExchangeSearchCriteria1Validator()) { }
}
