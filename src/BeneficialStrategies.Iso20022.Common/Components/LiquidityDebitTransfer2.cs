// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details specific to the liquidity debit transfer, used to transfer an amount of money from the debtor to the creditor, where both are financial institutions.
/// </summary>
[IsoId("_98TyZW49EeiU9cctagi5ow")]
[DisplayName("Liquidity Debit Transfer")]
public partial record LiquidityDebitTransfer2
{
    #nullable enable
    
    /// <summary>
    /// Used to uniquely identify the liquidity transfer.
    /// </summary>
    [IsoId("_-HV9s249EeiU9cctagi5ow")]
    [DisplayName("Liquidity Transfer Identification")]
    [IsoXmlTag("LqdtyTrfId")]
    public PaymentIdentification8? LiquidityTransferIdentification { get; init; } 
    
    /// <summary>
    /// Owner of the account to be credited.
    /// </summary>
    [IsoId("_-HV9tW49EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; } 
    
    /// <summary>
    /// Account to be credited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_-HV9t249EeiU9cctagi5ow")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; } 
    
    /// <summary>
    /// Amount of money that the transaction administrator transfers from one account to another.
    /// </summary>
    [IsoId("_-HV9uW49EeiU9cctagi5ow")]
    [DisplayName("Transferred Amount")]
    [IsoXmlTag("TrfdAmt")]
    public required Amount2Choice_ TransferredAmount { get; init; } 
    
    /// <summary>
    /// Owner of the account to be debited.
    /// </summary>
    [IsoId("_-HV9u249EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; } 
    
    /// <summary>
    /// Account to be debited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_-HV9vW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; } 
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_-HV9v249EeiU9cctagi5ow")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    
    #nullable disable
    
}
