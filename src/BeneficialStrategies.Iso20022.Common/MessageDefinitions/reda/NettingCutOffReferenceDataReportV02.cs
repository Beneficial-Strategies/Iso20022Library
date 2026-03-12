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



namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.061.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Netting Cut Off Reference Data Report message is sent to a participant by a central system to provide details of scheduled, changed, existing and previous netting cut off data held at a central system.
/// </summary>
[Description(@"The Netting Cut Off Reference Data Report message is sent to a participant by a central system to provide details of scheduled, changed, existing and previous netting cut off data held at a central system.")]
[IsoId("_kBNoCQM-Ee2nqoJcXIhTdw")]
[DisplayName("Netting Cut Off Reference Data Report V")]
public partial record NettingCutOffReferenceDataReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.061.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetgCutOffRefDataRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.061.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Specifies the meta data for the netting cut off report including message pagination.
    /// </summary>
    [IsoId("_kBNoCwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Report Data")]
    [IsoXmlTag("RptData")]
    public required NettingCutOffReportData2 ReportData { get; init; } 
    
    /// <summary>
    /// Provides the latest information related to the status of a netting cut off held at a central system.
    /// </summary>
    [IsoId("_kBNoDQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Participant Netting Cut Off Data")]
    [IsoXmlTag("PtcptNetgCutOffData")]
    public required CutOffData2 ParticipantNettingCutOffData { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kBNoDwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since NettingCutOffReferenceDataReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NettingCutOffReferenceDataReportV02.

