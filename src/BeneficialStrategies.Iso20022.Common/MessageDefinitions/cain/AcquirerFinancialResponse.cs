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

namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcquirerFinancialResponse message is sent by an issuer or an agent to answer to an AcquirerFinancialInitiation message.
/// </summary>
[Description(
    @"The AcquirerFinancialResponse message is sent by an issuer or an agent to answer to an AcquirerFinancialInitiation message."
)]
[IsoId("_K53kQHucEeSBS-QFUaKA-g")]
[DisplayName("Acquirer Financial Response")]
public record AcquirerFinancialResponse : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.004.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcqrrFinRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.004.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_V0OZAHucEeSBS-QFUaKA-g")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header17 Header { get; init; }

    /// <summary>
    /// Information related to the response of a financial authorisation.
    /// </summary>
    [IsoId("_oMbT0HumEeSBS-QFUaKA-g")]
    [DisplayName("Financial Response")]
    [IsoXmlTag("FinRspn")]
    public required AcquirerFinancialResponse1 FinancialResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_7ieigHumEeSBS-QFUaKA-g")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since AcquirerFinancialResponseDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcquirerFinancialResponse.
