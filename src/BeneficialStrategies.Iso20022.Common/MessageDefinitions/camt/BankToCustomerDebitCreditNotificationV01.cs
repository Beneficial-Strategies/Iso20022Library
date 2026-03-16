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
/// This record is an implementation of the camt.054.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Bank-to-Customer Debit/Credit Notification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.
/// Usage
/// The Bank-to-Customer Debit/Credit Notification message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation.
/// It can be used to:
/// - report pending and booked items;
/// - notify one or more debit entries;
/// - notify one or more credit entries;
/// - notify a combination of debit and credit entries
/// It can include underlying details of transactions that have been included in the entry.
/// It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).
/// It does not contain balance information.
/// </summary>
[Description(
    @"Scope|The Bank-to-Customer Debit/Credit Notification message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It can be used to inform the account owner, or authorised party, of single or multiple debit and/or credit entries reported to the account.|Usage|The Bank-to-Customer Debit/Credit Notification message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation.|It can be used to:|- report pending and booked items;|- notify one or more debit entries;|- notify one or more credit entries;|- notify a combination of debit and credit entries|It can include underlying details of transactions that have been included in the entry.|It is possible that the receiver of the message is not the account owner, but a party entitled by the account owner to receive the account information (also known as recipient).|It does not contain balance information."
)]
[IsoId("_In48CNE-Ed-BzquC8wXy7w_1638002708")]
[DisplayName("Bank To Customer Debit Credit Notification V")]
public record BankToCustomerDebitCreditNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.054.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrDbtCdtNtfctnV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.054.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_In48CdE-Ed-BzquC8wXy7w_640607521")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader23 GroupHeader { get; init; }

    /// <summary>
    /// Notifies debit and credit entries for the account.
    /// </summary>
    [IsoId("_IoCF8NE-Ed-BzquC8wXy7w_296135544")]
    [DisplayName("Notification")]
    [IsoXmlTag("Ntfctn")]
    public required AccountNotification1 Notification { get; init; }
}

// Since BankToCustomerDebitCreditNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BankToCustomerDebitCreditNotificationV01.
