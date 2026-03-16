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
/// This record is an implementation of the camt.053.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Bank-to-Customer Statement message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It is used to inform the account owner, or authorised party, of the entries booked to the account, and to provide the owner with balance information on the account at a given point in time.
/// Usage
/// The Bank-to-Customer Statement message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation.
/// It contains information on booked entries only.
/// It can include underlying details of transactions that have been included in the entry.
/// The message is exchanged as defined between the account servicer and the account owner. It provides information on items that have been booked to the account (and therefore are &quot;binding&quot; and also balance information. Depending on services agreed between banks and their customers, &quot;binding&quot; statements can be generated and exchanged intraday. Depending on legal requirements in local jurisdictions, &quot;end-of-day&quot; statements may need to be mandatorily generated and exchanged.
/// It is possible that the receiver of the message is not the account owner, but a party entitled through arrangement with the account owner to receive the account information (also known as recipient).
/// </summary>
[Description(
    @"Scope|The Bank-to-Customer Statement message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It is used to inform the account owner, or authorised party, of the entries booked to the account, and to provide the owner with balance information on the account at a given point in time.|Usage|The Bank-to-Customer Statement message can contain reports for more than 1 account. It provides information for cash management and/or reconciliation.|It contains information on booked entries only.|It can include underlying details of transactions that have been included in the entry.|The message is exchanged as defined between the account servicer and the account owner. It provides information on items that have been booked to the account (and therefore are ""binding"" and also balance information. Depending on services agreed between banks and their customers, ""binding"" statements can be generated and exchanged intraday. Depending on legal requirements in local jurisdictions, ""end-of-day"" statements may need to be mandatorily generated and exchanged.|It is possible that the receiver of the message is not the account owner, but a party entitled through arrangement with the account owner to receive the account information (also known as recipient)."
)]
[IsoId("_JlInYNE-Ed-BzquC8wXy7w_1694338972")]
[DisplayName("Bank To Customer Statement V")]
public record BankToCustomerStatementV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.053.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrStmtV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.01";

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
    [IsoId("_JlInYdE-Ed-BzquC8wXy7w_926898019")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader23 GroupHeader { get; init; }

    /// <summary>
    /// Reports on booked entries and balances for a cash account.
    /// </summary>
    [IsoId("_JlInYtE-Ed-BzquC8wXy7w_926897907")]
    [DisplayName("Statement")]
    [IsoXmlTag("Stmt")]
    public required AccountStatement1 Statement { get; init; }
}

// Since BankToCustomerStatementV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BankToCustomerStatementV01.
