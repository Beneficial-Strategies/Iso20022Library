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
/// This record is an implementation of the tsmt.012.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BaselineReSubmission message is sent by either the counterparty or the initiator of a transaction (baseline) to the matching application.
/// This message is used by the counterparty to respond on the registration of a push-through transaction in the matching application or by the initiator or counterparty to re-send earlier mis-matched baseline information.
/// Usage
/// The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a FullPushThroughReport message received from the matching application conveying the details of an InitialBaselineSubmission message. The objective of the BaselineReSubmission message sent in the outlined scenario is to achieve a successful match of two baseline initiation messages in order to establish a transaction in the matching application.
/// or
/// The BaselineReSubmission message can be sent by the initiator of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct an InitialBaselineSubmission or BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.
/// or
/// The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct a BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.
/// </summary>
[Description(
    @"Scope|The BaselineReSubmission message is sent by either the counterparty or the initiator of a transaction (baseline) to the matching application.|This message is used by the counterparty to respond on the registration of a push-through transaction in the matching application or by the initiator or counterparty to re-send earlier mis-matched baseline information.|Usage|The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a FullPushThroughReport message received from the matching application conveying the details of an InitialBaselineSubmission message. The objective of the BaselineReSubmission message sent in the outlined scenario is to achieve a successful match of two baseline initiation messages in order to establish a transaction in the matching application.|or|The BaselineReSubmission message can be sent by the initiator of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct an InitialBaselineSubmission or BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.|or|The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct a BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application."
)]
[IsoId("_mYyq4tE8Ed-BzquC8wXy7w_-2146835428")]
[DisplayName("Baseline Re Submission V")]
public record BaselineReSubmissionV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.012.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BaselnReSubmissn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_mYyq49E8Ed-BzquC8wXy7w_-2146835384")]
    [DisplayName("Submission Identification")]
    [IsoXmlTag("SubmissnId")]
    public required MessageIdentification1 SubmissionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_mYyq5NE8Ed-BzquC8wXy7w_-2146835402")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_mYyq5dE8Ed-BzquC8wXy7w_-2146835349")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }

    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_mYyq5tE8Ed-BzquC8wXy7w_-2146835307")]
    [DisplayName("Baseline")]
    [IsoXmlTag("Baseln")]
    public required Baseline3 Baseline { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_mYyq59E8Ed-BzquC8wXy7w_-2146835047")]
    [DisplayName("Buyer Contact Person")]
    [IsoXmlTag("BuyrCtctPrsn")]
    public ContactIdentification1? BuyerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_mYyq6NE8Ed-BzquC8wXy7w_-2146834549")]
    [DisplayName("Seller Contact Person")]
    [IsoXmlTag("SellrCtctPrsn")]
    public ContactIdentification1? SellerContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the buyer&apos;s bank.
    /// </summary>
    [IsoId("_mYyq6dE8Ed-BzquC8wXy7w_-2146834627")]
    [DisplayName("Buyer Bank Contact Person")]
    [IsoXmlTag("BuyrBkCtctPrsn")]
    public required ContactIdentification1 BuyerBankContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in the seller&apos;s bank.
    /// </summary>
    [IsoId("_mY700NE8Ed-BzquC8wXy7w_-2146834952")]
    [DisplayName("Seller Bank Contact Person")]
    [IsoXmlTag("SellrBkCtctPrsn")]
    public required ContactIdentification1 SellerBankContactPerson { get; init; }

    /// <summary>
    /// Person to be contacted in another bank than the seller or buyer&apos;s bank.
    /// </summary>
    [IsoId("_mY700dE8Ed-BzquC8wXy7w_2007041364")]
    [DisplayName("Other Bank Contact Person")]
    [IsoXmlTag("OthrBkCtctPrsn")]
    public ContactIdentification3? OtherBankContactPerson { get; init; }
}

// Since BaselineReSubmissionV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BaselineReSubmissionV03.
