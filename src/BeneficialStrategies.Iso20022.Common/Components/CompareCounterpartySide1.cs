// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a counterparty side.
/// </summary>
[IsoId("_wx_KQKxcEem81-uIvTF5rQ")]
[DisplayName("Compare Counterparty Side")]
public record CompareCounterpartySide1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_317uIKxcEem81-uIvTF5rQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public CollateralRole1Code? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_4313EKxcEem81-uIvTF5rQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public CollateralRole1Code? Value2 { get; init; }
}
