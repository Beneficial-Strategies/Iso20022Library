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

namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.009.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorReconciliationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.
/// If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.
/// </summary>
[Description(
    @"The AcceptorReconciliationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.|If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol."
)]
[IsoId("_RuCs0Wl_EeSxgrJ0GX4SQQ")]
[DisplayName("Acceptor Reconciliation Request V")]
public record AcceptorReconciliationRequestV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.009.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.009.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reconciliation request message management information.
    /// </summary>
    [IsoId("_RuCs1Wl_EeSxgrJ0GX4SQQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header10 Header { get; init; }

    /// <summary>
    /// Information related to the reconciliation request.
    /// </summary>
    [IsoId("_RuCs12l_EeSxgrJ0GX4SQQ")]
    [DisplayName("Reconciliation Request")]
    [IsoXmlTag("RcncltnReq")]
    public required AcceptorReconciliationRequest4 ReconciliationRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_RuCs2Wl_EeSxgrJ0GX4SQQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType11 SecurityTrailer { get; init; }
}

// Since AcceptorReconciliationRequestV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorReconciliationRequestV04.
