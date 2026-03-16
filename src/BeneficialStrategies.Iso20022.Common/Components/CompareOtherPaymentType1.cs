// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a other payment type.
/// </summary>
[IsoId("_2_WLcE0fEeyQkYR0RbXyEg")]
[DisplayName("Compare Other Payment Type")]
public record CompareOtherPaymentType1
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_A_8tsE0gEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public PaymentType5Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_E3oJ4E0gEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public PaymentType5Choice_? Value2 { get; init; }
}
