// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_ClxUsRrbEeOVR9VN6fAMUg")]
[DisplayName("Unit Price")]
public record UnitPrice18
{
    /// <summary>
    /// Specifies the unit price.
    /// </summary>
    [IsoId("_ITS4MBrbEeOVR9VN6fAMUg")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public required UnitOfMeasure3Choice_ UnitPrice { get; init; }

    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_C9KhBxrbEeOVR9VN6fAMUg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
    /// </summary>
    [IsoId("_C9KhCRrbEeOVR9VN6fAMUg")]
    [DisplayName("Factor")]
    [IsoXmlTag("Fctr")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? Factor { get; init; }
}
