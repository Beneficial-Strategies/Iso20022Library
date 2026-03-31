// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Definition of absolute price move of a financial instrument.
/// </summary>
[IsoId("_oHfs8MBmEeak3I7j2hsibw")]
[DisplayName("Absolute")]
public record Absolute1
{
    /// <summary>
    /// Unit of measure for the absolute stress.
    /// </summary>
    [IsoId("_wwCQEMBmEeak3I7j2hsibw")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Unit { get; init; }

    /// <summary>
    /// Number of units of measure shifted.
    /// </summary>
    [IsoId("_12l6MMBmEeak3I7j2hsibw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Quantity { get; init; }
}
