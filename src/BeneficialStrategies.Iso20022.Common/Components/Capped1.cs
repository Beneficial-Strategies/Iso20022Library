// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a capped drawdown.
/// </summary>
[IsoId("_56qUIFNdEeijdq8ilaxyOA")]
[DisplayName("Capped")]
public record Capped1
{
    /// <summary>
    /// Start date of current reference period
    /// </summary>
    [IsoId("_EkpKkFNeEeijdq8ilaxyOA")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Income limit for the current period.
    /// </summary>
    [IsoId("_K4H60FNeEeijdq8ilaxyOA")]
    [DisplayName("Income Limit Current Period")]
    [IsoXmlTag("IncmLmtCurPrd")]
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitCurrentPeriod { get; init; }

    /// <summary>
    /// Income taken in the current income year.
    /// </summary>
    [IsoId("_OwkzEFNeEeijdq8ilaxyOA")]
    [DisplayName("Income Current Period")]
    [IsoXmlTag("IncmCurPrd")]
    public ActiveCurrencyAnd13DecimalAmount? IncomeCurrentPeriod { get; init; }

    /// <summary>
    /// Income limit for the next income year.
    /// </summary>
    [IsoId("_S8XeEFNeEeijdq8ilaxyOA")]
    [DisplayName("Income Limit Next Period")]
    [IsoXmlTag("IncmLmtNxtPrd")]
    public ActiveCurrencyAnd13DecimalAmount? IncomeLimitNextPeriod { get; init; }

    /// <summary>
    /// Additional information about the cap.
    /// </summary>
    [IsoId("_LqU3YZC1EeiQvr1XXv37hw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
