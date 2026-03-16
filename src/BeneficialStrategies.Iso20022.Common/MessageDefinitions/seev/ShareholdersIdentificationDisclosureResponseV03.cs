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



namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.047.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_fWSaAVx4Ee6fgZt44_IqFA")]
[DisplayName("Shareholders Identification Disclosure Response V03")]
public partial record ShareholdersIdentificationDisclosureResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.047.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrsIdDsclsrRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.047.001.03";
    
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
    /// Disclosure Information.
    /// </summary>
    [DisplayName("Disclosure Information")]
    [IsoXmlTag("DsclsrInf")]
    public required Disclosure3Choice_ DisclosureInformation { get; init; } 
    
    /// <summary>
    /// Disclosure Response Identification.
    /// </summary>
    [DisplayName("Disclosure Response Identification")]
    [IsoXmlTag("DsclsrRspnId")]
    public required IsoMax35Text DisclosureResponseIdentification { get; init; } 
    
    /// <summary>
    /// Issuer Disclosure Request Reference.
    /// </summary>
    [DisplayName("Issuer Disclosure Request Reference")]
    [IsoXmlTag("IssrDsclsrReqRef")]
    public required DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; } 
    
    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; } 
    
    /// <summary>
    /// Responding Intermediary.
    /// </summary>
    [DisplayName("Responding Intermediary")]
    [IsoXmlTag("RspndgIntrmy")]
    public required PartyIdentification219 RespondingIntermediary { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    
    #nullable disable
    
}


// Since ShareholdersIdentificationDisclosureResponseV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholdersIdentificationDisclosureResponseV03.

