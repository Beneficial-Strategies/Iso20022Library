// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital Token Amount3.
/// </summary>
[IsoId("_jxqSYUj3Ee-KhcStGV4xTg")]
[DisplayName("Digital Token Amount3")]
public partial record DigitalTokenAmount3
{
    #nullable enable

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax30Text? Description { get; init; } 

    /// <summary>
    /// Identifier.
    /// </summary>
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    public IsoDTI2024Identifier? Identifier { get; init; } 

    /// <summary>
    /// Unit.
    /// </summary>
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public required IsoMax30DecimalNumber Unit { get; init; } 

    
    #nullable disable
    
}
