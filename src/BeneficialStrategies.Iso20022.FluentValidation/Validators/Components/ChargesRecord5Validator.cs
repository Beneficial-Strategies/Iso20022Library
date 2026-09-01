// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ChargesRecord5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _n3siQbt7Eeq_cfXrH83Rcw
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>UnderlyingTransaction</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public class ChargesRecord5Validator : AbstractValidator<ChargesRecord5>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="ChargesRecord5"/>.
    /// </summary>
    public ChargesRecord5Validator()
    {
        // Amount (ActiveCurrencyAndAmount): required (1..1) and already `required` C# property —
        // no rule needed. No validator exists yet for it; nested fields unvalidated.

        // ChargesRecordIdentification, AdditionalInformation: optional (0..1) scalars, length
        // enforced by struct constructors — no rule needed.

        // CreditDebitIndicator (CreditDebitCode), ValueDate (DateAndDateTime2Choice), Type
        // (ChargeType3Choice), InstructionForInstructedAgent (InstructionForInstructedAgent1):
        // optional (0..1) fields with no validator yet — nested fields unvalidated.

        // DebtorAgent, ChargesAccountAgent
        // (BranchAndFinancialInstitutionIdentification6, 0..1), DebtorAgentAccount,
        // ChargesAccountAgentAccount (CashAccount40, 0..1): no validator exists yet for these;
        // nested fields unvalidated.

        // UnderlyingTransaction: TransactionReferences7, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.UnderlyingTransaction)
            .NotEmpty()
            .WithMessage("ChargesRecord5.UnderlyingTransaction must contain at least one element (1..*).");
    }
}
