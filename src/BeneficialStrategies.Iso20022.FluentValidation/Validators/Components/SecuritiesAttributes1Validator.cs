// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="SecuritiesAttributes1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: 15df450f-df3b-4230-9d9a-8fba15b89a4e
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides information on the securities trades that make up the payment.
/// <list type="table">
///   <item><term>UniqueTransactionIdentifier</term><description>UTIIdentifier — required (1..1), fully struct-enforced</description></item>
///   <item><term>Amount</term><description>ActiveCurrencyAndAmount — optional (0..1), Amounts-namespace exemption (see <see cref="AmountType4Choice_Validator"/>'s own remarks)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Both fields are either fully struct-enforced or fall under the Amounts-namespace exemption —
/// there is no additional rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class SecuritiesAttributes1Validator : AbstractValidator<SecuritiesAttributes1> { }
