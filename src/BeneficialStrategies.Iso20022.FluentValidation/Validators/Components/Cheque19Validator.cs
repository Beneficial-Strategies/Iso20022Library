// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Cheque19"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// Rewritten from the ISO 20022 repository when the members of the component were corrected (#47): the members, their order and
/// occurrences are the repository's. Every member that is a component or a choice is validated by an injected
/// <see cref="IValidator{T}"/>; the simple types and code sets check themselves when they are built.
/// <list type="table">
///   <item><term>ChequeType</term><description>ChequeType2Code — optional (0..1)</description></item>
///   <item><term>ChequeNumber</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>ChequeFrom</term><description>NameAndAddress18 — optional (0..1)</description></item>
///   <item><term>DeliveryMethod</term><description>ChequeDeliveryMethod1Choice_ — optional (0..1)</description></item>
///   <item><term>DeliverTo</term><description>NameAndAddress18 — optional (0..1)</description></item>
///   <item><term>InstructionPriority</term><description>Priority2Code — optional (0..1)</description></item>
///   <item><term>ChequeMaturityDate</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>FormsCode</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>MemoField</term><description>Max35Text — collection (0..n)</description></item>
///   <item><term>RegionalClearingZone</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>PrintLocation</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>Signature</term><description>Max70Text — collection (0..n)</description></item>
/// </list>
/// </remarks>
public class Cheque19Validator : AbstractValidator<Cheque19>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public Cheque19Validator(
        IValidator<NameAndAddress18> nameAndAddress18Validator,
        IValidator<ChequeDeliveryMethod1Choice_> chequeDeliveryMethod1ChoiceValidator
    )
    {
        When(
            x => x.ChequeFrom is not null,
            () => RuleFor(x => x.ChequeFrom).SetValidator(nameAndAddress18Validator!)
        );
        When(
            x => x.DeliveryMethod is not null,
            () => RuleFor(x => x.DeliveryMethod).SetValidator(chequeDeliveryMethod1ChoiceValidator!)
        );
        When(
            x => x.DeliverTo is not null,
            () => RuleFor(x => x.DeliverTo).SetValidator(nameAndAddress18Validator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public Cheque19Validator()
        : this(
            new NameAndAddress18Validator(),
            new ChequeDeliveryMethod1Choice_Validator()
        ) { }
}
