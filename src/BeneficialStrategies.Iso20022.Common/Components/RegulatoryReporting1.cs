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
/// Includes data elements that can be used for reporting to trade repositories, it is not to be used on regular trade confirmations. Although some fields, for example, unique transaction identifier and prior unique transaction identifier, might be used on regular confirmations.
/// </summary>
[IsoId("_SEtVEyi-EeKnA5P_jl2DUw")]
[DisplayName("Regulatory Reporting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegulatoryReporting1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the supervisory party to which the trade needs to be reported.
    /// </summary>
    [IsoId("_koKpMCi-EeKnA5P_jl2DUw")]
    [DisplayName("Reporting Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgJursdctn")]
    #endif
    [IsoXmlTag("RptgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReportingJurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportingJurisdiction { get; init; } 
    #else
    public System.String? ReportingJurisdiction { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for reporting the trade to the trade repository.
    /// </summary>
    [IsoId("_pU-WkCi-EeKnA5P_jl2DUw")]
    [DisplayName("Reporting Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPty")]
    #endif
    [IsoXmlTag("RptgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? ReportingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? ReportingParty { get; init; } 
    #else
    public PartyIdentification73Choice_? ReportingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI).This is the UTI from the Trading Side party.
    /// </summary>
    [IsoId("_Nqo4moKGEeKmtdhZXgREOQ")]
    [DisplayName("Trading Side Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdUnqTxIdr")]
    #endif
    [IsoXmlTag("TradgSdUnqTxIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier1? TradingSideUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier1? TradingSideUniqueTransactionIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier1? TradingSideUniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI).This is the UTI from the Counterparty Side party.
    /// </summary>
    [IsoId("_o3u8CoKGEeKmtdhZXgREOQ")]
    [DisplayName("Counterparty Side Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdUnqTxIdr")]
    #endif
    [IsoXmlTag("CtrPtySdUnqTxIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier1? CounterpartySideUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier1? CounterpartySideUniqueTransactionIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier1? CounterpartySideUniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is exempt from a clearing obligation.
    /// </summary>
    [IsoId("_Bd_McC46EeK7-OZOLIksSw")]
    [DisplayName("Clearing Exception Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrXcptnPty")]
    #endif
    [IsoXmlTag("ClrXcptnPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification73Choice_? ClearingExceptionParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification73Choice_? ClearingExceptionParty { get; init; } 
    #else
    public PartyIdentification73Choice_? ClearingExceptionParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference number assigned by the clearing broker. A distinction can be made between the reference for the Central Counterparty (CCP) leg and the reference for the client leg of the transaction.
    /// </summary>
    [IsoId("_v1MUUC46EeK7-OZOLIksSw")]
    [DisplayName("Clearing Broker Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrBrkrId")]
    #endif
    [IsoXmlTag("ClrBrkrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; init; } 
    #else
    public ClearingBrokerIdentification1? ClearingBrokerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the contract is above or below the clearing threshold. Where No indicates the contract is below the clearing threshold and Yes indicates the contract is above the clearing threshold.
    /// </summary>
    [IsoId("_01RIsC5KEeK7-OZOLIksSw")]
    [DisplayName("Clearing Threshold Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrThrshldInd")]
    #endif
    [IsoXmlTag("ClrThrshldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ClearingThresholdIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearingThresholdIndicator { get; init; } 
    #else
    public System.String? ClearingThresholdIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reference number assigned by the Central Counterparty (CCP).
    /// </summary>
    [IsoId("_iYdM8C47EeK7-OZOLIksSw")]
    [DisplayName("Cleared Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrdPdctId")]
    #endif
    [IsoXmlTag("ClrdPdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClearedProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearedProductIdentification { get; init; } 
    #else
    public System.String? ClearedProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_NFyc0CjmEeK1Sbo8NpBROA")]
    [DisplayName("Underlying Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygPdctIdr")]
    #endif
    [IsoXmlTag("UndrlygPdctIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; init; } 
    #else
    public UnderlyingProductIdentifier1Code? UnderlyingProductIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    [IsoId("_OevXUCjnEeK1Sbo8NpBROA")]
    [DisplayName("Allocation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllcnInd")]
    #endif
    [IsoXmlTag("AllcnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AllocationIndicator1Code? AllocationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AllocationIndicator1Code? AllocationIndicator { get; init; } 
    #else
    public AllocationIndicator1Code? AllocationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the transaction is collateralised.
    /// </summary>
    [IsoId("_6c0vcC48EeK7-OZOLIksSw")]
    [DisplayName("Collateralisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollstnInd")]
    #endif
    [IsoXmlTag("CollstnInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; init; } 
    #else
    public CollateralisationIndicator1Code? CollateralisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the trading venue of the transaction.
    /// </summary>
    [IsoId("_luDhICjoEeK1Sbo8NpBROA")]
    [DisplayName("Execution Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnVn")]
    #endif
    [IsoXmlTag("ExctnVn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ExecutionVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExecutionVenue { get; init; } 
    #else
    public System.String? ExecutionVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time of the execution of the transaction in Coordinated Universal Time (UTC).
    /// </summary>
    [IsoId("_tj7RMCjoEeK1Sbo8NpBROA")]
    [DisplayName("Execution Timestamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnTmstmp")]
    #endif
    [IsoXmlTag("ExctnTmstmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExecutionTimestamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the reportable transaction has one or more additional terms or provisions, other than those listed in the required real-time data fields, that materially affects the price of the reportable transaction.
    /// </summary>
    [IsoId("_MnF0kC5KEeK7-OZOLIksSw")]
    [DisplayName("Non Standard Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonStdFlg")]
    #endif
    [IsoXmlTag("NonStdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NonStandardFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonStandardFlag { get; init; } 
    #else
    public System.String? NonStandardFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the common reference or correlation identification for a swap transaction where the near and far leg are confirmed separately.
    /// </summary>
    [IsoId("_U_yssCjrEeK1Sbo8NpBROA")]
    [DisplayName("Link Swap Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkSwpId")]
    #endif
    [IsoXmlTag("LkSwpId")]
    [IsoSimpleType(IsoSimpleType.Exact42Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact42Text? LinkSwapIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LinkSwapIdentification { get; init; } 
    #else
    public System.String? LinkSwapIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies additional information that might be required by the regulator.
    /// </summary>
    [IsoId("_ZGe_0CjsEeK1Sbo8NpBROA")]
    [DisplayName("Additional Reporting Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRptgInf")]
    #endif
    [IsoXmlTag("AddtlRptgInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalReportingInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReportingInformation { get; init; } 
    #else
    public System.String? AdditionalReportingInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
