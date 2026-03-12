// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_fGU5MRrdEeOVR9VN6fAMUg")]
[DisplayName("Charges Details")]
public partial record ChargesDetails3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of charges as a code or free text.
    /// </summary>
    [IsoId("_Hl77kBreEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargesType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Specifies if it is a fixed amount or a percentage.
    /// </summary>
    [IsoId("_UqVmABreEeOVR9VN6fAMUg")]
    [DisplayName("Amount Or Percentage")]
    [IsoXmlTag("AmtOrPctg")]
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; } 
    
    
    #nullable disable
    
}
