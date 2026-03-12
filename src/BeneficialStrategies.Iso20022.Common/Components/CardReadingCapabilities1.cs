// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card reading capability of the terminal performing the transaction.
/// </summary>
[IsoId("_V4weYTEuEeyjbpgZW6G1Fg")]
[DisplayName("Card Reading Capabilities")]
public partial record CardReadingCapabilities1
{
    #nullable enable
    
    /// <summary>
    /// Card reading capability of the terminal performing the transaction.
    /// </summary>
    [IsoId("_V-xm0TEuEeyjbpgZW6G1Fg")]
    [DisplayName("Capability")]
    [IsoXmlTag("Cpblty")]
    public required CardDataReading10Code Capability { get; init; } 
    
    /// <summary>
    /// Other types of card data reading capabilities.
    /// </summary>
    [IsoId("_V-xm0zEuEeyjbpgZW6G1Fg")]
    [DisplayName("Other Capability")]
    [IsoXmlTag("OthrCpblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherCapability { get; init; } 
    
    
    #nullable disable
    
}
