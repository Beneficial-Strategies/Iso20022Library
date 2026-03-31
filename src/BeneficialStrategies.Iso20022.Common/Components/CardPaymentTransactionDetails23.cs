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
[IsoId("_0s9s0WmKEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails23
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_06OswWmKEeS7iYydEtv3Ug")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_06Osw2mKEeS7iYydEtv3Ug")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_06OsxWmKEeS7iYydEtv3Ug")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_06Osx2mKEeS7iYydEtv3Ug")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount7? DetailedAmount { get; init; }

    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_06OsyWmKEeS7iYydEtv3Ug")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Amount authorised for the transaction.
    /// </summary>
    [IsoId("_06Osy2mKEeS7iYydEtv3Ug")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_06OszWmKEeS7iYydEtv3Ug")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_06Osz2mKEeS7iYydEtv3Ug")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_06Os0WmKEeS7iYydEtv3Ug")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType2Code? AccountType { get; init; }

    /// <summary>
    /// Currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_06Os1WmKEeS7iYydEtv3Ug")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion3? CurrencyConversion { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_06Os12mKEeS7iYydEtv3Ug")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; }

    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_06Os2WmKEeS7iYydEtv3Ug")]
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction1? AggregationTransaction { get; init; }

    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_06Os22mKEeS7iYydEtv3Ug")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product1> Product { get; init; } = [];

    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_06Os3WmKEeS7iYydEtv3Ug")]
    [DisplayName("Card Payment Invoice")]
    [IsoXmlTag("CardPmtInvc")]
    public CardPaymentInvoice1? CardPaymentInvoice { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_06Os32mKEeS7iYydEtv3Ug")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
