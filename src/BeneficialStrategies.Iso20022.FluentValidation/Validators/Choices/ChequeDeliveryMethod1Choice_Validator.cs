// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="ChequeDeliveryMethod1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// Choice between a coded or a proprietary delivery method of a cheque.
/// <list type="table">
///   <item><term><see cref="Choices.ChequeDeliveryMethod1Choice.Code"/></term><description>Value: ChequeDelivery1Code (closed enum, fully enforced)</description></item>
///   <item><term><see cref="Choices.ChequeDeliveryMethod1Choice.Proprietary"/></term><description>Value: Max35Text (fully struct-enforced)</description></item>
/// </list>
///
/// Both variants are fully enforced at the type level already; this validator has no rules. It
/// exists so the coverage-scoping policy (see the project's <c>CLAUDE.md</c>) records the type as
/// reviewed, and so a message that reaches it is validated end to end.
/// </remarks>
public class ChequeDeliveryMethod1Choice_Validator : AbstractValidator<ChequeDeliveryMethod1Choice_> { }
