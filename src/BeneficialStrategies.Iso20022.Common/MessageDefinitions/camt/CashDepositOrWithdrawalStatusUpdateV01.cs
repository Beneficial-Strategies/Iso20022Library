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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.115.001.01 ISO standard message type.
/// The CashDepositOrWithdrawalStatusUpdate message reports the status of a cash deposit request or cash withdrawal request.
/// </summary>
/// <remarks>
/// Where reporting on the status of a cash deposit request, it is sent by a cash receiver to a cash sender.
/// Where reporting on the status of a cash withdrawal request, it is sent by a cash sender to a cash receiver.
/// </remarks>
[Description(
    @"The CashDepositOrWithdrawalStatusUpdate message reports the status of a cash deposit request or cash withdrawal request.|Where reporting on the status of a cash deposit request, it is sent by a cash receiver to a cash sender.|Where reporting on the status of a cash withdrawal request, it is sent by a cash sender to a cash receiver."
)]
[IsoId("_hb3y8FGkEfC_v5ez7RpMHw")]
[DisplayName("Cash Deposit Or Withdrawal Status Update V01")]
public record CashDepositOrWithdrawalStatusUpdateV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.115.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CshDpstOrWdrwlStsUpd";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.115.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics shared by all individual notifications included in the message.
    /// </summary>
    [IsoId("_kDRoIFGmEfC_v5ez7RpMHw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader134 GroupHeader { get; init; }

    /// <summary>
    /// Information concerning the original request, to which the status report message refers.
    /// </summary>
    [IsoId("_pJHOoFGoEfC_v5ez7RpMHw")]
    [DisplayName("Request Information And Status")]
    [IsoXmlTag("ReqInfAndSts")]
    [MinLength(1)]
    public ValueList<RequestIdentificationAndStatus1> RequestInformationAndStatus { get; init; } = [];

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_cq-9catiEfC6tbn8zOl_iw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
