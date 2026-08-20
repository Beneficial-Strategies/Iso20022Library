// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="FinancialIdentificationSchemeName1Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _QALkMNp-Ed-ak6NoX_4Aeg_-2021925461
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Sets of elements to identify a name of the organisation identification scheme.
/// <list type="table">
///   <item><term><see cref="FinancialIdentificationSchemeName1Choice.Code"/></term><description>Name of the identification scheme, in a coded form as published in an external list — Value: ExternalFinancialInstitutionIdentification1Code</description></item>
///   <item><term><see cref="FinancialIdentificationSchemeName1Choice.Proprietary"/></term><description>Name of the identification scheme, in a free text form — Value: Max35Text</description></item>
/// </list>
///
/// Both variants are fully enforced at the struct level already (an <c>IIsoExternalCode</c>
/// pattern-constrained wrapper / a length-constrained <c>IIsoSimpleValue&lt;string&gt;</c>) —
/// there is no additional cross-field or business rule to add at the FluentValidation layer, so
/// this validator has no rules. It still exists as a first-class type so the coverage-scoping
/// policy (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as
/// reviewed rather than silently skipped.
/// </remarks>
public class FinancialIdentificationSchemeName1Choice_Validator
    : AbstractValidator<FinancialIdentificationSchemeName1Choice_> { }
