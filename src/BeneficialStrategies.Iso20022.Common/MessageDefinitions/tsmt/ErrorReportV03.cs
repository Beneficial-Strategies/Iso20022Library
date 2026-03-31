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
/// This record is an implementation of the tsmt.016.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ErrorReport message is sent by the matching application to the party from which it received a message.
/// This message is used to inform about the inability of the matching application to process a received message.
/// Usage
/// The ErrorReport message can be sent to a party from which the matching application received a message to inform about its inability to process the received message because
/// - the syntax of the message is incorrect,or
/// - the message content is inconsistent,or
/// - according to the workflow implemented in the matching application, it did not expect the received message.
/// </summary>
[Description(
    @"Scope|The ErrorReport message is sent by the matching application to the party from which it received a message.|This message is used to inform about the inability of the matching application to process a received message.|Usage|The ErrorReport message can be sent to a party from which the matching application received a message to inform about its inability to process the received message because|- the syntax of the message is incorrect,or|- the message content is inconsistent,or|- according to the workflow implemented in the matching application, it did not expect the received message."
)]
[IsoId("_oHDjhdE8Ed-BzquC8wXy7w_-1687018808")]
[DisplayName("Error Report V")]
public record ErrorReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.016.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ErrRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.016.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_oHDjhtE8Ed-BzquC8wXy7w_-1686098714")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_oHDjh9E8Ed-BzquC8wXy7w_-1686098652")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public SimpleIdentificationInformation? TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_oHDjiNE8Ed-BzquC8wXy7w_-1686098591")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_oHDjidE8Ed-BzquC8wXy7w_-1686098560")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionStatus4? TransactionStatus { get; init; }

    /// <summary>
    /// Reference to the transaction for the financial institution which is the sender of the rejected message.
    /// </summary>
    [IsoId("_oHDjitE8Ed-BzquC8wXy7w_-1686098745")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    public DocumentIdentification5? UserTransactionReference { get; init; }

    /// <summary>
    /// Reference to the identification of the rejected message.
    /// </summary>
    [IsoId("_oHDji9E8Ed-BzquC8wXy7w_-1686098683")]
    [DisplayName("Rejected Message Reference")]
    [IsoXmlTag("RjctdMsgRef")]
    public MessageIdentification1? RejectedMessageReference { get; init; }

    /// <summary>
    /// Specifies the total number of errors identified in the rejected message.
    /// </summary>
    [IsoId("_oHNUgNE8Ed-BzquC8wXy7w_-1687018798")]
    [DisplayName("Number Of Errors")]
    [IsoXmlTag("NbOfErrs")]
    public required Count1 NumberOfErrors { get; init; }

    /// <summary>
    /// Describes the error that is the cause of the rejection.
    /// </summary>
    [IsoId("_oHNUgdE8Ed-BzquC8wXy7w_-1686098797")]
    [DisplayName("Error Description")]
    [IsoXmlTag("ErrDesc")]
    public required ValidationResult3 ErrorDescription { get; init; }

    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_oHNUgtE8Ed-BzquC8wXy7w_-1686098530")]
    [DisplayName("Request For Action")]
    [IsoXmlTag("ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
}

// Since ErrorReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ErrorReportV03.
