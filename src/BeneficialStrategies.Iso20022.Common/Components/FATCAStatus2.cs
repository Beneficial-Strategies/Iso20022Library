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
[IsoId("_2joGwSCVEeWJd9HF2tO7BA")]
[DisplayName("FATCA Status")]
public partial record FATCAStatus2
{
    #nullable enable
    
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [IsoId("_2_cgESCVEeWJd9HF2tO7BA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FATCAStatus2Choice_ Type { get; init; } 
    
    /// <summary>
    /// Source of the Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [IsoId("_2_cgEyCVEeWJd9HF2tO7BA")]
    [DisplayName("Source")]
    [IsoXmlTag("Src")]
    public FATCASource1Choice_? Source { get; init; } 
    
    
    #nullable disable
    
}
