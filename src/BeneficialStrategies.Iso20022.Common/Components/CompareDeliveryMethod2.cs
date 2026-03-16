// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a collateral delivery method.
/// </summary>
[IsoId("_Ap1b8dSaEemZdYGWu384Zw")]
[DisplayName("Compare Delivery Method")]
public record CompareDeliveryMethod2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_AvjCYdSaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public CollateralDeliveryMethod1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_AvjCY9SaEemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public CollateralDeliveryMethod1Code? Value2 { get; init; }
}
