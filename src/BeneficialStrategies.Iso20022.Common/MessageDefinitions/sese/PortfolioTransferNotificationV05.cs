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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.037.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a PortfolioTransferNotification to another account servicer to exchange transfer settlement details information during a retail or institutional client portfolio transfer.
/// The account servicers will typically be local agents or global custodians acting on behalf of an investment management institution, a broker/dealer or a retail client.
///
/// Usage
/// By exchange of transfer settlement details, it is understood the providing, by the delivering account servicer to the receiving account servicer, of the settlement details (such as trade date, settlement date, delivering settlement chain, quantities) of the individual transfers that will take place during a full or partial portfolio transfer. This delivering account servicer message may also include, for validation, the receiving settlement chain as provided by the client. In case the receiving settlement chain is not available to the delivering account servicer, the receiving account servicer may in return provide to the delivering account servicer the receiving settlement chain using the same message.
///
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends a PortfolioTransferNotification to another account servicer to exchange transfer settlement details information during a retail or institutional client portfolio transfer.|The account servicers will typically be local agents or global custodians acting on behalf of an investment management institution, a broker/dealer or a retail client.||Usage|By exchange of transfer settlement details, it is understood the providing, by the delivering account servicer to the receiving account servicer, of the settlement details (such as trade date, settlement date, delivering settlement chain, quantities) of the individual transfers that will take place during a full or partial portfolio transfer. This delivering account servicer message may also include, for validation, the receiving settlement chain as provided by the client. In case the receiving settlement chain is not available to the delivering account servicer, the receiving account servicer may in return provide to the delivering account servicer the receiving settlement chain using the same message.||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header."
)]
[IsoId("_ViILkaz7EeeBVbuVcoH9Nw")]
[DisplayName("Portfolio Transfer Notification V")]
public record PortfolioTransferNotificationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.037.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.037.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_ViILlaz7EeeBVbuVcoH9Nw")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Provides general information on the notification.
    /// </summary>
    [IsoId("_ViILl6z7EeeBVbuVcoH9Nw")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement62 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ViILmaz7EeeBVbuVcoH9Nw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification98? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ViILm6z7EeeBVbuVcoH9Nw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }

    /// <summary>
    /// Details of transfer.
    /// </summary>
    [IsoId("_ViILnaz7EeeBVbuVcoH9Nw")]
    [DisplayName("Transfer Notification Details")]
    [IsoXmlTag("TrfNtfctnDtls")]
    public SecuritiesTradeDetails72? TransferNotificationDetails { get; init; }
}

// Since PortfolioTransferNotificationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PortfolioTransferNotificationV05.
