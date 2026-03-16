// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.head;

/// <summary>
/// This record is an implementation of the head.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R2558TEZEe6kQ-WGAhcVPQ")]
[DisplayName("Business Application Header V04")]
public record BusinessApplicationHeaderV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "head.001.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AppHdr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Business Message Identifier.
    /// </summary>
    [DisplayName("Business Message Identifier")]
    [IsoXmlTag("BizMsgIdr")]
    public required IsoMax35Text BusinessMessageIdentifier { get; init; }

    /// <summary>
    /// Business Processing Date.
    /// </summary>
    [DisplayName("Business Processing Date")]
    [IsoXmlTag("BizPrcgDt")]
    public IsoISODateTime? BusinessProcessingDate { get; init; }

    /// <summary>
    /// Business Service.
    /// </summary>
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    public IsoMax35Text? BusinessService { get; init; }

    /// <summary>
    /// Character Set.
    /// </summary>
    [DisplayName("Character Set")]
    [IsoXmlTag("CharSet")]
    public UnicodeChartsCode? CharacterSet { get; init; }

    /// <summary>
    /// Copy Duplicate.
    /// </summary>
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; }

    /// <summary>
    /// Creation Date.
    /// </summary>
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    public required IsoISODateTime CreationDate { get; init; }

    /// <summary>
    /// From.
    /// </summary>
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party51Choice_ From { get; init; }

    /// <summary>
    /// Market Practice.
    /// </summary>
    [DisplayName("Market Practice")]
    [IsoXmlTag("MktPrctc")]
    public ImplementationSpecification1? MarketPractice { get; init; }

    /// <summary>
    /// Message Definition Identifier.
    /// </summary>
    [DisplayName("Message Definition Identifier")]
    [IsoXmlTag("MsgDefIdr")]
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; }

    /// <summary>
    /// Possible Duplicate.
    /// </summary>
    [DisplayName("Possible Duplicate")]
    [IsoXmlTag("PssblDplct")]
    public IsoYesNoIndicator? PossibleDuplicate { get; init; }

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public BusinessMessagePriorityCode? Priority { get; init; }

    /// <summary>
    /// Related.
    /// </summary>
    [DisplayName("Related")]
    [IsoXmlTag("Rltd")]
    public ValueList<BusinessApplicationHeader8> Related { get; init; } = [];

    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SignatureEnvelope? Signature { get; init; }

    /// <summary>
    /// To.
    /// </summary>
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party51Choice_ To { get; init; }
}

// Since BusinessApplicationHeaderV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BusinessApplicationHeaderV04.
