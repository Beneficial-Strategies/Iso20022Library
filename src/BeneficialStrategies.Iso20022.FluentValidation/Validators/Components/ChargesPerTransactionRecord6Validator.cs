// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ChargesPerTransactionRecord6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _HEdKsT0QEe-thIfLZ94a1w
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>ChargesBreakdown</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public sealed class ChargesPerTransactionRecord6Validator : AbstractValidator<ChargesPerTransactionRecord6>
{
    public ChargesPerTransactionRecord6Validator()
    {
        // UnderlyingTransaction (TransactionReferences7): required (1..1) and already `required`
        // C# property — no rule needed. No validator exists yet for TransactionReferences7;
        // nested fields unvalidated.

        // AdditionalInformation, RecordIdentification: optional (0..1) scalars, length enforced
        // by struct constructors — no rule needed.

        // ChargesAccountAgent, ChargesRequestor, DebtorAgent
        // (BranchAndFinancialInstitutionIdentification8, 0..1), ChargesAccountAgentAccount,
        // DebtorAccount, DebtorAgentAccount (CashAccount40, 0..1), Debtor
        // (PartyIdentification272, 0..1), InstructionForInstructedAgent
        // (InstructionForInstructedAgent1, 0..1), SettlementInstruction
        // (SettlementInstruction19, 0..1), TotalChargesPerRecord (TotalCharges8, 0..1),
        // ValueDate (DateAndDateTime2Choice, 0..1): no validator exists yet for these; nested
        // fields unvalidated.

        // ChargesBreakdown: ChargesBreakdown1, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.ChargesBreakdown)
            .NotEmpty()
            .WithMessage("ChargesPerTransactionRecord6.ChargesBreakdown must contain at least one element (1..*).");
    }
}
