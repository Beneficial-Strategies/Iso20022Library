// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SettlementDateTimeIndication1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _QIYeB9p-Ed-ak6NoX_4Aeg_-498720410
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Information on the occurred settlement time(s) of the payment transaction.
/// <list type="table">
///   <item><term>DebitDateTime</term><description>ISODateTime — optional (0..1)</description></item>
///   <item><term>CreditDateTime</term><description>ISODateTime — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry — no ordering rule between DebitDateTime/CreditDateTime is specified).
/// Both fields are already fully enforced at the <see cref="BeneficialStrategies.Iso20022.SimpleTypes.ISODateTime"/> struct level (lexical
/// form parsing) — nothing left for FluentValidation to add. Empty shell exists as a first-class
/// type per the coverage-scoping policy ("reviewed and confirmed to need nothing"), same
/// convention as <c>AddressType3Choice_Validator</c>.
/// </remarks>
public class SettlementDateTimeIndication1Validator : AbstractValidator<SettlementDateTimeIndication1> { }
