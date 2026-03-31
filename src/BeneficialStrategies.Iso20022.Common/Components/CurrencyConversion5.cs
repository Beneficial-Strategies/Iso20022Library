// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Exchange rate and calculated amount to be presented to the customer when the dispense currency or the deposit currency (target currency) is different to account currency (source currency).
/// </summary>
[IsoId("_S77gUYq9EeSHjtO_wHA7PQ")]
[DisplayName("Currency Conversion")]
public record CurrencyConversion5
{
    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_TH_mbYq9EeSHjtO_wHA7PQ")]
    [DisplayName("Source Currency")]
    [IsoXmlTag("SrcCcy")]
    public required ActiveCurrencyCode SourceCurrency { get; init; }

    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_TH_mb4q9EeSHjtO_wHA7PQ")]
    [DisplayName("Source Currency Numeric")]
    [IsoXmlTag("SrcCcyNmrc")]
    public required ActiveCurrencyCode SourceCurrencyNumeric { get; init; }

    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_TH2cd4q9EeSHjtO_wHA7PQ")]
    [DisplayName("Target Currency")]
    [IsoXmlTag("TrgtCcy")]
    public required ActiveCurrencyCode TargetCurrency { get; init; }

    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 numeric characters).
    /// </summary>
    [IsoId("_TH2ceYq9EeSHjtO_wHA7PQ")]
    [DisplayName("Target Currency Numeric")]
    [IsoXmlTag("TrgtCcyNmrc")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText TargetCurrencyNumeric { get; init; }

    /// <summary>
    /// Currency exchange rate.
    /// </summary>
    [IsoId("_TH_mZYq9EeSHjtO_wHA7PQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public required IsoBaseOneRate Rate { get; init; }

    /// <summary>
    /// Resulting calculated amount is in target currency.
    /// </summary>
    [IsoId("_TH_mY4q9EeSHjtO_wHA7PQ")]
    [DisplayName("Calculated Amount")]
    [IsoXmlTag("ClctdAmt")]
    public required ImpliedCurrencyAndAmount CalculatedAmount { get; init; }
}
