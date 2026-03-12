// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency specific Factors.
/// </summary>
[IsoId("_SvDFDAEcEeCQm6a_G2yO_w_737045003")]
[DisplayName("Currency Factors")]
public partial record CurrencyFactors1
{
    #nullable enable
    
    /// <summary>
    /// Currency of the underlying currency specific amounts and ratios used in the pay-in schedule calculation.
    /// </summary>
    [IsoId("_SvDFDQEcEeCQm6a_G2yO_w_-1485086465")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Maximum allowed short position in the currency during settlement.
    /// </summary>
    [IsoId("_SvDFDgEcEeCQm6a_G2yO_w_243513360")]
    [DisplayName("Short Position Limit")]
    [IsoXmlTag("ShrtPosLmt")]
    public required ImpliedCurrencyAndAmount ShortPositionLimit { get; init; } 
    
    /// <summary>
    /// Minimum amount paid in one payment unless the short position is less than the minimum.
    /// </summary>
    [IsoId("_SvDFDwEcEeCQm6a_G2yO_w_151707201")]
    [DisplayName("Minimum Pay In Amount")]
    [IsoXmlTag("MinPayInAmt")]
    public required ImpliedCurrencyAndAmount MinimumPayInAmount { get; init; } 
    
    /// <summary>
    /// Margin used to decrease long positions and increase short positions during the risk calculation.
    /// </summary>
    [IsoId("_SvM2AAEcEeCQm6a_G2yO_w_-1119940583")]
    [DisplayName("Volatility Margin")]
    [IsoXmlTag("VoltlyMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate VolatilityMargin { get; init; } 
    
    /// <summary>
    /// Exchange rate used in the calculation of the pay-in schedule.
    /// </summary>
    [IsoId("_SvM2AQEcEeCQm6a_G2yO_w_948992700")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public AgreedRate2? Rate { get; init; } 
    
    
    #nullable disable
    
}
