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
[IsoId("_gx4ykdcZEeqRFcf2R4bPBw")]
[DisplayName("Liquidity Credit Transfer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidityCreditTransfer3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LiquidityCreditTransfer3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LiquidityCreditTransfer3( Amount2Choice_ reqTransferredAmount )
    {
        TransferredAmount = reqTransferredAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Used to uniquely identify the liquidity transfer.
    /// </summary>
    [IsoId("_g0I1U9cZEeqRFcf2R4bPBw")]
    [DisplayName("Liquidity Transfer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdtyTrfId")]
    #endif
    [IsoXmlTag("LqdtyTrfId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentIdentification8? LiquidityTransferIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification8? LiquidityTransferIdentification { get; init; } 
    #else
    public PaymentIdentification8? LiquidityTransferIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Owner of the account to be credited.
    /// </summary>
    [IsoId("_g0I1VdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? Creditor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be credited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_g0I1V9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? CreditorAccount { get; init; } 
    #else
    public CashAccount40? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money that the transaction administrator transfers from one account to another.
    /// </summary>
    [IsoId("_g0I1WdcZEeqRFcf2R4bPBw")]
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
    [IsoId("_g0I1W9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? Debtor { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be debited as a result of a transfer of liquidity.
    /// </summary>
    [IsoId("_g0I1XdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? DebtorAccount { get; init; } 
    #else
    public CashAccount40? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_g0I1X9cZEeqRFcf2R4bPBw")]
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
