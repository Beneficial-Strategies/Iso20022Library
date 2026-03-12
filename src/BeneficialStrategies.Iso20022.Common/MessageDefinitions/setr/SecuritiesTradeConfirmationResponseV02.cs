// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.030.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// Sent by an instructing party, a custodian or an affirming party to an executing party (local matching) or to Central Matching Utility (CMU) to affirm (accept) or disaffirm (reject) (central matching) the SecuritiesTradeConfirmation message. If accepting the SecuritiesTradeConfirmation message, then the trade is ready for settlement processing. If rejecting the SecuritiesTradeConfirmation message, then the trade is not ready for settlement.
/// The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.
/// The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.
/// The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.
/// The ISO 20022 Business Application Header must be used
/// Usage
/// Initiator: Both in local and central matching, the Initiator may be the Instructing Party, Custodian or Affirming party.
/// Respondent: Executing party does not need to respond if an affirmation. Executing party may respond with modification or cancellation of the rejected SecuritiesTradeConfirmation message.
/// </summary>
[Description(@"Scope|Sent by an instructing party, a custodian or an affirming party to an executing party (local matching) or to Central Matching Utility (CMU) to affirm (accept) or disaffirm (reject) (central matching) the SecuritiesTradeConfirmation message. If accepting the SecuritiesTradeConfirmation message, then the trade is ready for settlement processing. If rejecting the SecuritiesTradeConfirmation message, then the trade is not ready for settlement.|The executing party is typically the broker/dealer or an intermediary system/vendor communicating on behalf of the broker/dealer.|The instructing party is typically the investment manager or an intermediary system/vendor communicating on behalf of the investment manager or of other categories of investors.|The custodian or an affirming party is typically the custodian, trustee, financial institution, intermediary system/vendor communicating on behalf of them, or their agent.|The ISO 20022 Business Application Header must be used|Usage|Initiator: Both in local and central matching, the Initiator may be the Instructing Party, Custodian or Affirming party.|Respondent: Executing party does not need to respond if an affirmation. Executing party may respond with modification or cancellation of the rejected SecuritiesTradeConfirmation message.")]
[IsoId("_s7RRwQNmEe2P7e2qGFFOGg")]
[DisplayName("Securities Trade Confirmation Response V")]
public partial record SecuritiesTradeConfirmationResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.030.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTradConfRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.030.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies an SecuritiesTradeConfirmationResponse message as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_s7RRxwNmEe2P7e2qGFFOGg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required TransactiontIdentification4 Identification { get; init; } 
    
    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_s7RRyQNmEe2P7e2qGFFOGg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required Linkages52 References { get; init; } 
    
    /// <summary>
    /// Provides details on the processing status of the trade.
    /// </summary>
    [IsoId("_s7RRywNmEe2P7e2qGFFOGg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required StatusAndReason46 Status { get; init; } 
    
    /// <summary>
    /// Provides clearing member information.
    /// </summary>
    [IsoId("_s7RRzQNmEe2P7e2qGFFOGg")]
    [DisplayName("Clearing Details")]
    [IsoXmlTag("ClrDtls")]
    public Clearing6? ClearingDetails { get; init; } 
    
    /// <summary>
    /// Parties involved in the confirmation of the details of a trade.
    /// </summary>
    [IsoId("_s7RRzwNmEe2P7e2qGFFOGg")]
    [DisplayName("Confirmation Parties")]
    [IsoXmlTag("ConfPties")]
    public ConfirmationParties8? ConfirmationParties { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_s7RR0QNmEe2P7e2qGFFOGg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since SecuritiesTradeConfirmationResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTradeConfirmationResponseV02.

