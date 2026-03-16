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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.042.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// |An account servicer sends a BuyInRegulatoryAdviceResponse to an account owner to advise the status of a buy-in report previously instructed by the account owner.
/// |The account servicer/owner relationship may be:|
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants|
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or|
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.||
///
/// Usage
/// |A BuyInRegulatpryReport may contain reports on multiple transactions. However, one BuyInRegulatoryReportStatusAdvice must be sent per transaction reported  unless the BuyInRegulatoryReport is rejected as a whole.||
/// The message may also be used to:|- re-send a message previously sent,
/// |- provide a third party with a copy of a message for information,|
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope||An account servicer sends a BuyInRegulatoryAdviceResponse to an account owner to advise the status of a buy-in report previously instructed by the account owner.||The account servicer/owner relationship may be:||- a central securities depository or another settlement market infrastructure acting on behalf of their participants||- an agent (sub-custodian) acting on behalf of their global custodian customer, or||- a custodian acting on behalf of an investment management institution or a broker/dealer.||||Usage||A BuyInRegulatpryReport may contain reports on multiple transactions. However, one BuyInRegulatoryReportStatusAdvice must be sent per transaction reported  unless the BuyInRegulatoryReport is rejected as a whole.|||The message may also be used to:|- re-send a message previously sent,||- provide a third party with a copy of a message for information,||- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header."
)]
[IsoId("_DFqK8ZwYEeqtp-LOti013g")]
[DisplayName("Buy In Regulatory Advice Response V")]
public record BuyInRegulatoryAdviceResponseV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.042.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInRgltryAdvcRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.042.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of the BuyInRegulatoryAdvice message for which the response is provided.
    /// </summary>
    [IsoId("_DFqK-ZwYEeqtp-LOti013g")]
    [DisplayName("Advice Reference")]
    [IsoXmlTag("AdvcRef")]
    public required Identification14 AdviceReference { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_DFqK-5wYEeqtp-LOti013g")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account used in the original failing transaction.
    /// </summary>
    [IsoId("_DFqK_ZwYEeqtp-LOti013g")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Details of the buy-in.
    /// </summary>
    [IsoId("_4Pp1QZwYEeqtp-LOti013g")]
    [DisplayName("Buy In Attributes")]
    [IsoXmlTag("BuyInAttrbts")]
    public BuyInAdviceDetails1? BuyInAttributes { get; init; }

    /// <summary>
    /// Provides details on the processing status of the advice.
    /// </summary>
    [IsoId("_DFqLAZwYEeqtp-LOti013g")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required ProcessingStatus79Choice_ ProcessingStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DFqLA5wYEeqtp-LOti013g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since BuyInRegulatoryAdviceResponseV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BuyInRegulatoryAdviceResponseV01.
