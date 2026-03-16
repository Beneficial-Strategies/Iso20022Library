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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesAccountStatusAdvice message is send by the the executing party to an instructing party to provide the status of the execution of an creation, modification or deletion of securities account reference data.
///
/// Usage:
/// When processing information is negative – a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed.
/// When the processing is succesfully performed, the message includes the related securities account identification.
/// </summary>
[Description(
    @"The SecuritiesAccountStatusAdvice message is send by the the executing party to an instructing party to provide the status of the execution of an creation, modification or deletion of securities account reference data.||Usage: |When processing information is negative – a failure occurred in applying the changes the message accordingly also delivers information about the reason why the creation or update could not be processed. |When the processing is succesfully performed, the message includes the related securities account identification."
)]
[IsoId("_KAu-652fEem_Be8NuxvF7Q")]
[DisplayName("Securities Account Status Advice V")]
public record SecuritiesAccountStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.020.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.020.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_EqxEkJ5REemQg7pJhFUUYg")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader12? MessageHeader { get; init; }

    /// <summary>
    /// Status of the securities account involved in the originating message.
    /// </summary>
    [IsoId("_KAu--52fEem_Be8NuxvF7Q")]
    [DisplayName("Securities Account Status")]
    [IsoXmlTag("SctiesAcctSts")]
    public required SecuritiesAccountStatus2 SecuritiesAccountStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-_Z2fEem_Be8NuxvF7Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesAccountStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesAccountStatusAdviceV01.
