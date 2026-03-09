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
/// Set of elements used to provide information on the dates related to the underlying individual transaction.
/// </summary>
[IsoId("_rkenUa6OEeexrtTFgmVD3Q")]
[DisplayName("Transaction Dates")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionDates3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_rtZ5066OEeexrtTFgmVD3Q")]
    [DisplayName("Acceptance Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptncDtTm")]
    #endif
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? AcceptanceDateTime { get; init; } 
    #else
    public System.DateTime? AcceptanceDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies when an amount of money should have contractually been credited or debited the account versus when the amount of money was actually settled (debited/credited) on the cash account.
    /// </summary>
    [IsoId("_rtZ51a6OEeexrtTFgmVD3Q")]
    [DisplayName("Trade Activity Contractual Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradActvtyCtrctlSttlmDt")]
    #endif
    [IsoXmlTag("TradActvtyCtrctlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeActivityContractualSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeActivityContractualSettlementDate { get; init; } 
    #else
    public System.DateOnly? TradeActivityContractualSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the trade was executed.
    /// </summary>
    [IsoId("_rtZ5166OEeexrtTFgmVD3Q")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeDate { get; init; } 
    #else
    public System.DateOnly? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_rtZ52a6OEeexrtTFgmVD3Q")]
    [DisplayName("Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDt")]
    #endif
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Start date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_rtZ5266OEeexrtTFgmVD3Q")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_rtZ53a6OEeexrtTFgmVD3Q")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EndDate { get; init; } 
    #else
    public System.DateOnly? EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the underlying transaction.
    /// </summary>
    [IsoId("_rtZ5366OEeexrtTFgmVD3Q")]
    [DisplayName("Transaction Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtTm")]
    #endif
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionDateTime { get; init; } 
    #else
    public System.DateTime? TransactionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary date related to the underlying transaction.
    /// </summary>
    [IsoId("_rtZ54a6OEeexrtTFgmVD3Q")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProprietaryDate3? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProprietaryDate3? Proprietary { get; init; } 
    #else
    public ProprietaryDate3? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
