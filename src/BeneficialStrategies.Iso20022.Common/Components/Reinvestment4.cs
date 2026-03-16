// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reinvestment information.
/// </summary>
[IsoId("_QD7KJZS8EemqYPWMBuVawg")]
[DisplayName("Reinvestment")]
public record Reinvestment4
{
    /// <summary>
    /// Investment fund for the reinvestment.
    /// </summary>
    [IsoId("_QXj3gZS8EemqYPWMBuVawg")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument87 FinancialInstrumentDetails { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_QXj3g5S8EemqYPWMBuVawg")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveCurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Percentage of the reinvestment.
    /// </summary>
    [IsoId("_QXj3hZS8EemqYPWMBuVawg")]
    [DisplayName("Reinvestment Percentage")]
    [IsoXmlTag("RinvstmtPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ReinvestmentPercentage { get; init; }
}
