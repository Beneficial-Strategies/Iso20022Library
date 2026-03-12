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
/// This record is an implementation of the reda.060.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The Netting Cut Off Reference Data Update Request message is sent to a central system by a participant to request an update to a participant&apos;s netting cut off held at the central system.
/// </summary>
[Description(@"The Netting Cut Off Reference Data Update Request message is sent to a central system by a participant to request an update to a participant's netting cut off held at the central system.")]
[IsoId("_mJe8bQM-Ee2nqoJcXIhTdw")]
[DisplayName("Netting Cut Off Reference Data Update Request V")]
public partial record NettingCutOffReferenceDataUpdateRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.060.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetgCutOffRefDataUpdReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.060.001.02";
    
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
    /// Specifies the meta data for the netting cut off update request.
    /// </summary>
    [IsoId("_mJe8bwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Request Data")]
    [IsoXmlTag("ReqData")]
    public required RequestData2 RequestData { get; init; } 
    
    /// <summary>
    /// Specifies the information regarding the changes to the netting cut off.
    /// </summary>
    [IsoId("_mJe8cQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Netting Cut Off Request")]
    [IsoXmlTag("NetgCutOffReq")]
    public required NettingCutOff2 NettingCutOffRequest { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mJe8cwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since NettingCutOffReferenceDataUpdateRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NettingCutOffReferenceDataUpdateRequestV02.

