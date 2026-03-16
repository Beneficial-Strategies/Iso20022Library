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
[IsoId("_zU1DIYIeEeSvPp7yXrNQIw")]
[DisplayName("Card Transaction Detail")]
public record CardTransactionDetail3
{
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    [IsoId("_zhWcMYIeEeSvPp7yXrNQIw")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required CardTransactionAmount3 TransactionAmounts { get; init; }

    /// <summary>
    /// Fees between acquirer and issuer exclusive of the transaction amount, and expressed in the currency of the reconciliation.
    /// </summary>
    [IsoId("_DCm_oIKYEeSIRfXNMHH5mQ")]
    [DisplayName("Transaction Fees")]
    [IsoXmlTag("TxFees")]
    public DetailedAmount11? TransactionFees { get; init; }

    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    [IsoId("_zhWcM4IeEeSvPp7yXrNQIw")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public DetailedAmount10? AdditionalAmounts { get; init; }

    /// <summary>
    /// Reason to send a card acquirer to issuer message.
    /// It corresponds to ISO 8583 field number 25 for the version 93, and field number 9 for the version 2003.
    /// </summary>
    [IsoId("_zhWcNYIeEeSvPp7yXrNQIw")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public MessageReason1Code? MessageReason { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// It corresponds to ISO 8583 field number 57 for the version 93, and field number 3 for the version 2003.
    /// </summary>
    [IsoId("_zhWcN4IeEeSvPp7yXrNQIw")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Transaction category level on an unattended terminal.
    /// </summary>
    [IsoId("_zhWcOYIeEeSvPp7yXrNQIw")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for debits, inquiries and the “from” account for transfers.
    /// </summary>
    [IsoId("_zhWcO4IeEeSvPp7yXrNQIw")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public CardAccount1? AccountFrom { get; init; }

    /// <summary>
    /// Way to identify a customer account or a relationship to its account affected for credits and the “to” account for transfers.
    /// </summary>
    [IsoId("_zhWcPYIeEeSvPp7yXrNQIw")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public CardAccount1? AccountTo { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_zhWcP4IeEeSvPp7yXrNQIw")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; }

    /// <summary>
    /// Information requested against money laundering for a transfer transaction.
    /// </summary>
    [IsoId("_zhWcQYIeEeSvPp7yXrNQIw")]
    [DisplayName("Anti Money Laundering")]
    [IsoXmlTag("AML")]
    public AntiMoneyLaundering1? AntiMoneyLaundering { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583 field number 55 for the versions 93 and 2003.
    /// </summary>
    [IsoId("_zhWcQ4IeEeSvPp7yXrNQIw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
