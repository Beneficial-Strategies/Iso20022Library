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
[IsoId("_miRygBQ8EeOKWo1NF21OVw")]
[DisplayName("Reinvestment")]
public record Reinvestment1
{
    /// <summary>
    /// Investment fund for the reinvestment.
    /// </summary>
    [IsoId("_3fQRABQ8EeOKWo1NF21OVw")]
    [DisplayName("Fund Details")]
    [IsoXmlTag("FndDtls")]
    public required FinancialInstrument29 FundDetails { get; init; }

    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_GWLB8BQ9EeOKWo1NF21OVw")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public CurrencyCode? RequestedNAVCurrency { get; init; }

    /// <summary>
    /// Percentage of the reinvestment.
    /// </summary>
    [IsoId("_WIXvYBQ9EeOKWo1NF21OVw")]
    [DisplayName("Reinvestment Percentage")]
    [IsoXmlTag("RinvstmtPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ReinvestmentPercentage { get; init; }
}
