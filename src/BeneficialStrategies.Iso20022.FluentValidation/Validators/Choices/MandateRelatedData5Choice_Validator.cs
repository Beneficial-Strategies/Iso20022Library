// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="MandateRelatedData5Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _RA3lIbvIEfCYYbmqNrQFSg
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Choice between direct debit mandate and credit transfer mandate data.
/// <list type="table">
///   <item><term><see cref="Choices.MandateRelatedData5Choice.DirectDebitMandate"/></term><description>Value: MandateRelatedInformation16 (required 1..1)</description></item>
///   <item><term><see cref="Choices.MandateRelatedData5Choice.CreditTransferMandate"/></term><description>Value: CreditTransferMandateData1 (required 1..1)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: each variant's <c>Value</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MandateRelatedData5Choice_Validator : AbstractValidator<MandateRelatedData5Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="directDebitMandateValueValidator">
    /// Validator for <see cref="Choices.MandateRelatedData5Choice.DirectDebitMandate"/>'s required
    /// <c>Value</c> (MandateRelatedInformation16, 1..1).
    /// </param>
    /// <param name="creditTransferMandateValueValidator">
    /// Validator for <see cref="Choices.MandateRelatedData5Choice.CreditTransferMandate"/>'s required
    /// <c>Value</c> (CreditTransferMandateData1, 1..1).
    /// </param>
    public MandateRelatedData5Choice_Validator(
        IValidator<MandateRelatedInformation16> directDebitMandateValueValidator,
        IValidator<CreditTransferMandateData1> creditTransferMandateValueValidator
    )
    {
        var directDebitMandateVariantValidator = new InlineValidator<Choices.MandateRelatedData5Choice.DirectDebitMandate>();
        directDebitMandateVariantValidator.RuleFor(x => x.Value).SetValidator(directDebitMandateValueValidator!);

        var creditTransferMandateVariantValidator = new InlineValidator<Choices.MandateRelatedData5Choice.CreditTransferMandate>();
        creditTransferMandateVariantValidator.RuleFor(x => x.Value).SetValidator(creditTransferMandateValueValidator!);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(directDebitMandateVariantValidator);
                v.Add(creditTransferMandateVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: each variant's <c>Value</c> is
    /// validated by its own default validator (<see cref="MandateRelatedInformation16Validator"/>,
    /// <see cref="CreditTransferMandateData1Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public MandateRelatedData5Choice_Validator()
        : this(new MandateRelatedInformation16Validator(), new CreditTransferMandateData1Validator()) { }
}
