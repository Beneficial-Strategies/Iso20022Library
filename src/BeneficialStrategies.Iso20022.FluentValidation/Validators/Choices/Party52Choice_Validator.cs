// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="Party52Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _bHNcUTFIEe651u5xu3f5iw
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Specifies the identification of a person or an organisation.
/// <list type="table">
///   <item><term><see cref="Choices.Party52Choice.OrganisationIdentification"/></term><description>Unique and unambiguous way to identify an organisation — Value: OrganisationIdentification39</description></item>
///   <item><term><see cref="Choices.Party52Choice.PrivateIdentification"/></term><description>Unique and unambiguous identification of a person, for example a passport — Value: PersonIdentification18</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: each variant's nested <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class Party52Choice_Validator : AbstractValidator<Party52Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for each variant's nested <c>Value</c> — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="organisationIdentificationValueValidator">
    /// Validator for <see cref="Choices.Party52Choice.OrganisationIdentification"/>'s <c>Value</c>
    /// (OrganisationIdentification39).
    /// </param>
    /// <param name="privateIdentificationValueValidator">
    /// Validator for <see cref="Choices.Party52Choice.PrivateIdentification"/>'s <c>Value</c>
    /// (PersonIdentification18).
    /// </param>
    public Party52Choice_Validator(
        IValidator<OrganisationIdentification39> organisationIdentificationValueValidator,
        IValidator<PersonIdentification18> privateIdentificationValueValidator
    )
    {
        var organisationVariantValidator =
            new InlineValidator<Choices.Party52Choice.OrganisationIdentification>();
        organisationVariantValidator
            .RuleFor(x => x.Value)
            .SetValidator(organisationIdentificationValueValidator);

        var privateVariantValidator = new InlineValidator<Choices.Party52Choice.PrivateIdentification>();
        privateVariantValidator.RuleFor(x => x.Value).SetValidator(privateIdentificationValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(organisationVariantValidator);
                v.Add(privateVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: each variant's nested <c>Value</c>
    /// is validated by its own default validator
    /// (<see cref="OrganisationIdentification39Validator"/>, <see cref="PersonIdentification18Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public Party52Choice_Validator()
        : this(
            new OrganisationIdentification39Validator(),
            new PersonIdentification18Validator()
        ) { }
}
