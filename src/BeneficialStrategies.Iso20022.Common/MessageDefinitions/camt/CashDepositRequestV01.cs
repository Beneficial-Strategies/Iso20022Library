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
/// This record is an implementation of the camt.113.001.01 ISO standard message type.
/// The CashDepositRequest message is sent by a cash sender to a cash receiver to request that cash can be delivered for deposit into an account.
/// </summary>
[Description(
    @"The CashDepositRequest message is sent by a cash sender to a cash receiver to request that cash can be delivered for deposit into an account."
)]
[IsoId("_NKdVwLe1Ee-Dk_aQVAan8Q")]
[DisplayName("Cash Deposit Request V01")]
public record CashDepositRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.113.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CshDpstReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.113.001.01";

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
    [IsoId("_J6e18re5Ee-Dk_aQVAan8Q")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader132 GroupHeader { get; init; }

    /// <summary>
    /// Specifies the details of a cash deposit request.
    /// </summary>
    [IsoId("_P6yykre5Ee-Dk_aQVAan8Q")]
    [DisplayName("Cash Deposit Request")]
    [IsoXmlTag("CshDpstReq")]
    [MinLength(1)]
    public ValueList<CashDepositRequest1> CashDepositRequest { get; init; } = [];

    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_YuRj4eR7Ee-NFYIkYc90gw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
