// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a number of maximum 5 digits.
/// </summary>
[IsoId("_SY9-ASUOEeeDvf1E8-5blA")]
[DisplayName("Compare Number")]
public record CompareNumber2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_Sjw4wSUOEeeDvf1E8-5blA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    [IsoSimpleType(IsoSimpleType.Max5Number)]
    public required IsoMax5Number Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_Sjw4wyUOEeeDvf1E8-5blA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    [IsoSimpleType(IsoSimpleType.Max5Number)]
    public required IsoMax5Number Value2 { get; init; }
}
