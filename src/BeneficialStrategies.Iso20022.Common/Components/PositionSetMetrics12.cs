// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variables used to quantify the different calculations for position sets.
/// </summary>
[IsoId("_oRNJEc9JEeubvZK8CMH-Eg")]
[DisplayName("Position Set Metrics")]
public partial record PositionSetMetrics12
{
    #nullable enable
    
    /// <summary>
    /// Numeric variables calculated on the number of transactions or on market exposures.
    /// </summary>
    [IsoId("_oTj5g89JEeubvZK8CMH-Eg")]
    [DisplayName("Volume Metrics")]
    [IsoXmlTag("VolMtrcs")]
    public VolumeMetrics6? VolumeMetrics { get; init; } 
    
    /// <summary>
    /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
    /// </summary>
    [IsoId("_oTj5hc9JEeubvZK8CMH-Eg")]
    [DisplayName("Haircut Or Margin")]
    [IsoXmlTag("HrcutOrMrgn")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HaircutOrMargin { get; init; } 
    
    /// <summary>
    /// Quantity of the securities other than bonds.
    /// </summary>
    [IsoId("_oTj5h89JEeubvZK8CMH-Eg")]
    [DisplayName("Quantity Or Nominal Amount")]
    [IsoXmlTag("QtyOrNmnlAmt")]
    public QuantityNominalValue2Choice_? QuantityOrNominalAmount { get; init; } 
    
    
    #nullable disable
    
}
