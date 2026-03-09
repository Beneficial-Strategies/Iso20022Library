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
/// Provides details on transaction and conducting counterparty.
/// </summary>
[IsoId("_xzGNwVyGEe24CqbZJK5XxA")]
[DisplayName("Trade Transaction Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransactionIdentification24
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_x0MZ8VyGEe24CqbZJK5XxA")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_x0MZ81yGEe24CqbZJK5XxA")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionOperationType10Code? ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOperationType10Code? ActionType { get; init; } 
    #else
    public TransactionOperationType10Code? ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the submission of the report to the trade repository.
    /// </summary>
    [IsoId("_x0MZ9VyGEe24CqbZJK5XxA")]
    [DisplayName("Reporting Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgTmStmp")]
    #endif
    [IsoXmlTag("RptgTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ReportingTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ReportingTimeStamp { get; init; } 
    #else
    public System.DateTime? ReportingTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of derivative event type.
    /// </summary>
    [IsoId("_x0MZ91yGEe24CqbZJK5XxA")]
    [DisplayName("Derivative Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivEvtTp")]
    #endif
    [IsoXmlTag("DerivEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeEventType3Code? DerivativeEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeEventType3Code? DerivativeEventType { get; init; } 
    #else
    public DerivativeEventType3Code? DerivativeEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the time stamp of a derivative event.
    /// </summary>
    [IsoId("_x0MZ-VyGEe24CqbZJK5XxA")]
    [DisplayName("Derivative Event Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivEvtTmStmp")]
    #endif
    [IsoXmlTag("DerivEvtTmStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? DerivativeEventTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? DerivativeEventTimeStamp { get; init; } 
    #else
    public DateAndDateTime2Choice_? DerivativeEventTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    [IsoId("_x0MZ-1yGEe24CqbZJK5XxA")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification248Choice_? OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification248Choice_? OtherCounterparty { get; init; } 
    #else
    public PartyIdentification248Choice_? OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty.
    /// </summary>
    [IsoId("_x0MZ_VyGEe24CqbZJK5XxA")]
    [DisplayName("Unique Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqIdr")]
    #endif
    [IsoXmlTag("UnqIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier2Choice_? UniqueIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier2Choice_? UniqueIdentifier { get; init; } 
    #else
    public UniqueTransactionIdentifier2Choice_? UniqueIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_x0MZ_1yGEe24CqbZJK5XxA")]
    [DisplayName("Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmt")]
    #endif
    [IsoXmlTag("MstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement8? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement8? MasterAgreement { get; init; } 
    #else
    public MasterAgreement8? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Unique codes identifying the portfolio.
    /// </summary>
    [IsoId("_x0MaAVyGEe24CqbZJK5XxA")]
    [DisplayName("Collateral Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflCd")]
    #endif
    [IsoXmlTag("CollPrtflCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; init; } 
    #else
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
