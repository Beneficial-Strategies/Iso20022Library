// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a derivative event.
/// </summary>
[IsoId("_GaCT4TIGEe2fXedS_ucFOA")]
[DisplayName("Compare Derivative Event")]
public record CompareDerivativeEvent1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_Ga2MMTIGEe2fXedS_ucFOA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public DerivativeEvent6? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_Ga2MMzIGEe2fXedS_ucFOA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public DerivativeEvent6? Value2 { get; init; }
}
