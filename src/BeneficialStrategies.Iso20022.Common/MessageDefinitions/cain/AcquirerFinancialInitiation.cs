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
/// This record is an implementation of the cain.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcquirerFinancialInitiation message is sent by an acquirer or an agent to an issuer or an agent, to request, advice or notify the approval and the clearing of a card transaction.
/// </summary>
[Description(
    @"The AcquirerFinancialInitiation message is sent by an acquirer or an agent to an issuer or an agent, to request, advice or notify the approval and the clearing of a card transaction."
)]
[IsoId("_Mdr84HubEeSBS-QFUaKA-g")]
[DisplayName("Acquirer Financial Initiation")]
public record AcquirerFinancialInitiation : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.003.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcqrrFinInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.003.001.01";

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
    [IsoId("_kgOI0HubEeSBS-QFUaKA-g")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header17 Header { get; init; }

    /// <summary>
    /// Information related to financial authorisation.
    /// </summary>
    [IsoId("_uR7TcHubEeSBS-QFUaKA-g")]
    [DisplayName("Financial Initiation")]
    [IsoXmlTag("FinInitn")]
    public required AcquirerFinancialInitiation1 FinancialInitiation { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_Fxvz4HucEeSBS-QFUaKA-g")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType15 SecurityTrailer { get; init; }
}

// Since AcquirerFinancialInitiationDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcquirerFinancialInitiation.
