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

namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform.
/// </summary>
[Description(
    @"The ATMDeviceControl message is sent by a maintenance host to an ATM in response to an ATMDeviceReport message. The message contains a sequence of maintenance commands the ATM must perform."
)]
[IsoId("_YMegkItEEeSxlKlAGYErFg")]
[DisplayName("ATM Device Control V")]
public record ATMDeviceControlV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.002.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDvcCtrl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.002.001.01";

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
    [IsoId("_gWLLkItEEeSxlKlAGYErFg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header20 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_niPwsItEEeSxlKlAGYErFg")]
    [DisplayName("Protected ATM Device Control")]
    [IsoXmlTag("PrtctdATMDvcCtrl")]
    public ContentInformationType10? ProtectedATMDeviceControl { get; init; }

    /// <summary>
    /// Information related to the control of an ATM device.
    /// </summary>
    [IsoId("_wvcgEItEEeSxlKlAGYErFg")]
    [DisplayName("ATM Device Control")]
    [IsoXmlTag("ATMDvcCtrl")]
    public ATMDeviceControl1? ATMDeviceControl { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_0rk-cItEEeSxlKlAGYErFg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
}

// Since ATMDeviceControlV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMDeviceControlV01.
