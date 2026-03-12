// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Foreign Account Tax Compliance Act (FATCA) status information.
/// </summary>
[IsoId("_hc90MQjREeS5F6qHcKOrew")]
[DisplayName("FATCA Status")]
public partial record FATCAStatus1
{
    #nullable enable
    
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [IsoId("_o1L-8AjREeS5F6qHcKOrew")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FATCAStatus1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [IsoId("_thIJoAjREeS5F6qHcKOrew")]
    [DisplayName("Source")]
    [IsoXmlTag("Src")]
    public FATCASource1Choice_? Source { get; init; } 
    
    
    #nullable disable
    
}
