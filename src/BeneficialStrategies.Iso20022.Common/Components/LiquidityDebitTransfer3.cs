// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details specific to the liquidity debit transfer, used to transfer an amount of money from the debtor to the creditor, where both are financial institutions.
/// </summary>
[IsoId("_cUs1kdcZEeqRFcf2R4bPBw")]
[DisplayName("Liquidity Debit Transfer")]
public record LiquidityDebitTransfer3
{
    /// <summary>
    /// Used to uniquely identify the liquidity transfer.
    /// </summary>
    [IsoId("_cWSxA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Liquidity Transfer Identification")]
    [IsoXmlTag("LqdtyTrfId")]
    public PaymentIdentification8? LiquidityTransferIdentification { get; init; }

    /// <summary>
    /// Owner of the account to be credited.
    /// </summary>
    [IsoId("_cWSxBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; }

    /// <summary>
    /// Account to be credited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_cWSxB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Amount of money that the transaction administrator transfers from one account to another.
    /// </summary>
    [IsoId("_cWSxCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transferred Amount")]
    [IsoXmlTag("TrfdAmt")]
    public required Amount2Choice_ TransferredAmount { get; init; }

    /// <summary>
    /// Owner of the account to be debited.
    /// </summary>
    [IsoId("_cWSxC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; }

    /// <summary>
    /// Account to be debited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_cWSxDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_cWSxD9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; }
}
