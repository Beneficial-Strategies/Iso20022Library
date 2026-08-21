// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="LiquidityCreditTransfer4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6_VGcTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Defines the characteristics of the liquidity credit transfer.
/// <list type="table">
///   <item><term>Creditor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>CreditorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Debtor</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>LiquidityTransferIdentification</term><description>PaymentIdentification8 — optional (0..1)</description></item>
///   <item><term>SettlementDate</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>TransferredAmount</term><description>Amount2Choice_ — required (1..1)</description></item>
/// </list>
///
/// No constraints are declared on this component in the spec.
///
/// Dependency injection: every nested building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below. <c>BranchAndFinancialInstitutionIdentification8</c> is shared across two properties
/// (<c>Creditor</c>, <c>Debtor</c>); <c>CashAccount40</c> across two (<c>CreditorAccount</c>,
/// <c>DebtorAccount</c>) — one injected validator serves both properties of the same validated
/// type.
/// </remarks>
public class LiquidityCreditTransfer4Validator : AbstractValidator<LiquidityCreditTransfer4>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every nested building block — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    /// <param name="agentValidator">
    /// Validator for the <c>Creditor</c> and <c>Debtor</c> building blocks (both
    /// BranchAndFinancialInstitutionIdentification8).
    /// </param>
    /// <param name="cashAccountValidator">
    /// Validator for the <c>CreditorAccount</c> and <c>DebtorAccount</c> building blocks (both
    /// CashAccount40).
    /// </param>
    /// <param name="liquidityTransferIdentificationValidator">
    /// Validator for the optional <c>LiquidityTransferIdentification</c> building block
    /// (PaymentIdentification8, 0..1).
    /// </param>
    /// <param name="transferredAmountValidator">
    /// Validator for the required <c>TransferredAmount</c> building block (Amount2Choice_, 1..1).
    /// </param>
    public LiquidityCreditTransfer4Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<CashAccount40> cashAccountValidator,
        IValidator<PaymentIdentification8> liquidityTransferIdentificationValidator,
        IValidator<Amount2Choice_> transferredAmountValidator
    )
    {
        // SettlementDate: optional scalar, format enforced by the struct constructor — no rule
        // needed.

        RuleFor(x => x.TransferredAmount).SetValidator(transferredAmountValidator);

        When(x => x.Creditor is not null, () => RuleFor(x => x.Creditor).SetValidator(agentValidator!));
        When(x => x.Debtor is not null, () => RuleFor(x => x.Debtor).SetValidator(agentValidator!));

        When(
            x => x.CreditorAccount is not null,
            () => RuleFor(x => x.CreditorAccount).SetValidator(cashAccountValidator!)
        );
        When(
            x => x.DebtorAccount is not null,
            () => RuleFor(x => x.DebtorAccount).SetValidator(cashAccountValidator!)
        );

        When(
            x => x.LiquidityTransferIdentification is not null,
            () =>
                RuleFor(x => x.LiquidityTransferIdentification)
                    .SetValidator(liquidityTransferIdentificationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every nested building block is
    /// validated by its own default validator
    /// (<see cref="BranchAndFinancialInstitutionIdentification8Validator"/>,
    /// <see cref="CashAccount40Validator"/>, <see cref="PaymentIdentification8Validator"/>,
    /// <see cref="Amount2Choice_Validator"/>). Convenience constructor for callers not using a DI
    /// container.
    /// </summary>
    public LiquidityCreditTransfer4Validator()
        : this(
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new CashAccount40Validator(),
            new PaymentIdentification8Validator(),
            new Amount2Choice_Validator()
        ) { }
}
