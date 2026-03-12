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



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.088.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.
/// </summary>
[Description(@"The Net Report message is sent to a participant by a central system to provide details of the of the bi-lateral payment obligations, calculated by the central system per currency.")]
[IsoId("_kBNA9QM-Ee2nqoJcXIhTdw")]
[DisplayName("Net Report V")]
public partial record NetReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.088.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.088.001.02";
    
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
    /// Specifies the meta data associated with the net report.
    /// </summary>
    [IsoId("_kBNA-QM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Report Data")]
    [IsoXmlTag("NetRptData")]
    public required NetReportData2 NetReportData { get; init; } 
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_kBNA-wM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Service Participant Identification")]
    [IsoXmlTag("NetSvcPtcptId")]
    public required PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; } 
    
    /// <summary>
    /// Describes the counterparty participant involved in (all of) the obligations of the report.
    /// </summary>
    [IsoId("_kBNA_QM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Service Counterparty Identification")]
    [IsoXmlTag("NetSvcCtrPtyId")]
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Provides the amount, direct parties or netting groups involved in the obligation.
    /// </summary>
    [IsoId("_kBNA_wM-Ee2nqoJcXIhTdw")]
    [DisplayName("Net Obligation")]
    [IsoXmlTag("NetOblgtn")]
    public required NetObligation2 NetObligation { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kBNBAQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since NetReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetReportV02.

