// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates date and value at which the floating reference rate was reset.
/// </summary>
[IsoId("_uPjD8CReEe2VuKUpJ7HXPg")]
[DisplayName("Reset Date And Value")]
public partial record ResetDateAndValue1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the most recent date at which the floating reference rate was reset.
    /// </summary>
    [IsoId("_Af_VcSRfEe2VuKUpJ7HXPg")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; } 
    
    /// <summary>
    /// Indicates the most recent value at which the floating reference rate was reset.
    /// </summary>
    [IsoId("_F6PXoSRfEe2VuKUpJ7HXPg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? Value { get; init; } 
    
    
    #nullable disable
    
}
