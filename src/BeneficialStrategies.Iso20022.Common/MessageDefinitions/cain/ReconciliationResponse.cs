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

namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReconciliationResponse message is sent by an issuer or an agent to return the reconciled totals for debits, credits, chargebacks and other transactions.
/// </summary>
[Description(
    @"The ReconciliationResponse message is sent by an issuer or an agent to return the reconciled totals for debits, credits, chargebacks and other transactions."
)]
[IsoId("_A6xeEHvBEeSLmfFG0DG7zQ")]
[DisplayName("Reconciliation Response")]
public record ReconciliationResponse : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.008.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RcncltnRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.008.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_QMmpYHvBEeSLmfFG0DG7zQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header17 Header { get; init; }

    /// <summary>
    /// Information related to the response to a reconciliation.
    /// </summary>
    [IsoId("_ZV0QoHvBEeSLmfFG0DG7zQ")]
    [DisplayName("Reconciliation Response")]
    [IsoXmlTag("RcncltnRspn")]
    public required AcquirerReconciliationResponse1 ReconciliationResponseValue { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_Z6ywgHvCEeSLmfFG0DG7zQ")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since ReconciliationResponseDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReconciliationResponse.
