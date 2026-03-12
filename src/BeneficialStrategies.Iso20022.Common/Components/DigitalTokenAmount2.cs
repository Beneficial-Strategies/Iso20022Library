// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the amount for a digital token identifier.
/// </summary>
[IsoId("_c10zYZivEe2f7NHvXATP5g")]
[DisplayName("Digital Token Amount")]
public partial record DigitalTokenAmount2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the digital token identifier (DTI).
    /// </summary>
    [IsoId("_c4uWY5ivEe2f7NHvXATP5g")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.DTI2021Identifier)]
    public required IsoDTI2021Identifier Identifier { get; init; } 
    
    /// <summary>
    /// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
    /// </summary>
    [IsoId("_c4uWZZivEe2f7NHvXATP5g")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.Max30DecimalNumber)]
    public IsoMax30DecimalNumber? Unit { get; init; } 
    
    /// <summary>
    /// Provides a description of the digital token identifier.
    /// </summary>
    [IsoId("_c4uWZ5ivEe2f7NHvXATP5g")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? Description { get; init; } 
    
    
    #nullable disable
    
}
