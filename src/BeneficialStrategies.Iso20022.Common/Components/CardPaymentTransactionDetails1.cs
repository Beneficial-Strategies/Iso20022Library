// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation request.
/// </summary>
[IsoId("_TFGNhwEcEeCQm6a_G2yO_w_-519029015")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails1
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_TFGNiAEcEeCQm6a_G2yO_w_-479190629")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_TFGNiQEcEeCQm6a_G2yO_w_-1692854046")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_TFGNigEcEeCQm6a_G2yO_w_-191980529")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_TFGNiwEcEeCQm6a_G2yO_w_-1222757790")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public ValueList<DetailedAmount1> DetailedAmount { get; init; } = [];

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_TFGNjAEcEeCQm6a_G2yO_w_-1723872938")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Reason to process an online authorisation.
    /// </summary>
    [IsoId("_TFGNjQEcEeCQm6a_G2yO_w_-1102702174")]
    [DisplayName("On Line Reason")]
    [IsoXmlTag("OnLineRsn")]
    public OnLineReason1Code? OnLineReason { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TFGNjgEcEeCQm6a_G2yO_w_-1908905387")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_TFGNjwEcEeCQm6a_G2yO_w_-1317936980")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType1Code? AccountType { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_TFGNkAEcEeCQm6a_G2yO_w_1690819476")]
    [DisplayName("Recurring Transaction")]
    [IsoXmlTag("RcrngTx")]
    public RecurringTransaction1? RecurringTransaction { get; init; }

    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_TFP-gAEcEeCQm6a_G2yO_w_-1185491154")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product1> Product { get; init; } = [];

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_TFP-gQEcEeCQm6a_G2yO_w_-874836814")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
