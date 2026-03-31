// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money debited or credited on the books of an account servicer.
/// </summary>
[IsoId("_tCgW4zp8EeWVrPy0StzzSg")]
[DisplayName("Amount And Direction")]
public record AmountAndDirection44
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_tiCyYzp8EeWVrPy0StzzSg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_tiCyazp8EeWVrPy0StzzSg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    [IsoId("_tiCyczp8EeWVrPy0StzzSg")]
    [DisplayName("Original Currency And Ordered Amount")]
    [IsoXmlTag("OrgnlCcyAndOrdrdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_tiCyezp8EeWVrPy0StzzSg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms23? ForeignExchangeDetails { get; init; }
}
