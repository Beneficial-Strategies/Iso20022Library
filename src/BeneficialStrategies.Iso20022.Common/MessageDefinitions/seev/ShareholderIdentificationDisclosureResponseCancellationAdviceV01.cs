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
/// This record is an implementation of the seev.048.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ShareholdersIdentificationDisclosureResponseCancellationAdvice message is sent by any intermediaries to the recipient designated by the issuer (such as an issuer&apos;s agent) in the disclosure request message in order to cancel the shareholder identification disclosure response whether previously sent in a single message or in a set of multipart/paginated response messages.
/// </summary>
[Description(@"The ShareholdersIdentificationDisclosureResponseCancellationAdvice message is sent by any intermediaries to the recipient designated by the issuer (such as an issuer's agent) in the disclosure request message in order to cancel the shareholder identification disclosure response whether previously sent in a single message or in a set of multipart/paginated response messages.")]
[IsoId("_mi0doEV8EemRx7jyevcLwg")]
[DisplayName("Shareholder Identification Disclosure Response Cancellation Advice V")]
public partial record ShareholderIdentificationDisclosureResponseCancellationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.048.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ShrhldrIdDsclsrRspnCxlAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.048.001.01";
    
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
    /// Unique identification of the disclosure response for which a cancellation advice is sent.
    /// The same disclosure response identification number is to be used when cancelling a response which is split in multiple messages.
    /// </summary>
    [IsoId("_1ZW-okV9EemRx7jyevcLwg")]
    [DisplayName("Disclosure Response Identification")]
    [IsoXmlTag("DsclsrRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text DisclosureResponseIdentification { get; init; } 
    
    /// <summary>
    /// Official and unique identification assigned to a shareholders identification disclosure request process by the issuer or third party nominated by it and for which a response is sent.
    /// </summary>
    [IsoId("_s9Y_YbRAEem2T48lBgJbww")]
    [DisplayName("Issuer Disclosure Request Reference")]
    [IsoXmlTag("IssrDsclsrReqRef")]
    public required DisclosureRequestIdentification1 IssuerDisclosureRequestReference { get; init; } 
    
    /// <summary>
    /// Unique identification of the intermediary party responding to the shareholders identification disclosure request.
    /// </summary>
    [IsoId("_1ZW-o0V9EemRx7jyevcLwg")]
    [DisplayName("Responding Intermediary")]
    [IsoXmlTag("RspndgIntrmy")]
    public required PartyIdentification215 RespondingIntermediary { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1__BQbRAEem2T48lBgJbww")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ShareholderIdentificationDisclosureResponseCancellationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ShareholderIdentificationDisclosureResponseCancellationAdviceV01.

