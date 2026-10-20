// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital Token Amount3.
/// </summary>
[IsoId("_jxqSYUj3Ee-KhcStGV4xTg")]
[DisplayName("Digital Token Amount3")]
public partial record DigitalTokenAmount3
{
    /// <summary>
    /// Identifier.
    /// </summary>
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    public DTI2024Identifier? Identifier { get; init; }

    /// <summary>
    /// Unit.
    /// </summary>
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public required Max30DecimalNumber Unit { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public Max30Text? Description { get; init; }
}
