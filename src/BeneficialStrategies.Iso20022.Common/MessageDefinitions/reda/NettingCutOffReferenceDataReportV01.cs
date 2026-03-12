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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.061.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Netting Cut Off Reference Data Report message is sent to a participant by a central system to provide details of scheduled, changed, existing and previous netting cut off data held at a central system.
/// </summary>
[Description(@"The Netting Cut Off Reference Data Report message is sent to a participant by a central system to provide details of scheduled, changed, existing and previous netting cut off data held at a central system.")]
[IsoId("_v7yFIJXTEeaYkf5FCqYMeA")]
[DisplayName("Netting Cut Off Reference Data Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NettingCutOffReferenceDataReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.061.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetgCutOffRefDataRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.061.001.01";
    
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
    /// Constructs a NettingCutOffReferenceDataReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NettingCutOffReferenceDataReportV01( NettingCutOffReportData1 reqReportData,CutOffData1 reqParticipantNettingCutOffData )
    {
        ReportData = reqReportData;
        ParticipantNettingCutOffData = reqParticipantNettingCutOffData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the meta data for the netting cut off report including message pagination.
    /// </summary>
    [IsoId("_Eogg8JXWEeaYkf5FCqYMeA")]
    [DisplayName("Report Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptData")]
    #endif
    [IsoXmlTag("RptData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingCutOffReportData1 ReportData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NettingCutOffReportData1 ReportData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingCutOffReportData1 ReportData { get; init; } 
    #else
    public NettingCutOffReportData1 ReportData { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the latest information related to the status of a netting cut off held at a central system.
    /// </summary>
    [IsoId("_pQMvMJXZEeaYkf5FCqYMeA")]
    [DisplayName("Participant Netting Cut Off Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptNetgCutOffData")]
    #endif
    [IsoXmlTag("PtcptNetgCutOffData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CutOffData1 ParticipantNettingCutOffData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CutOffData1 ParticipantNettingCutOffData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CutOffData1 ParticipantNettingCutOffData { get; init; } 
    #else
    public CutOffData1 ParticipantNettingCutOffData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_g5ZZMZnzEeahw7LV9elg3w")]
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


// Since NettingCutOffReferenceDataReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NettingCutOffReferenceDataReportV01.

