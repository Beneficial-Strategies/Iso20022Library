// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="Party50Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _vqulsTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Identification of a person, an organisation or a financial institution.
///
/// This is a choice component: exactly one of its two variants is present on any given
/// instance (enforced by the C# model — <see cref="Party50Choice_"/> is an abstract record and
/// each variant is a distinct derived record with its own single <c>Value</c> property).
/// <list type="table">
///   <item><term><see cref="Party50Choice.Party"/></term><description>Identification of a person or an organisation — Value: PartyIdentification272</description></item>
///   <item><term><see cref="Party50Choice.Agent"/></term><description>Identification of a financial institution — Value: BranchAndFinancialInstitutionIdentification8</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below — see
/// "Validating polymorphic choice types" in the FluentValidation project's own <c>CLAUDE.md</c>.
///
/// Dependency injection: each variant's nested <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class Party50Choice_Validator : AbstractValidator<Party50Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for each variant's nested <c>Value</c> — e.g. resolved from a DI container — instead of
    /// this type constructing its own.
    /// </summary>
    /// <param name="agentValueValidator">
    /// Validator for <see cref="Party50Choice.Agent"/>'s <c>Value</c> (BranchAndFinancialInstitutionIdentification8).
    /// </param>
    /// <param name="partyValueValidator">
    /// Validator for <see cref="Party50Choice.Party"/>'s <c>Value</c> (PartyIdentification272).
    /// </param>
    public Party50Choice_Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValueValidator,
        IValidator<PartyIdentification272> partyValueValidator
    )
    {
        var agentVariantValidator = new InlineValidator<Choices.Party50Choice.Agent>();
        agentVariantValidator.RuleFor(x => x.Value).SetValidator(agentValueValidator);

        var partyVariantValidator = new InlineValidator<Choices.Party50Choice.Party>();
        partyVariantValidator.RuleFor(x => x.Value).SetValidator(partyValueValidator);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(agentVariantValidator);
                v.Add(partyVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: each variant's nested <c>Value</c>
    /// is validated by its own default validator
    /// (<see cref="BranchAndFinancialInstitutionIdentification8Validator"/>,
    /// <see cref="PartyIdentification272Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public Party50Choice_Validator()
        : this(
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new PartyIdentification272Validator()
        ) { }
}
