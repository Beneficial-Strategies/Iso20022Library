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
/// This record is an implementation of the camt.036.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Debit Authorisation Response message is sent by an account owner to its account servicing institution. This message is used to approve or reject a debit authorisation request.
/// Usage
/// The Debit Authorisation Response message is used to reply to a Debit Authorisation Request message.
/// The Debit Authorisation Response message covers one and only one payment instruction at a time. If an account owner needs to reply to several Debit Authorisation Request messages, then multiple Debit Authorisation Response messages must be sent.
/// The Debit Authorisation Response message indicates whether the account owner agrees with the request by means of a code. It also allows further details to be given about the debit authorisation, such as acceptable amount and value date for the debit.
/// The Debit Authorisation Response message must be used exclusively between the account owner and the account servicing institution. It must not be used in place of a Resolution Of Investigation message between subsequent agents.
/// </summary>
[Description(
    @"Scope|The Debit Authorisation Response message is sent by an account owner to its account servicing institution. This message is used to approve or reject a debit authorisation request.|Usage|The Debit Authorisation Response message is used to reply to a Debit Authorisation Request message.|The Debit Authorisation Response message covers one and only one payment instruction at a time. If an account owner needs to reply to several Debit Authorisation Request messages, then multiple Debit Authorisation Response messages must be sent.|The Debit Authorisation Response message indicates whether the account owner agrees with the request by means of a code. It also allows further details to be given about the debit authorisation, such as acceptable amount and value date for the debit.|The Debit Authorisation Response message must be used exclusively between the account owner and the account servicing institution. It must not be used in place of a Resolution Of Investigation message between subsequent agents."
)]
[IsoId("_Tq8ZyNE-Ed-BzquC8wXy7w_1812295152")]
[DisplayName("Debit Authorisation Response")]
public record DebitAuthorisationResponse : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.036.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.036.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies an assignment.
    /// </summary>
    [IsoId("_Tq8ZydE-Ed-BzquC8wXy7w_1252126016")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment Assignment { get; init; }

    /// <summary>
    /// Identifies a case.
    /// </summary>
    [IsoId("_Tq8ZytE-Ed-BzquC8wXy7w_1259517114")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public required Case Case { get; init; }

    /// <summary>
    /// Indicates if the debit authorisation is granted or not.
    /// </summary>
    [IsoId("_Tq8Zy9E-Ed-BzquC8wXy7w_-1737905108")]
    [DisplayName("Confirmation")]
    [IsoXmlTag("Conf")]
    public required DebitAuthorisationConfirmation Confirmation { get; init; }
}

// Since DebitAuthorisationResponseDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DebitAuthorisationResponse.
