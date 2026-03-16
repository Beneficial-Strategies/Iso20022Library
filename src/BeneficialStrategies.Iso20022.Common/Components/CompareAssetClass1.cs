// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a asset class.
/// </summary>
[IsoId("_C-fncExDEeywvc16MwOPfw")]
[DisplayName("Compare Asset Class")]
public record CompareAssetClass1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_MaGmQExDEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public ProductType4Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_Oz7kYExDEeywvc16MwOPfw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public ProductType4Code? Value2 { get; init; }
}
