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



namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_bf9Rn22PEei3KuUgpx7Xcw")]
[DisplayName("Information Request Response V02")]
public partial record InformationRequestResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.002.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InfReqRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.002.001.02";
    
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
    /// Investigation Identification.
    /// </summary>
    [DisplayName("Investigation Identification")]
    [IsoXmlTag("InvstgtnId")]
    public required IsoMax35Text InvestigationIdentification { get; init; } 
    
    /// <summary>
    /// Response Identification.
    /// </summary>
    [DisplayName("Response Identification")]
    [IsoXmlTag("RspnId")]
    public required IsoMax35Text ResponseIdentification { get; init; } 
    
    /// <summary>
    /// Response Status.
    /// </summary>
    [DisplayName("Response Status")]
    [IsoXmlTag("RspnSts")]
    public required StatusResponse1Code ResponseStatus { get; init; } 
    
    /// <summary>
    /// Return Indicator.
    /// </summary>
    [DisplayName("Return Indicator")]
    [IsoXmlTag("RtrInd")]
    public ValueList<ReturnIndicator2> ReturnIndicator { get; init; } = [];
    
    /// <summary>
    /// Search Criteria.
    /// </summary>
    [DisplayName("Search Criteria")]
    [IsoXmlTag("SchCrit")]
    public required SearchCriteria2Choice_ SearchCriteria { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    
    #nullable disable
    
}


// Since InformationRequestResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InformationRequestResponseV02.

