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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.037.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Debit Authorisation Request message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.
/// Usage
/// The Debit Authorisation Request message must be answered with a Debit Authorisation Response message.
/// The Debit Authorisation Request message can be used to request debit authorisation in a:
/// - request to modify payment case (in the case of a lower final amount or change of creditor)
/// - request to cancel payment case (full amount)
/// - unable to apply case (the creditor whose account has been credited is not the intended beneficiary)
/// - claim non receipt case (the creditor whose account has been credited is not the intended beneficiary)
/// The Debit Authorisation Request message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple Debit Authorisation Request messages must be sent.
/// The Debit Authorisation Request must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a Request To Modify Payment or Request To Cancel Payment message between subsequent agents.
/// </summary>
[Description(
    @"Scope|The Debit Authorisation Request message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.|Usage|The Debit Authorisation Request message must be answered with a Debit Authorisation Response message.|The Debit Authorisation Request message can be used to request debit authorisation in a:|- request to modify payment case (in the case of a lower final amount or change of creditor)|- request to cancel payment case (full amount)|- unable to apply case (the creditor whose account has been credited is not the intended beneficiary)|- claim non receipt case (the creditor whose account has been credited is not the intended beneficiary)|The Debit Authorisation Request message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple Debit Authorisation Request messages must be sent.|The Debit Authorisation Request must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a Request To Modify Payment or Request To Cancel Payment message between subsequent agents."
)]
[IsoId("_uH4KAUggEeaGKYpLDboHPQ")]
[DisplayName("Debit Authorisation Request V")]
public record DebitAuthorisationRequestV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.037.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DbtAuthstnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.037.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_uH4KA0ggEeaGKYpLDboHPQ")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment3 Assignment { get; init; }

    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_uH4KBUggEeaGKYpLDboHPQ")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case3 Case { get; init; }

    /// <summary>
    /// Identifies the underlying payment instruction.
    /// </summary>
    [IsoId("_uH4KB0ggEeaGKYpLDboHPQ")]
    [DisplayName("Underlying")]
    [IsoXmlTag("Undrlyg")]
    public required UnderlyingTransaction3Choice_ Underlying { get; init; }

    /// <summary>
    /// Detailed information about the request.
    /// </summary>
    [IsoId("_uH4KCUggEeaGKYpLDboHPQ")]
    [DisplayName("Detail")]
    [IsoXmlTag("Dtl")]
    public required DebitAuthorisation2 Detail { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_uH4KC0ggEeaGKYpLDboHPQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since DebitAuthorisationRequestV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DebitAuthorisationRequestV05.
