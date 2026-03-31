// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Property Component1.
/// </summary>
[IsoId("_8zqmEJ2gEe-4seDr3Li2Ew")]
[DisplayName("ATM Property Component1")]
public record ATMPropertyComponent1
{
    /// <summary>
    /// Property Name.
    /// </summary>
    [DisplayName("Property Name")]
    [IsoXmlTag("PrprtyNm")]
    public required IsoMax70Text PropertyName { get; init; }

    /// <summary>
    /// Property Type.
    /// </summary>
    [DisplayName("Property Type")]
    [IsoXmlTag("PrprtyTp")]
    public ATMPropertyType1Code? PropertyType { get; init; }

    /// <summary>
    /// Property Value.
    /// </summary>
    [DisplayName("Property Value")]
    [IsoXmlTag("PrprtyVal")]
    public required IsoMax2000Text PropertyValue { get; init; }
}
