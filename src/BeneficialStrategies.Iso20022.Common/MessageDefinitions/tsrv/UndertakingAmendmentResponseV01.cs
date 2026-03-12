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



namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingAmendmentResponse message is sent by the beneficiary to the party that issued the undertaking, either directly or via one or more advising parties, to indicate acceptance or rejection by the beneficiary of the amendment.
/// </summary>
[Description(@"The UndertakingAmendmentResponse message is sent by the beneficiary to the party that issued the undertaking, either directly or via one or more advising parties, to indicate acceptance or rejection by the beneficiary of the amendment.")]
[IsoId("_9iGeInltEeG7BsjMvd1mEw_-1174691593")]
[DisplayName("Undertaking Amendment Response V")]
public partial record UndertakingAmendmentResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.008.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgAmdmntRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.008.001.01";
    
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
    /// Details related to the proposed amendment response.
    /// </summary>
    [IsoId("_9iGeI3ltEeG7BsjMvd1mEw_1688211765")]
    [DisplayName("Undertaking Amendment Response Details")]
    [IsoXmlTag("UdrtkgAmdmntRspnDtls")]
    public required Amendment7 UndertakingAmendmentResponseDetails { get; init; } 
    
    /// <summary>
    /// Digital signature of the response.
    /// </summary>
    [IsoId("_9iGeJHltEeG7BsjMvd1mEw_-106555432")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingAmendmentResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingAmendmentResponseV01.

