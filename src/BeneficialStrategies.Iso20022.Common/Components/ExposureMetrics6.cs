// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on market exposures.
/// </summary>
[IsoId("_zg_J065QEeuo-IflVgGqiA")]
[DisplayName("Exposure Metrics")]
public partial record ExposureMetrics6
{
    #nullable enable
    
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    [IsoId("_zwe-Ya5QEeuo-IflVgGqiA")]
    [DisplayName("Posted Margin Or Collateral")]
    [IsoXmlTag("PstdMrgnOrColl")]
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; } 
    
    
    #nullable disable
    
}
