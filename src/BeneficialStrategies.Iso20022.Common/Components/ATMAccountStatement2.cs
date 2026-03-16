// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
[IsoId("_O9ETgYq8EeSHjtO_wHA7PQ")]
[DisplayName("ATM Account Statement")]
public record ATMAccountStatement2
{
    /// <summary>
    /// Date of the transaction.
    /// </summary>
    [IsoId("_eeqZIIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Transaction Date")]
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransactionDate { get; init; }

    /// <summary>
    /// Value date of the transaction.
    /// </summary>
    [IsoId("_iEU4QIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Short text to display or print for the statement.
    /// </summary>
    [IsoId("_p2DvMIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Short Text")]
    [IsoXmlTag("ShrtTxt")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ShortText { get; init; }

    /// <summary>
    /// True if credit transaction.
    /// </summary>
    [IsoId("_tS5pgIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Credit Transaction")]
    [IsoXmlTag("CdtTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditTransaction { get; init; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_zc0OEIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_5RrIoIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Alternative text of the statement to print or display.
    /// </summary>
    [IsoId("_99CrkIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Long Text")]
    [IsoXmlTag("LngTxt")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? LongText { get; init; }
}
