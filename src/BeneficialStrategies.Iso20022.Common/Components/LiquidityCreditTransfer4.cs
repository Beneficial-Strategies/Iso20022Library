// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Liquidity Credit Transfer4.
/// </summary>
[IsoId("_6_VGcTEyEe6g-ffJsqGiSA")]
[DisplayName("Liquidity Credit Transfer4")]
public record LiquidityCreditTransfer4
{
    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification8? Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public BranchAndFinancialInstitutionIdentification8? Debtor { get; init; }

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Liquidity Transfer Identification.
    /// </summary>
    [DisplayName("Liquidity Transfer Identification")]
    [IsoXmlTag("LqdtyTrfId")]
    public PaymentIdentification8? LiquidityTransferIdentification { get; init; }

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public IsoISODate? SettlementDate { get; init; }

    /// <summary>
    /// Transferred Amount.
    /// </summary>
    [DisplayName("Transferred Amount")]
    [IsoXmlTag("TrfdAmt")]
    public required Amount2Choice_ TransferredAmount { get; init; }
}
