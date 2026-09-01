// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="MandateClassification1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _JThtg2oDEearR-CA7eRZXQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the high level purpose of the instruction based on a set of pre-defined categories. Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
/// <list type="table">
///   <item><term><see cref="Choices.MandateClassification1Choice.Code"/></term><description>Specifies the mandate classification in a coded form — Value: MandateClassification1Code</description></item>
///   <item><term><see cref="Choices.MandateClassification1Choice.Proprietary"/></term><description>Specifies a character string with a maximum length of 35 characters — Value: Max35Text</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (a closed codeset enum / an
/// <c>IIsoExternalCode</c> pattern-constrained wrapper, or a length-constrained
/// <c>IIsoSimpleValue&lt;string&gt;</c>) — there is no additional cross-field or business rule to
/// add at the FluentValidation layer, so this validator has no rules. It still exists as a
/// first-class type so the coverage-scoping policy (see the FluentValidation project's own
/// <c>CLAUDE.md</c>) can record this type as reviewed rather than silently skipped.
/// </remarks>
public class MandateClassification1Choice_Validator : AbstractValidator<MandateClassification1Choice_> { }
