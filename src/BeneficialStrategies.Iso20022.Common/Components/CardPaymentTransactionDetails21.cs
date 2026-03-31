// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the completion advice.
/// </summary>
[IsoId("_jZhDUWlvEeSGkpGpjm7tzg")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails21
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_jmLmUWlvEeSGkpGpjm7tzg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_jmLmU2lvEeSGkpGpjm7tzg")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_jmLmVWlvEeSGkpGpjm7tzg")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_jmLmV2lvEeSGkpGpjm7tzg")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount7? DetailedAmount { get; init; }

    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_jmLmWWlvEeSGkpGpjm7tzg")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ImpliedCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Amount authorised for the payment transaction.
    /// </summary>
    [IsoId("_jmLmW2lvEeSGkpGpjm7tzg")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ImpliedCurrencyAndAmount? AuthorisedAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_jmLmXWlvEeSGkpGpjm7tzg")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_jmLmX2lvEeSGkpGpjm7tzg")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_jmLmYWlvEeSGkpGpjm7tzg")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType2Code? AccountType { get; init; }

    /// <summary>
    /// Currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_jmLmZWlvEeSGkpGpjm7tzg")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion3? CurrencyConversion { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_jmLmZ2lvEeSGkpGpjm7tzg")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; }

    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_3XEW4GlvEeSGkpGpjm7tzg")]
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction1? AggregationTransaction { get; init; }

    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_jmLmaWlvEeSGkpGpjm7tzg")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product1> Product { get; init; } = [];

    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_jmLma2lvEeSGkpGpjm7tzg")]
    [DisplayName("Card Payment Invoice")]
    [IsoXmlTag("CardPmtInvc")]
    public CardPaymentInvoice1? CardPaymentInvoice { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_jmLmbWlvEeSGkpGpjm7tzg")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
