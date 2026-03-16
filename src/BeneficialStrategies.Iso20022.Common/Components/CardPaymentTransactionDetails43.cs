// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation response contained in a batch.
/// </summary>
[IsoId("_5ZOFMfnGEeaYndR2y_Ep9g")]
[DisplayName("Card Payment Transaction Details")]
public record CardPaymentTransactionDetails43
{
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_5rlAgfnGEeaYndR2y_Ep9g")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_5rlAg_nGEeaYndR2y_Ep9g")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; }

    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_5rlAhfnGEeaYndR2y_Ep9g")]
    [DisplayName("Detailed Amount")]
    [IsoXmlTag("DtldAmt")]
    public DetailedAmount15? DetailedAmount { get; init; }

    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [IsoId("_5rlAh_nGEeaYndR2y_Ep9g")]
    [DisplayName("Invoice Amount")]
    [IsoXmlTag("InvcAmt")]
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; }

    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_5rlnkfnGEeaYndR2y_Ep9g")]
    [DisplayName("Validity Date")]
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityDate { get; init; }

    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_5rlnk_nGEeaYndR2y_Ep9g")]
    [DisplayName("Account Type")]
    [IsoXmlTag("AcctTp")]
    public CardAccountType3Code? AccountType { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_5rlnlfnGEeaYndR2y_Ep9g")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }
}
