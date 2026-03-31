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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.023.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an executing party or an instructing party to the custodian or an affirming party to notify that all the necessary SecuritiesTradeConfirmation message or any other notification of the process have been sent.
/// It may also be sent through Central Matching Utility (CMU).
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Executing Party, CMU or Instructing Party
/// Respondent: Custodian or an affirming party does not need to respond.
/// </summary>
[Description(
    @"Scope|Sent by an executing party or an instructing party to the custodian or an affirming party to notify that all the necessary SecuritiesTradeConfirmation message or any other notification of the process have been sent.|It may also be sent through Central Matching Utility (CMU).|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Executing Party, CMU or Instructing Party|Respondent: Custodian or an affirming party does not need to respond."
)]
[IsoId("_j5E4gQNmEe2P7e2qGFFOGg")]
[DisplayName("Securities End Of Process Report V")]
public record SecuritiesEndOfProcessReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.023.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesEndOfPrcRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.023.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_j5E4hwNmEe2P7e2qGFFOGg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// Notifies the type of report transmitted.
    /// </summary>
    [IsoId("_j5E4iQNmEe2P7e2qGFFOGg")]
    [DisplayName("Report General Details")]
    [IsoXmlTag("RptGnlDtls")]
    public required Report6 ReportGeneralDetails { get; init; }

    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_j5E4iwNmEe2P7e2qGFFOGg")]
    [DisplayName("Confirmation Parties")]
    [IsoXmlTag("ConfPties")]
    public ConfirmationParties7? ConfirmationParties { get; init; }

    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    [IsoId("_j5E4jQNmEe2P7e2qGFFOGg")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentificationAndAccount220? Investor { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_j5E4jwNmEe2P7e2qGFFOGg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecuritiesEndOfProcessReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesEndOfProcessReportV02.
