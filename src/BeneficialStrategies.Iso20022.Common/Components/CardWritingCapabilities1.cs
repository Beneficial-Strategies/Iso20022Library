// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card writing capability of the terminal performing the transaction.
/// </summary>
[IsoId("_BQxRQTEvEeyjbpgZW6G1Fg")]
[DisplayName("Card Writing Capabilities")]
public partial record CardWritingCapabilities1
{
    #nullable enable
    
    /// <summary>
    /// Card writing capability of the terminal performing the transaction.
    /// </summary>
    [IsoId("_BWRcUTEvEeyjbpgZW6G1Fg")]
    [DisplayName("Capability")]
    [IsoXmlTag("Cpblty")]
    public required CardDataWriting1Code Capability { get; init; } 
    
    /// <summary>
    /// Other types of card data writing capabilities.
    /// </summary>
    [IsoId("_BWRcXzEvEeyjbpgZW6G1Fg")]
    [DisplayName("Other Capability")]
    [IsoXmlTag("OthrCpblty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherCapability { get; init; } 
    
    
    #nullable disable
    
}
