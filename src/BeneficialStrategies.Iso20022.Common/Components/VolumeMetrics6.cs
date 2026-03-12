// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numeric variables calculated on the number of transactions or on market exposures.
/// </summary>
[IsoId("_HPOrga5QEeuo-IflVgGqiA")]
[DisplayName("Volume Metrics")]
public partial record VolumeMetrics6
{
    #nullable enable
    
    /// <summary>
    /// Aggregations of all positive values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_Hd-5Ma5QEeuo-IflVgGqiA")]
    [DisplayName("Positive")]
    [IsoXmlTag("Postv")]
    public ExposureMetrics5? Positive { get; init; } 
    
    /// <summary>
    /// Aggregations of all negative values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_Hd-5M65QEeuo-IflVgGqiA")]
    [DisplayName("Negative")]
    [IsoXmlTag("Neg")]
    public ExposureMetrics5? Negative { get; init; } 
    
    
    #nullable disable
    
}
