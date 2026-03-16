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
/// This record is an implementation of the camt.067.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The IntraBalanceMovementStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement instruction previously sent by the account owner/requestor.||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is &quot;Duplicate&quot;)|- provide a third party with a copy of a message for information (the sub-function of the message is &quot;Copy&quot;)|- re-send to a third party a copy of a message for information (the sub-function of the message is &quot;CopyDuplicate&quot;).
/// </summary>
[Description(
    @"The IntraBalanceMovementStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement instruction previously sent by the account owner/requestor.||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is ""Duplicate"")|- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"")|- re-send to a third party a copy of a message for information (the sub-function of the message is ""CopyDuplicate"")."
)]
[IsoId("_DLtLcTncEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement Status Advice V")]
public record IntraBalanceMovementStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.067.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.067.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtLeTncEem7JZMuWtwtsg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public DocumentIdentification51? Identification { get; init; }

    /// <summary>
    /// Unambiguous identification of a transaction as per the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_DLtLezncEem7JZMuWtwtsg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifications24 TransactionIdentification { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_DLtLfTncEem7JZMuWtwtsg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus67Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_DLtLfzncEem7JZMuWtwtsg")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus16Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Account to or from which an entry is made.
    /// </summary>
    [IsoId("_DLtLgTncEem7JZMuWtwtsg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount38 CashAccount { get; init; }

    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_-M0_4jp7EemwKdP955WBJQ")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_-M0_4zp7EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }

    /// <summary>
    /// Intra-balance movement transaction details.
    /// </summary>
    [IsoId("_DLtLgzncEem7JZMuWtwtsg")]
    [DisplayName("Underlying Intra Balance")]
    [IsoXmlTag("UndrlygIntraBal")]
    public IntraBalance5? UnderlyingIntraBalance { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtLhTncEem7JZMuWtwtsg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since IntraBalanceMovementStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementStatusAdviceV01.
