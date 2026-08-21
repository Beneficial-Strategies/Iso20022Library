// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DocumentAdjustment1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _UP-lctp-Ed-ak6NoX_4Aeg_1188294125
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Set of elements used to provide information on the amount and reason of the document
/// adjustment.
/// <list type="table">
///   <item><term>Amount</term><description>ActiveOrHistoricCurrencyAndAmount — required (1..1), Amounts-namespace exemption</description></item>
///   <item><term>CreditDebitIndicator</term><description>CreditDebitCode — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>Reason</term><description>Max4Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>AdditionalInformation</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// All fields other than <c>Amount</c> (Amounts-namespace exemption) are fully enforced at the
/// struct/enum level already — there is no additional rule to add at the FluentValidation layer,
/// so this validator has no rules. It still exists as a first-class type so the coverage-scoping
/// policy (see the FluentValidation project's own <c>CLAUDE.md</c>) can record this type as
/// reviewed rather than silently skipped.
/// </remarks>
public class DocumentAdjustment1Validator : AbstractValidator<DocumentAdjustment1> { }
