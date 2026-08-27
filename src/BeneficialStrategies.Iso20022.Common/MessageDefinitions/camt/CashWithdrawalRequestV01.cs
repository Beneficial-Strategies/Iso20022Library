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
/// This record is an implementation of the camt.114.001.01 ISO standard message type.
/// The CashWithdrawalRequest message is sent by a cash receiver to a a cash sender to request that cash is withdrawn from an account.
/// </summary>
[Description(
    @"The CashWithdrawalRequest message is sent by a cash receiver to a a cash sender to request that cash is withdrawn from an account."
)]
[IsoId("_24xMkOR7Ee-NFYIkYc90gw")]
[DisplayName("Cash Withdrawal Request V01")]
public record CashWithdrawalRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.114.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CshWdrwlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.114.001.01";

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
    [IsoId("_U5yJIuR8Ee-NFYIkYc90gw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader133 GroupHeader { get; init; }

    /// <summary>
    /// Specifies the details of a cash withdrawal request.
    /// </summary>
    [IsoId("_U5yJI-R8Ee-NFYIkYc90gw")]
    [DisplayName("Cash Withdrawal Request")]
    [IsoXmlTag("CshWdrwlReq")]
    [MinLength(1)]
    public ValueList<CashWithdrawalRequest1> CashWithdrawalRequest { get; init; } = [];

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_U5yJJOR8Ee-NFYIkYc90gw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
