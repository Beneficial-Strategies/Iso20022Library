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

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.029.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_ifmEh0JyEe60WdUTxN_HlQ")]
[DisplayName("Derivatives Trade Report Query V04")]
public record DerivativesTradeReportQueryV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.029.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRptQry";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.029.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Requesting Authority.
    /// </summary>
    [DisplayName("Requesting Authority")]
    [IsoXmlTag("RqstngAuthrty")]
    public required PartyIdentification121Choice_ RequestingAuthority { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Trade Query Data.
    /// </summary>
    [DisplayName("Trade Query Data")]
    [IsoXmlTag("TradQryData")]
    public required TradeReportQuery17Choice_ TradeQueryData { get; init; }
}

// Since DerivativesTradeReportQueryV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DerivativesTradeReportQueryV04.
