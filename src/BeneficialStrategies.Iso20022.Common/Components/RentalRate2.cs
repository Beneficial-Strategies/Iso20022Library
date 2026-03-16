// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rental Rate2.
/// </summary>
[IsoId("_sCARIZmhEe6Qpd-x8YgzaA")]
[DisplayName("Rental Rate2")]
public partial record RentalRate2
{
    #nullable enable

    /// <summary>
    /// Other Period.
    /// </summary>
    [DisplayName("Other Period")]
    [IsoXmlTag("OthrPrd")]
    public IsoMax35Text? OtherPeriod { get; init; } 

    /// <summary>
    /// Period.
    /// </summary>
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    public PeriodUnit4Code? Period { get; init; } 

    /// <summary>
    /// Period Count.
    /// </summary>
    [DisplayName("Period Count")]
    [IsoXmlTag("PrdCnt")]
    public IsoMax4NumericText? PeriodCount { get; init; } 

    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public ImpliedCurrencyAndAmount? Rate { get; init; } 

    
    #nullable disable
    
}
