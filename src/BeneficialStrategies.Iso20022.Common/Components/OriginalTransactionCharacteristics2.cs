// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the transaction characteristics of original transaction.
/// </summary>
[IsoId("_PJug8UiTEfCMZJtj4J7UGQ")]
[DisplayName("Original Transaction Characteristics2")]
public record OriginalTransactionCharacteristics2
{
    /// <summary>
    /// Code that indicates the type of transaction being undertaken in accordance with ISO 8583, Transaction Type.
    /// </summary>
    [IsoId("_PMVJAUiTEfCMZJtj4J7UGQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; }

    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    [IsoId("_PMVJCUiTEfCMZJtj4J7UGQ")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Attribute of the transaction.
    /// </summary>
    [IsoId("_PMVJC0iTEfCMZJtj4J7UGQ")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public SimpleValueList<TransactionAttribute3Code> TransactionAttribute { get; init; } = [];

    /// <summary>
    /// Reason or purpose to send the message.
    /// </summary>
    [IsoId("_PMVJD0iTEfCMZJtj4J7UGQ")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<ISO8583MessageReasonCode> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_PMVJHUiTEfCMZJtj4J7UGQ")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax256Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// </summary>
    [IsoId("_PMVJH0iTEfCMZJtj4J7UGQ")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_PMVJJ0iTEfCMZJtj4J7UGQ")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_DzZfskiEEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_DzZfs0iEEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
