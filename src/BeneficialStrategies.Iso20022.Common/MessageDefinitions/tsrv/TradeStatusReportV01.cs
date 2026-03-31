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

namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The TradeStatusReport message is exchanged between parties involved in the trade finance domain to report the transaction level status of a transaction previously received. It informs the sender about the positive or negative status of the referenced transaction, such as acceptance or rejection resulting from technical validation performed by the parser and/or front-office applications. It can be used, for example, to acknowledge receipt of a transaction, to report a syntactical error, to report an unrecognised digital signature, to indicate that further processing is pending, and to indicate that a transaction has been technically accepted for processing by the back-office application. Multiple TradeStatusReport messages may be progressively sent in response to the incremental processing of a single transaction.
/// </summary>
[Description(
    @"The TradeStatusReport message is exchanged between parties involved in the trade finance domain to report the transaction level status of a transaction previously received. It informs the sender about the positive or negative status of the referenced transaction, such as acceptance or rejection resulting from technical validation performed by the parser and/or front-office applications. It can be used, for example, to acknowledge receipt of a transaction, to report a syntactical error, to report an unrecognised digital signature, to indicate that further processing is pending, and to indicate that a transaction has been technically accepted for processing by the back-office application. Multiple TradeStatusReport messages may be progressively sent in response to the incremental processing of a single transaction."
)]
[IsoId("_9hy8JXltEeG7BsjMvd1mEw_-944920037")]
[DisplayName("Trade Status Report V")]
public record TradeStatusReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.018.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.018.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Details of the trade status report.
    /// </summary>
    [IsoId("_9hy8JnltEeG7BsjMvd1mEw_-979867813")]
    [DisplayName("Trade Status Advice Details")]
    [IsoXmlTag("TradStsAdvcDtls")]
    public required TradeStatusReport1 TradeStatusAdviceDetails { get; init; }

    /// <summary>
    /// Digital signature of the report.
    /// </summary>
    [IsoId("_9hy8J3ltEeG7BsjMvd1mEw_-480119583")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
}

// Since TradeStatusReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TradeStatusReportV01.
