// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Transactions11"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1paxszEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>TransactionReport</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// Constraints (from spec) — <b>enforced</b>:
/// <list type="bullet">
///   <item><term>TransferValueDateRule</term><description>If PaymentCommonInformation/RequestedExecutionDate is present, then TransactionReport/Transaction/Payment/RequestedExecutionDate is not allowed.</description></item>
///   <item><term>CreditDebitIndicator1Rule</term><description>If PaymentCommonInformation/CreditDebitIndicator is present, then TransactionReport/Transaction/CreditDebitIndicator is not allowed.</description></item>
/// </list>
///
/// Constraint (from spec) — <b>NOT enforceable, spec/model mismatch</b>:
/// <list type="bullet">
///   <item><term>PaymentInstructionStatusRule</term><description>If PaymentCommonInformation/PaymentInstructionStatus is present, then TransactionReport/Transaction/Payment/InstructionStatus/PaymentInstructionStatus is not allowed.</description></item>
/// </list>
/// Neither side of this rule exists in the generated model: <see cref="PaymentCommon6"/> (the
/// "PaymentCommonInformation" type) has no <c>PaymentInstructionStatus</c> element — it has
/// <c>CommonStatus</c>, a <c>ValueList&lt;PaymentStatus6&gt;</c>. <see cref="PaymentInstruction47"/>
/// (the "Payment" type, reached via <c>TransactionReport[*].TransactionOrError</c> when it's the
/// <see cref="Choices.TransactionOrError6Choice.Transaction"/> variant) has no
/// <c>InstructionStatus</c> element either — it has its own <c>Status</c>, also a
/// <c>ValueList&lt;PaymentStatus6&gt;</c> exposing <c>Code</c>, not a single
/// <c>PaymentInstructionStatus</c> value. Left unimplemented rather than guessing which list
/// entry or field the spec author intended.
/// </remarks>
public class Transactions11Validator : AbstractValidator<Transactions11>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="Transactions11"/>.
    /// </summary>
    public Transactions11Validator()
    {
        // ── Cross-field constraints (enforceable subset — see class remarks) ──────
        // Both rules only constrain occurrences where TransactionOrError is the Transaction
        // variant — the BusinessError variant carries no Payment/CreditDebitIndicator to check.

        RuleFor(x => x)
            .Must(x =>
                x.PaymentCommonInformation?.RequestedExecutionDate is null
                || !x
                    .TransactionReport.Select(t => t.TransactionOrError)
                    .OfType<Choices.TransactionOrError6Choice.Transaction>()
                    .Any(t => t.Value.Payment?.RequestedExecutionDate is not null)
            )
            .WithName("TransferValueDateRule")
            .WithMessage(
                "If PaymentCommonInformation/RequestedExecutionDate is present, then "
                    + "TransactionReport/Transaction/Payment/RequestedExecutionDate is not allowed "
                    + "(TransferValueDateRule)."
            );

        RuleFor(x => x)
            .Must(x =>
                x.PaymentCommonInformation?.CreditDebitIndicator is null
                || !x
                    .TransactionReport.Select(t => t.TransactionOrError)
                    .OfType<Choices.TransactionOrError6Choice.Transaction>()
                    .Any(t => t.Value.CreditDebitIndicator is not null)
            )
            .WithName("CreditDebitIndicator1Rule")
            .WithMessage(
                "If PaymentCommonInformation/CreditDebitIndicator is present, then "
                    + "TransactionReport/Transaction/CreditDebitIndicator is not allowed "
                    + "(CreditDebitIndicator1Rule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // PaymentCommonInformation (PaymentCommon6, 0..1), TransactionsSummary
        // (NumberAndSumOfTransactions2, 0..1): no validator exists yet for these; nested fields
        // unvalidated beyond the cross-field constraints already enforced above.

        // TransactionReport: TransactionReport8, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.TransactionReport)
            .NotEmpty()
            .WithMessage("Transactions11.TransactionReport must contain at least one element (1..∞).");
    }
}
