// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details specific to the liquidity credit transfer, used to transfer an amount of money from the debtor to the creditor, where both are financial institutions.
/// </summary>
[IsoId("_8FlMpaMgEeCJ6YNENx4h-w_1212962921")]
[DisplayName("Liquidity Credit Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidityCreditTransfer1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LiquidityCreditTransfer1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LiquidityCreditTransfer1( Amount2Choice_ reqTransferredAmount )
    {
        TransferredAmount = reqTransferredAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Used to uniquely identify the liquidity transfer.
    /// </summary>
    [IsoId("_8FlMpqMgEeCJ6YNENx4h-w_-905072723")]
    [DisplayName("Liquidity Transfer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdtyTrfId")]
    #endif
    [IsoXmlTag("LqdtyTrfId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentIdentification1? LiquidityTransferIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification1? LiquidityTransferIdentification { get; init; } 
    #else
    public PaymentIdentification1? LiquidityTransferIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account to be credited.
    /// </summary>
    [IsoId("_8FlMp6MgEeCJ6YNENx4h-w_-1737399545")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? Creditor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be credited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_8FlMqKMgEeCJ6YNENx4h-w_-1665582877")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? CreditorAccount { get; init; } 
    #else
    public CashAccount24? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that the transaction administrator transfers from one account to another.
    /// </summary>
    [IsoId("_8Fu9oKMgEeCJ6YNENx4h-w_-904817724")]
    [DisplayName("Transferred Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfdAmt")]
    #endif
    [IsoXmlTag("TrfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2Choice_ TransferredAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2Choice_ TransferredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_ TransferredAmount { get; init; } 
    #else
    public Amount2Choice_ TransferredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account to be debited.
    /// </summary>
    [IsoId("_8Fu9oaMgEeCJ6YNENx4h-w_-1222594385")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification5? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5? Debtor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be debited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_8Fu9oqMgEeCJ6YNENx4h-w_194994918")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? DebtorAccount { get; init; } 
    #else
    public CashAccount24? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_8Fu9o6MgEeCJ6YNENx4h-w_-1435428673")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
