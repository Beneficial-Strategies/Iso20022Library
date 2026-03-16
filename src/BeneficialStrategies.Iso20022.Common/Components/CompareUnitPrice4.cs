// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a unit price.
/// </summary>
[IsoId("_cwwqkX2NEeu06pdEjSxE5g")]
[DisplayName("Compare Unit Price")]
public record CompareUnitPrice4
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_cyAnwX2NEeu06pdEjSxE5g")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SecuritiesTransactionPrice17Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_cyAnw32NEeu06pdEjSxE5g")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SecuritiesTransactionPrice17Choice_? Value2 { get; init; }
}
