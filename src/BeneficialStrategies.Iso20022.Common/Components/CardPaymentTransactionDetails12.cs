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
[IsoId("_njt2ETDzEeO9waS4ina8CA")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails12
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_nyTEoTDzEeO9waS4ina8CA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_nyTEozDzEeO9waS4ina8CA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_nyTEpTDzEeO9waS4ina8CA")]
    [DisplayName("Amount Qualifier")]
    [IsoXmlTag("AmtQlfr")]
    public TypeOfAmount1Code? AmountQualifier { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_nyTEpzDzEeO9waS4ina8CA")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount5? DetailedAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_nyTEqTDzEeO9waS4ina8CA")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Reason to process an online authorisation.
    /// </summary>
    [IsoId("_nyTEqzDzEeO9waS4ina8CA")]
    [DisplayName("On Line Reason")]
    [IsoXmlTag("OnLineRsn")]
    public OnLineReason1Code? OnLineReason { get; init; }

    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_nyTErTDzEeO9waS4ina8CA")]
    [DisplayName("Unattended Level Category")]
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_nyTErzDzEeO9waS4ina8CA")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType1Code? AccountType { get; init; }

    /// <summary>
    /// The currency conversion has been accepted by the cardholder.
    /// </summary>
    [IsoId("_o4-awEeaEeODR7vDcYOqmg")]
    [DisplayName("Conversion Accepted")]
    [IsoXmlTag("ConvsAccptd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ConversionAccepted { get; init; }

    /// <summary>
    /// Currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_3ZdmwDDzEeO9waS4ina8CA")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion1? CurrencyConversion { get; init; }

    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_CAUQsDD0EeO9waS4ina8CA")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public RecurringTransaction2? Instalment { get; init; }

    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_dGViIDD8EeO9waS4ina8CA")]
    [DisplayName("Aggregation Transaction")]
    [IsoXmlTag("AggtnTx")]
    public AggregationTransaction1? AggregationTransaction { get; init; }

    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_nyTEszDzEeO9waS4ina8CA")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public ValueList<Product1> Product { get; init; } = [];

    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_P2ad0DD0EeO9waS4ina8CA")]
    [DisplayName("Card Payment Invoice")]
    [IsoXmlTag("CardPmtInvc")]
    public CardPaymentInvoice1? CardPaymentInvoice { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_nyTEtTDzEeO9waS4ina8CA")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
