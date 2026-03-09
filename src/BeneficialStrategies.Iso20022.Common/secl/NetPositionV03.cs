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
/// This record is an implementation of the secl.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Net Position Report message is sent by the central counterparty (CCP) to a clearing member to confirm the net position of all trade legs reported during the day.
/// 
/// The message definition is intended for use with the ISO 20022 Business Application Header.
/// 
/// Usage
/// The central counterparty (CCP) nets all the positions per clearing account and sends the Net Position report message to the Clearing member.
/// </summary>
[Description(@"Scope|The Net Position Report message is sent by the central counterparty (CCP) to a clearing member to confirm the net position of all trade legs reported during the day.||The message definition is intended for use with the ISO 20022 Business Application Header.||Usage|The central counterparty (CCP) nets all the positions per clearing account and sends the Net Position report message to the Clearing member.")]
[IsoId("_9C7fsS0lEeSRe9rElPHBfg")]
[DisplayName("Net Position V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetPositionV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.004.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetPos";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.004.001.03";
    
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
    /// Constructs a NetPositionV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetPositionV03( ReportParameters1 reqReportParameters,Pagination reqPagination,PartyIdentification35Choice_ reqClearingMember,NetPosition3 reqNetPositionReport )
    {
        ReportParameters = reqReportParameters;
        Pagination = reqPagination;
        ClearingMember = reqClearingMember;
        NetPositionReport = reqNetPositionReport;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides parameters of the margin report such as the creation date and time, the report currency or the calculation date and time.
    /// </summary>
    [IsoId("_9C7fsy0lEeSRe9rElPHBfg")]
    [DisplayName("Report Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptParams")]
    #endif
    [IsoXmlTag("RptParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportParameters1 ReportParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportParameters1 ReportParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportParameters1 ReportParameters { get; init; } 
    #else
    public ReportParameters1 ReportParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the number of used pages.
    /// </summary>
    [IsoId("_9C7ftS0lEeSRe9rElPHBfg")]
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
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_9C7fty0lEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_ ClearingMember { get; init; } 
    #else
    public PartyIdentification35Choice_ ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_9C7fuS0lEeSRe9rElPHBfg")]
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
    /// Provides the net position details such as the average deal price and net quantity.
    /// </summary>
    [IsoId("_9C7fuy0lEeSRe9rElPHBfg")]
    [DisplayName("Net Position Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPosRpt")]
    #endif
    [IsoXmlTag("NetPosRpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NetPosition3 NetPositionReport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NetPosition3 NetPositionReport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetPosition3 NetPositionReport { get; init; } 
    #else
    public NetPosition3 NetPositionReport { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_9C7fvS0lEeSRe9rElPHBfg")]
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


// Since NetPositionV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetPositionV03.

