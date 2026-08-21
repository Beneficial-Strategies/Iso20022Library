// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PaymentConditionStatus2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _FJs0oWwLEe6Mn47rYvO6fQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Specifies the details on the status of the payment conditions.
/// <list type="table">
///   <item><term>AcceptedAmount</term><description>ActiveCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>EarlyPayment</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
///   <item><term>GuaranteedPayment</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry). Note the spec's own Usage text on <c>AcceptedAmount</c>
/// ("May only be present when AmountModificationAllowed is present in the request") refers to a
/// sibling field on the *original request* message (<c>PaymentCondition2.AmountModificationAllowed</c>),
/// not a field on this component itself — this validator has no visibility into that other
/// message's content, so the rule is not enforceable here.
///
/// All fields are either fully struct-enforced or fall under the Amounts-namespace exemption —
/// there is no additional rule to add at the FluentValidation layer, so this validator has no
/// rules. It still exists as a first-class type so the coverage-scoping policy (see the
/// FluentValidation project's own <c>CLAUDE.md</c>) can record this type as reviewed rather than
/// silently skipped.
/// </remarks>
public class PaymentConditionStatus2Validator : AbstractValidator<PaymentConditionStatus2> { }
