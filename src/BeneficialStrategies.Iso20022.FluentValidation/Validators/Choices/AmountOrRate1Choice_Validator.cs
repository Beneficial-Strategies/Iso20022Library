// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="AmountOrRate1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Q-UncNp-Ed-ak6NoX_4Aeg_458279675
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Choice between an amount or a rate.
/// <list type="table">
///   <item><term><see cref="Choices.AmountOrRate1Choice.Amount"/></term><description>Currency/Value: raw <c>string</c>/<c>decimal</c> (ActiveCurrencyAndAmount-shaped for the XML Ccy-attribute pattern — outside the <c>IIsoSimpleValue&lt;T&gt;</c>/Amounts-namespace coverage tracked by this project, same as every other amount-choice variant built so far)</description></item>
///   <item><term><see cref="Choices.AmountOrRate1Choice.Rate"/></term><description>Value: PercentageRate (fully struct-enforced, no further rule needed)</description></item>
/// </list>
///
/// No additional cross-field or business rule to add at the FluentValidation layer, so this
/// validator has no rules. It still exists as a first-class type so the coverage-scoping policy
/// (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed
/// rather than silently skipped.
/// </remarks>
public class AmountOrRate1Choice_Validator : AbstractValidator<AmountOrRate1Choice_> { }
