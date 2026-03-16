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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a transfer agent sends the StatementOfInvestmentFundTransactions message to the account owner, for example, an investment manager or its authorised representative to provide detailed transactions (increases and decreases) of holdings which occurred during a specified period of time.
/// Usage
/// The StatementOfInvestmentFundTransactions message is used to list the holdings transactions of a single (master) account or several sub-accounts.
/// This message should be used at a frequency agreed bi-laterally between the account servicer and the account owner.
/// This message must not be used in place of confirmation messages.
/// </summary>
[Description(
    @"Scope|An account servicer, for example, a transfer agent sends the StatementOfInvestmentFundTransactions message to the account owner, for example, an investment manager or its authorised representative to provide detailed transactions (increases and decreases) of holdings which occurred during a specified period of time.|Usage|The StatementOfInvestmentFundTransactions message is used to list the holdings transactions of a single (master) account or several sub-accounts.|This message should be used at a frequency agreed bi-laterally between the account servicer and the account owner.|This message must not be used in place of confirmation messages."
)]
[IsoId("_MccbotFSEd-BzquC8wXy7w_1866614208")]
[DisplayName("Statement Of Investment Fund Transactions V")]
public record StatementOfInvestmentFundTransactionsV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.006.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StmtOfInvstmtFndTxsV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.006.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Mccbo9FSEd-BzquC8wXy7w_-1980444025")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MccbpNFSEd-BzquC8wXy7w_1866614228")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MccbpdFSEd-BzquC8wXy7w_1866614269")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MccbptFSEd-BzquC8wXy7w_1866614630")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; }

    /// <summary>
    /// General information related to the investment fund statement of transactions.
    /// </summary>
    [IsoId("_Mccbp9FSEd-BzquC8wXy7w_1866614287")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement8 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Information related to an investment account.
    /// </summary>
    [IsoId("_MccbqNFSEd-BzquC8wXy7w_1866614322")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public required InvestmentAccount25 InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    [IsoId("_McllkNFSEd-BzquC8wXy7w_1866614707")]
    [DisplayName("Transaction On Account")]
    [IsoXmlTag("TxOnAcct")]
    public InvestmentFundTransactionsByFund2? TransactionOnAccount { get; init; }

    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_McllkdFSEd-BzquC8wXy7w_1866614364")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccountIdentification6? SubAccountDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_McllktFSEd-BzquC8wXy7w_1866614672")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since StatementOfInvestmentFundTransactionsV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatementOfInvestmentFundTransactionsV02.
