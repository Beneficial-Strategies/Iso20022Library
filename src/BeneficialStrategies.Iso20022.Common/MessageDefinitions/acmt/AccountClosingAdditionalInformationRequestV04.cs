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

namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.021.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R28WMTEZEe6kQ-WGAhcVPQ")]
[DisplayName("Account Closing Additional Information Request V04")]
public record AccountClosingAdditionalInformationRequestV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.021.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctClsgAddtlInfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.021.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountForAction1 AccountIdentification { get; init; }

    /// <summary>
    /// Account Servicer Identification.
    /// </summary>
    [DisplayName("Account Servicer Identification")]
    [IsoXmlTag("AcctSvcrId")]
    public required BranchAndFinancialInstitutionIdentification8 AccountServicerIdentification { get; init; }

    /// <summary>
    /// Balance Transfer Account.
    /// </summary>
    [DisplayName("Balance Transfer Account")]
    [IsoXmlTag("BalTrfAcct")]
    public AccountForAction1? BalanceTransferAccount { get; init; }

    /// <summary>
    /// Digital Signature.
    /// </summary>
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public ValueList<PartyAndSignature4> DigitalSignature { get; init; } = [];

    /// <summary>
    /// From.
    /// </summary>
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public OrganisationIdentification39? From { get; init; }

    /// <summary>
    /// Organisation Identification.
    /// </summary>
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification39 OrganisationIdentification { get; init; }

    /// <summary>
    /// References.
    /// </summary>
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References3 References { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Transfer Account Servicer Identification.
    /// </summary>
    [DisplayName("Transfer Account Servicer Identification")]
    [IsoXmlTag("TrfAcctSvcrId")]
    public BranchAndFinancialInstitutionIdentification8? TransferAccountServicerIdentification { get; init; }
}

// Since AccountClosingAdditionalInformationRequestV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountClosingAdditionalInformationRequestV04.
