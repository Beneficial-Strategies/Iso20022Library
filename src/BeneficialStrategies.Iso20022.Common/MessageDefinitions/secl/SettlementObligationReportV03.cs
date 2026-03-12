// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.010.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SettlementObligationReport message is sent by the central counterparty (CCP) to a clearing member to report on the settlement obligation that will be submitted for settlement.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The SettlementObligationReport message may also be sent to a third party processing the settlement obligation(s) on behalf of more than one clearing member.
/// The Settlement Obligation Report message is provided per delivery account and per instrument. The report can be provided for one specific delivering party or one specific receiving party. It can also be generated per non clearing member.
/// </summary>
[Description(@"Scope|The SettlementObligationReport message is sent by the central counterparty (CCP) to a clearing member to report on the settlement obligation that will be submitted for settlement.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The SettlementObligationReport message may also be sent to a third party processing the settlement obligation(s) on behalf of more than one clearing member.|The Settlement Obligation Report message is provided per delivery account and per instrument. The report can be provided for one specific delivering party or one specific receiving party. It can also be generated per non clearing member.")]
[IsoId("_suRVUS9dEeS94oXWDaBauA")]
[DisplayName("Settlement Obligation Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementObligationReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.010.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmOblgtnRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.010.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementObligationReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementObligationReportV03( ReportParameters4 reqReportParameters,Pagination reqPagination,Report5 reqReportDetails )
    {
        ReportParameters = reqReportParameters;
        Pagination = reqPagination;
        ReportDetails = reqReportDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the report such as the report identification, the creation date and time.
    /// </summary>
    [IsoId("_suRVUy9dEeS94oXWDaBauA")]
    [DisplayName("Report Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptParams")]
    #endif
    [IsoXmlTag("RptParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportParameters4 ReportParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportParameters4 ReportParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportParameters4 ReportParameters { get; init; } 
    #else
    public ReportParameters4 ReportParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within a report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_suRVVS9dEeS94oXWDaBauA")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination Pagination { get; init; } 
    #else
    public Pagination Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification of the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_suRVVy9dEeS94oXWDaBauA")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification35Choice_? ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_? ClearingMember { get; init; } 
    #else
    public PartyIdentification35Choice_? ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_suRVWS9dEeS94oXWDaBauA")]
    [DisplayName("Clearing Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSgmt")]
    #endif
    [IsoXmlTag("ClrSgmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_? ClearingSegment { get; init; } 
    #else
    public PartyIdentification35Choice_? ClearingSegment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification of the account used for netting. This is an account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_suRVWy9dEeS94oXWDaBauA")]
    [DisplayName("Delivery Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryAcct")]
    #endif
    [IsoXmlTag("DlvryAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    #else
    public SecuritiesAccount19? DeliveryAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the settlement obligation report.
    /// </summary>
    [IsoId("_suRVXS9dEeS94oXWDaBauA")]
    [DisplayName("Report Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptDtls")]
    #endif
    [IsoXmlTag("RptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Report5 ReportDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Report5 ReportDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Report5 ReportDetails { get; init; } 
    #else
    public Report5 ReportDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the receiving parties involved in the settlement chain.
    /// </summary>
    [IsoId("_suRVXy9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPties")]
    #endif
    [IsoXmlTag("SttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties2Choice_? SettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties2Choice_? SettlementParties { get; init; } 
    #else
    public SettlementParties2Choice_? SettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_suRVYS9dEeS94oXWDaBauA")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SettlementObligationReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SettlementObligationReportV03.

