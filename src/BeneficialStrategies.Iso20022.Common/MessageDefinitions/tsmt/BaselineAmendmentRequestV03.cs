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

namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.009.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BaselineAmendmentRequest message is sent by a primary party involved in a transaction to the matching application.
/// The message is used to request the amendment of an established baseline.
/// Usage
/// The BaselineAmendmentRequest message may only be sent if the transaction is in the state Established or Active.
/// The BaselineAmendmentRequest message can be sent to the matching application by one of the primary parties involved in a transaction established in the push-through mode to request the amendment of an established baseline.
/// The matching application acknowledges the receipt of the amendment request by sending a DeltaReport message to the submitter of the BaselineAmendmentRequest message. It passes on the newly proposed baseline to the counterparty by sending a FullPushThroughReport message, a DeltaReport message and a pre-calculated BaselineReport message.
/// The counterparty is expected to either accept or reject the amendment request by submitting an AmendmentAcceptance or AmendmentRejection message.
/// or
/// The BaselineAmendmentRequest message can be sent by the party involved in a transaction established in the lodge mode to the matching application to amend an established baseline.
/// The matching application amends the baseline according to the BaselineAmendmentRequest message and confirms the execution of the request by sending a DeltaReport and calculated BaselineReport message to the requester of the amendment.
/// </summary>
[Description(
    @"Scope|The BaselineAmendmentRequest message is sent by a primary party involved in a transaction to the matching application.|The message is used to request the amendment of an established baseline.|Usage|The BaselineAmendmentRequest message may only be sent if the transaction is in the state Established or Active.|The BaselineAmendmentRequest message can be sent to the matching application by one of the primary parties involved in a transaction established in the push-through mode to request the amendment of an established baseline.|The matching application acknowledges the receipt of the amendment request by sending a DeltaReport message to the submitter of the BaselineAmendmentRequest message. It passes on the newly proposed baseline to the counterparty by sending a FullPushThroughReport message, a DeltaReport message and a pre-calculated BaselineReport message.|The counterparty is expected to either accept or reject the amendment request by submitting an AmendmentAcceptance or AmendmentRejection message.|or|The BaselineAmendmentRequest message can be sent by the party involved in a transaction established in the lodge mode to the matching application to amend an established baseline.|The matching application amends the baseline according to the BaselineAmendmentRequest message and confirms the execution of the request by sending a DeltaReport and calculated BaselineReport message to the requester of the amendment."
)]
[IsoId("_lGO21tE8Ed-BzquC8wXy7w_-1621087191")]
[DisplayName("Baseline Amendment Request V")]
public record BaselineAmendmentRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.009.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BaselnAmdmntReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.009.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_lGO219E8Ed-BzquC8wXy7w_-1621087155")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_lGO22NE8Ed-BzquC8wXy7w_-1621087078")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_lGO22dE8Ed-BzquC8wXy7w_-1621087120")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }

    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_lGO22tE8Ed-BzquC8wXy7w_-1621087174")]
    [DisplayName("Baseline")]
    [IsoXmlTag("Baseln")]
    public required Baseline3 Baseline { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_lGO229E8Ed-BzquC8wXy7w_-1724579248")]
    [DisplayName("Buyer Contact Person")]
    [IsoXmlTag("BuyrCtctPrsn")]
    public ContactIdentification1? BuyerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_lGYn0NE8Ed-BzquC8wXy7w_-1282211094")]
    [DisplayName("Seller Contact Person")]
    [IsoXmlTag("SellrCtctPrsn")]
    public ContactIdentification1? SellerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the buyer&apos;s bank.
    /// </summary>
    [IsoId("_lGYn0dE8Ed-BzquC8wXy7w_-1166771083")]
    [DisplayName("Buyer Bank Contact Person")]
    [IsoXmlTag("BuyrBkCtctPrsn")]
    public ContactIdentification1? BuyerBankContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the seller&apos;s bank.
    /// </summary>
    [IsoId("_lGYn0tE8Ed-BzquC8wXy7w_-825993983")]
    [DisplayName("Seller Bank Contact Person")]
    [IsoXmlTag("SellrBkCtctPrsn")]
    public ContactIdentification1? SellerBankContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in another bank than the seller or buyer&apos;s bank.
    /// </summary>
    [IsoId("_lGYn09E8Ed-BzquC8wXy7w_-491678031")]
    [DisplayName("Other Bank Contact Person")]
    [IsoXmlTag("OthrBkCtctPrsn")]
    public ContactIdentification3? OtherBankContactPerson { get; init; }
}

// Since BaselineAmendmentRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BaselineAmendmentRequestV03.
