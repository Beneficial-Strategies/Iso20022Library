// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Presence condition of a message item.
/// </summary>
[IsoId("_NEF-EXDxEe2MCaKO5AtGsA")]
[DisplayName("Message Item Condition")]
public record MessageItemCondition2
{
    /// <summary>
    /// Unique identification of the message and the message item.
    /// </summary>
    [IsoId("_NLeYcXDxEe2MCaKO5AtGsA")]
    [DisplayName("Item Identification")]
    [IsoXmlTag("ItmId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text ItemIdentification { get; init; }

    /// <summary>
    /// Condition of presence of the message item.
    /// </summary>
    [IsoId("_NLeYc3DxEe2MCaKO5AtGsA")]
    [DisplayName("Condition")]
    [IsoXmlTag("Cond")]
    public required MessageItemCondition2Code Condition { get; init; }

    /// <summary>
    /// Value to be used for the message item.
    /// </summary>
    [IsoId("_NLeYdXDxEe2MCaKO5AtGsA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public SimpleValueList<IsoMax140Text> Value { get; init; } = [];
}
