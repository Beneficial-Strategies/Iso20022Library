// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum data structure is applicable to certain merchant verticals that require industry-specific data within transaction messages.
/// </summary>
[IsoId("_D9gQgSX7Eeym0KcvJF9aDQ")]
[DisplayName("Addendum Data")]
public record AddendumData5
{
    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_EFGGQSX7Eeym0KcvJF9aDQ")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public Instalment4? Instalment { get; init; }

    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_EFGGQyX7Eeym0KcvJF9aDQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
