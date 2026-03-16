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
/// This record is an implementation of the tsmt.047.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.
/// Usage
/// The SpecialRequest message can be sent at any time during the life time of a transaction as long as the transaction is established and not yet closed.
/// </summary>
[Description(
    @"Scope|The SpecialRequest message is sent by a party to the transaction to the matching application if special circumstances are such that it cannot take part any longer to a specific transaction or that it cannot fulfill its role in the transaction.|Usage|The SpecialRequest message can be sent at any time during the life time of a transaction as long as the transaction is established and not yet closed."
)]
[IsoId("_u_roONE8Ed-BzquC8wXy7w_-951439872")]
[DisplayName("Special Request V")]
public record SpecialRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.047.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SpclReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.047.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the acceptance message.
    /// </summary>
    [IsoId("_u_roOdE8Ed-BzquC8wXy7w_-951439426")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_u_roOtE8Ed-BzquC8wXy7w_-951439751")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the identification of the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_u_1ZMNE8Ed-BzquC8wXy7w_-951439253")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }

    /// <summary>
    /// Type and details of the notification.
    /// </summary>
    [IsoId("_u_1ZMdE8Ed-BzquC8wXy7w_1653813874")]
    [DisplayName("Notification")]
    [IsoXmlTag("Ntfctn")]
    public required Notification1 Notification { get; init; }
}

// Since SpecialRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SpecialRequestV01.
