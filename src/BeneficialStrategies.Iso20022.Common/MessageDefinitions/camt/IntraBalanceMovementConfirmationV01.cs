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
/// This record is an implementation of the camt.068.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The IntraBalanceMovementConfirmation message is sent from a settlement infrastructure to an account owner/requestor to confirm the movement of an amount of money within its holdings from one sub-balance to another. ||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is &quot;Duplicate&quot;)|- provide a third party with a copy of a message for information (the sub-function of the message is &quot;Copy&quot;)|- re-send to a third party a copy of a message for information (the sub-function of the message is &quot;CopyDuplicate&quot;).
/// </summary>
[Description(
    @"The IntraBalanceMovementConfirmation message is sent from a settlement infrastructure to an account owner/requestor to confirm the movement of an amount of money within its holdings from one sub-balance to another. ||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is ""Duplicate"")|- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"")|- re-send to a third party a copy of a message for information (the sub-function of the message is ""CopyDuplicate"")."
)]
[IsoId("_DLtKozncEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Movement Confirmation V")]
public record IntraBalanceMovementConfirmationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.068.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.068.001.01";

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
    [IsoId("_DLtKqzncEem7JZMuWtwtsg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public DocumentIdentification51? Identification { get; init; }

    /// <summary>
    /// Additional parameters to the transaction.
    /// </summary>
    [IsoId("_DLtKrTncEem7JZMuWtwtsg")]
    [DisplayName("Additional Parameters")]
    [IsoXmlTag("AddtlParams")]
    public AdditionalParameters16? AdditionalParameters { get; init; }

    /// <summary>
    /// Account to or from which an entry is made.
    /// </summary>
    [IsoId("_DLtKrzncEem7JZMuWtwtsg")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public required CashAccount38 CashAccount { get; init; }

    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_CWqjEjp8EemwKdP955WBJQ")]
    [DisplayName("Cash Account Owner")]
    [IsoXmlTag("CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }

    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_CWqjEzp8EemwKdP955WBJQ")]
    [DisplayName("Cash Account Servicer")]
    [IsoXmlTag("CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }

    /// <summary>
    /// Intra-balance movement transaction details.
    /// </summary>
    [IsoId("_DLtKsTncEem7JZMuWtwtsg")]
    [DisplayName("Intra Balance")]
    [IsoXmlTag("IntraBal")]
    public required IntraBalance6 IntraBalance { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtKszncEem7JZMuWtwtsg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since IntraBalanceMovementConfirmationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraBalanceMovementConfirmationV01.
