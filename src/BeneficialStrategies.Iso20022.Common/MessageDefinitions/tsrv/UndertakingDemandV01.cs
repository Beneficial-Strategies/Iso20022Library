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
/// This record is an implementation of the tsrv.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingDemand message and other required documents are sent by the beneficiary to the party that issued the undertaking, either directly or via a presenting or nominated party. It is a demand for payment and may include a request to extend the undertaking expiry date. The demand itself must be contained in an enclosed file within the message or must be specified as narrative text within the message. It may contain other required documents in addition to the demand.
/// </summary>
[Description(@"The UndertakingDemand message and other required documents are sent by the beneficiary to the party that issued the undertaking, either directly or via a presenting or nominated party. It is a demand for payment and may include a request to extend the undertaking expiry date. The demand itself must be contained in an enclosed file within the message or must be specified as narrative text within the message. It may contain other required documents in addition to the demand.")]
[IsoId("_9hDVQnltEeG7BsjMvd1mEw_2036606327")]
[DisplayName("Undertaking Demand V")]
public partial record UndertakingDemandV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.013.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgDmnd";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.013.001.01";
    
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
    /// Details of the demand.
    /// </summary>
    [IsoId("_9hDVQ3ltEeG7BsjMvd1mEw_-612873100")]
    [DisplayName("Undertaking Demand Details")]
    [IsoXmlTag("UdrtkgDmndDtls")]
    public required Demand1 UndertakingDemandDetails { get; init; } 
    
    /// <summary>
    /// Additional information specific to the bank-to-bank communication.
    /// </summary>
    [IsoId("_AIs9UBVIEeKVqNjC36CBuQ")]
    [DisplayName("Bank To Bank Information")]
    [IsoXmlTag("BkToBkInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public SimpleValueList<System.String> BankToBankInformation { get; init; } = [];
    
    /// <summary>
    /// Digital signature of the demand.
    /// </summary>
    [IsoId("_9hDVRHltEeG7BsjMvd1mEw_-415271236")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; } 
    
    
    #nullable disable
    
}


// Since UndertakingDemandV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingDemandV01.

