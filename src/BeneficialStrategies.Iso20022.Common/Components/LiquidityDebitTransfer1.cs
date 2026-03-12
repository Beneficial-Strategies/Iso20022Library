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
[IsoId("_8Fu9p6MgEeCJ6YNENx4h-w_-1315856281")]
[DisplayName("Liquidity Debit Transfer")]
public partial record LiquidityDebitTransfer1
{
    #nullable enable
    
    /// <summary>
    /// Used to uniquely identify the liquidity transfer.
    /// </summary>
    [IsoId("_8Fu9qKMgEeCJ6YNENx4h-w_-1496950118")]
    [DisplayName("Liquidity Transfer Identification")]
    [IsoXmlTag("LqdtyTrfId")]
    public PaymentIdentification1? LiquidityTransferIdentification { get; init; } 
    
    /// <summary>
    /// Owner of the account to be credited.
    /// </summary>
    [IsoId("_8Fu9qaMgEeCJ6YNENx4h-w_-986706855")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public BranchAndFinancialInstitutionIdentification5? Creditor { get; init; } 
    
    /// <summary>
    /// Account to be credited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_8Fu9qqMgEeCJ6YNENx4h-w_1180432598")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; } 
    
    /// <summary>
    /// Amount of money that the transaction administrator transfers from one account to another.
    /// </summary>
    [IsoId("_8F4HkKMgEeCJ6YNENx4h-w_-2036514360")]
    [DisplayName("Transferred Amount")]
    [IsoXmlTag("TrfdAmt")]
    public required Amount2Choice_ TransferredAmount { get; init; } 
    
    /// <summary>
    /// Owner of the account to be debited.
    /// </summary>
    [IsoId("_8F4HkaMgEeCJ6YNENx4h-w_-618925057")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public BranchAndFinancialInstitutionIdentification5? Debtor { get; init; } 
    
    /// <summary>
    /// Account to be debited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_8F4HkqMgEeCJ6YNENx4h-w_-2133752219")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; } 
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_8F4Hk6MgEeCJ6YNENx4h-w_-1244414813")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SettlementDate { get; init; } 
    
    
    #nullable disable
    
}
