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
/// This record is an implementation of the cain.018.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The VerificationInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). It conveys information to a receiver requiring verification or authentication. |
/// |
/// Examples of usages are: authentication of certificates, assurance levels of tokens, certificate management, address verification, account verification and cheque verification. It is also used to inform the receiver of a verification that has been completed on its behalf.
/// </summary>
[Description(
    @"The VerificationInitiation message can be initiated by any party and received by any party (acquirer, agent or issuer). It conveys information to a receiver requiring verification or authentication. ||||Examples of usages are: authentication of certificates, assurance levels of tokens, certificate management, address verification, account verification and cheque verification. It is also used to inform the receiver of a verification that has been completed on its behalf."
)]
[IsoId("_3L3tMYELEeu6D49Gi-ZPwQ")]
[DisplayName("Verification Initiation V")]
public record VerificationInitiationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.018.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "VrfctnInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.018.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_3L3tM4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header60 Header { get; init; }

    /// <summary>
    /// Information related to the verification initiation.
    /// </summary>
    [IsoId("_3L3tNYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required VerificationInitiation2 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_3L3tN4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since VerificationInitiationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to VerificationInitiationV02.
