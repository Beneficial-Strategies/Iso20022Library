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

namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// This record is an implementation of the catp.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMReject message is sent by any entity to reject a received message.
/// </summary>
[Description(@"The ATMReject message is sent by any entity to reject a received message.")]
[IsoId("_DvwXcIrFEeSRwL6n4K9igA")]
[DisplayName("ATM Reject V")]
public record ATMRejectV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.005.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMRjct";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.005.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_fyheoIrFEeSRwL6n4K9igA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header22 Header { get; init; }

    /// <summary>
    /// Information related to the reject of a message from an ATM or an ATM manager.
    /// </summary>
    [IsoId("_3TnxcIrFEeSRwL6n4K9igA")]
    [DisplayName("ATM Reject")]
    [IsoXmlTag("ATMRjct")]
    public required ATMReject1 ATMReject { get; init; }
}

// Since ATMRejectV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMRejectV01.
