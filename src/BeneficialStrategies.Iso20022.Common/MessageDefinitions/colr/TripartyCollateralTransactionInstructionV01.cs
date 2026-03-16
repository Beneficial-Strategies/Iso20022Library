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

namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// This message is sent by a trading party to its triparty agent to instruct the agent to perform a specific action on a collateral management transaction.
/// It is also sent by an account owner to an account servicer where the account servicer manages the account at the triparty agent on behalf of the trading party. The account owner may be a global custodian which manages an account with a triparty agent on behalf of their client or an investment management institution or a broker/dealer which has an account with their custodian.
///
/// Usage:
/// The triparty collateral management service is used by two trading parties at the agreement of a business transaction (for example, a repo, a securities loan, ... ) when they want to secure the transaction with collateral. The management of this collateral (that is, agreeing on quantity and type, marking to market, ... ) is done by a third party, the triparty collateral manager.
///
/// Before starting to use these services, the three parties will first sign a contract in which they stipulate the rules of the agreement.
/// </summary>
[Description(
    @"Scope:|This message is sent by a trading party to its triparty agent to instruct the agent to perform a specific action on a collateral management transaction.|It is also sent by an account owner to an account servicer where the account servicer manages the account at the triparty agent on behalf of the trading party. The account owner may be a global custodian which manages an account with a triparty agent on behalf of their client or an investment management institution or a broker/dealer which has an account with their custodian.||Usage:|The triparty collateral management service is used by two trading parties at the agreement of a business transaction (for example, a repo, a securities loan, ... ) when they want to secure the transaction with collateral. The management of this collateral (that is, agreeing on quantity and type, marking to market, ... ) is done by a third party, the triparty collateral manager.||Before starting to use these services, the three parties will first sign a contract in which they stipulate the rules of the agreement."
)]
[IsoId("_2uaNLSs7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Transaction Instruction V")]
public record TripartyCollateralTransactionInstructionV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.019.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollTxInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.019.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the instruction or the transaction as known by the instructing  or the receiving party.
    /// </summary>
    [IsoId("_2uaNMSs7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    [IsoXmlTag("TxInstrId")]
    public required TransactionIdentifications45 TransactionInstructionIdentification { get; init; }

    /// <summary>
    /// Link to another transaction (or instruction) that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_2uaNMys7EeySlt9bF77XfA")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages58? Linkages { get; init; }

    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaNNSs7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Specifies the different parameters of the collateral transaction or instruction.
    /// </summary>
    [IsoId("_2uaNNys7EeySlt9bF77XfA")]
    [DisplayName("General Parameters")]
    [IsoXmlTag("GnlParams")]
    public required CollateralParameters10 GeneralParameters { get; init; }

    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaNOSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties10 CollateralParties { get; init; }

    /// <summary>
    /// Specifies the information related to the deal.
    /// </summary>
    [IsoId("_2uaNOys7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Details")]
    [IsoXmlTag("DealTxDtls")]
    public required DealTransactionDetails5 DealTransactionDetails { get; init; }

    /// <summary>
    /// Identifies the dates related to the triparty collateral instruction or transactions.
    /// </summary>
    [IsoId("_2uaNPSs7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Date")]
    [IsoXmlTag("DealTxDt")]
    public required CollateralDate2 DealTransactionDate { get; init; }

    /// <summary>
    /// Securities movements.
    /// </summary>
    [IsoId("_2uaNPys7EeySlt9bF77XfA")]
    [DisplayName("Securities Movement")]
    [IsoXmlTag("SctiesMvmnt")]
    public SecuritiesMovement9? SecuritiesMovement { get; init; }

    /// <summary>
    /// Cash movements.
    /// </summary>
    [IsoId("_2uaNQSs7EeySlt9bF77XfA")]
    [DisplayName("Cash Movement")]
    [IsoXmlTag("CshMvmnt")]
    public CashMovement8? CashMovement { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_2uaNQys7EeySlt9bF77XfA")]
    [DisplayName("Other Parties")]
    [IsoXmlTag("OthrPties")]
    public OtherParties38? OtherParties { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNRSs7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since TripartyCollateralTransactionInstructionV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralTransactionInstructionV01.
