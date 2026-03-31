// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction to capture.
/// </summary>
[IsoId("_TFZvjQEcEeCQm6a_G2yO_w_281139718")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails4
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_TFi5cAEcEeCQm6a_G2yO_w_1721200563")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_TFi5cQEcEeCQm6a_G2yO_w_-406627280")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_TFi5cgEcEeCQm6a_G2yO_w_-895504319")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_TFi5cwEcEeCQm6a_G2yO_w_-521059955")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public ValueList<DetailedAmount1> DetailedAmount { get; init; } = [];

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_TFi5dAEcEeCQm6a_G2yO_w_-325679295")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TFi5dQEcEeCQm6a_G2yO_w_1441800135")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_TFi5dgEcEeCQm6a_G2yO_w_1903468440")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType1Code? AccountType { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_TFi5dwEcEeCQm6a_G2yO_w_1977558653")]
    [DisplayName("Recurring Transaction")]
    [IsoXmlTag("RcrngTx")]
    public RecurringTransaction1? RecurringTransaction { get; init; }

    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_TFi5eAEcEeCQm6a_G2yO_w_-1953408684")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product1> Product { get; init; } = [];

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_TFi5eQEcEeCQm6a_G2yO_w_-960711141")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
