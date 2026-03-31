// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify the underlying batches.
/// </summary>
[IsoId("_RpiHptp-Ed-ak6NoX_4Aeg_-252918012")]
[DisplayName("Batch Information")]
public record BatchInformation2
{
    /// <summary>
    /// Point to point reference, as assigned by the sending party, to unambiguously identify the batch of transactions.
    /// </summary>
    [IsoId("_RpiHp9p-Ed-ak6NoX_4Aeg_-252918010")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MessageIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("_RpiHqNp-Ed-ak6NoX_4Aeg_-252917734")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Number of individual transactions included in the batch.
    /// </summary>
    [IsoId("_RpiHqdp-Ed-ak6NoX_4Aeg_-252917703")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total amount of money reported in the batch entry.
    /// </summary>
    [IsoId("_RpiHqtp-Ed-ak6NoX_4Aeg_1213636497")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Indicates whether the batch entry is a credit or a debit entry.
    /// </summary>
    [IsoId("_Rpr4oNp-Ed-ak6NoX_4Aeg_1244110856")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }
}
