// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an notional amount.
/// </summary>
[IsoId("_gxGaEWEgEe2P-L9DBerEgA")]
[DisplayName("Compare Notional Amount")]
public record CompareNotionalAmount1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_gyBAEWEgEe2P-L9DBerEgA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public NotionalAmount6? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_gyBAE2EgEe2P-L9DBerEgA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public NotionalAmount6? Value2 { get; init; }
}
