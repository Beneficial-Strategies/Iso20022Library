// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of result of a volume capping.
/// </summary>
[IsoId("_U7tWsJuJEeaPcol5ibnfBQ")]
[DisplayName("Volume Cap Result")]
public record VolumeCapResult1
{
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_9ch6AJuJEeaPcol5ibnfBQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public required IsoISINOct2015Identifier Identification { get; init; }

    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    [IsoId("_FV0KcJuKEeaPcol5ibnfBQ")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required Period4Choice_ ReportingPeriod { get; init; }

    /// <summary>
    /// Last date for which the data was updated for this instrument and reporting period.
    /// </summary>
    [IsoId("_LBukYJuKEeaPcol5ibnfBQ")]
    [DisplayName("Last Update Date")]
    [IsoXmlTag("LastUpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LastUpdateDate { get; init; }

    /// <summary>
    /// Total traded volume of the instrument in this specific reporting period.
    /// </summary>
    [IsoId("_V17t0JuKEeaPcol5ibnfBQ")]
    [DisplayName("Total Trading Volume")]
    [IsoXmlTag("TtlTradgVol")]
    public required ActiveCurrencyAndAmount TotalTradingVolume { get; init; }

    /// <summary>
    /// Total percentage of trading under waiver of the instrument in this specific reporting period.
    /// </summary>
    [IsoId("_6AHBAJuKEeaPcol5ibnfBQ")]
    [DisplayName("Trading Under Waiver Percentage")]
    [IsoXmlTag("TradgUdrWvrPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate TradingUnderWaiverPercentage { get; init; }

    /// <summary>
    /// Percentage of trading under waiver of the instrument in this specific reporting period broken down by trading venue.
    /// </summary>
    [IsoId("_dyll4JuLEeaPcol5ibnfBQ")]
    [DisplayName("Trading Under Waiver Breakdown")]
    [IsoXmlTag("TradgUdrWvrBrkdwn")]
    public ValueList<TradingUnderWaiversPercentage1> TradingUnderWaiverBreakdown { get; init; } =
        [];

    /// <summary>
    /// Information for interpreting the result.
    /// </summary>
    [IsoId("_JNG6MJuMEeaPcol5ibnfBQ")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Disclaimer { get; init; }
}
