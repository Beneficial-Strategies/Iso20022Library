// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports on limits.
/// </summary>
[IsoId("_Q1IWJZlhEeeE1Ya-LgRsuQ")]
[DisplayName("Limits")]
public partial record Limits6
{
    #nullable enable
    
    /// <summary>
    /// Report is given for a current risk management type limit.
    /// </summary>
    [IsoId("_RDVxQ5lhEeeE1Ya-LgRsuQ")]
    [DisplayName("Current Limit")]
    [IsoXmlTag("CurLmt")]
    public LimitReport6? CurrentLimit { get; init; } 
    
    /// <summary>
    /// Report is given for a default risk management type limit.
    /// </summary>
    [IsoId("_RDVxRZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Default Limit")]
    [IsoXmlTag("DfltLmt")]
    public LimitReport6? DefaultLimit { get; init; } 
    
    
    #nullable disable
    
}
