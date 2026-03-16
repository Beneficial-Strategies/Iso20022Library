// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the card transaction.
/// </summary>
[IsoId("_p7jWQHsxEeSTS7uHCe8FPQ")]
[DisplayName("Card Transaction Detail")]
public record CardTransactionDetail1
{
    /// <summary>
    /// Amounts of the transaction.
    /// </summary>
    [IsoId("_qU2xoHsyEeSTS7uHCe8FPQ")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required CardTransactionAmount1 TransactionAmounts { get; init; }

    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("_N1G2sHs2EeSTS7uHCe8FPQ")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public ValueList<DetailedAmount10> AdditionalAmounts { get; init; } = [];

    /// <summary>
    /// Reason to send an card acquirer to issuer message.
    /// It corresponds to ISO 8583 field number 25 for the version 93, and field number 9 for the version 2003.
    /// </summary>
    [IsoId("_LrwnwHs6EeSTS7uHCe8FPQ")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public MessageReason1Code? MessageReason { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// It corresponds to ISO 8583, field number 57 for the version 93, and 3 for the version 2003.
    /// </summary>
    [IsoId("_jdNqwHs6EeSTS7uHCe8FPQ")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_puXfwHs6EeSTS7uHCe8FPQ")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for debits, inquiries and the “from” account for transfers.
    /// </summary>
    [IsoId("_DG-GwHs7EeSTS7uHCe8FPQ")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount1? AccountFrom { get; init; }

    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for credits and the “to” account for transfers.
    /// </summary>
    [IsoId("_XMTf4HuUEeSVeNXcmBQ4hQ")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public CardAccount1? AccountTo { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_ewSr0Hs-EeSTS7uHCe8FPQ")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; }

    /// <summary>
    /// Information requested against money laundering for a transfer transaction.
    /// </summary>
    [IsoId("_qZh_0Hs-EeSTS7uHCe8FPQ")]
    [DisplayName("Anti Money Laundering")]
    [IsoXmlTag("AML")]
    public AntiMoneyLaundering1? AntiMoneyLaundering { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_dySVYHuUEeSVeNXcmBQ4hQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
