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
[IsoId("_kUX94dR7EemZdYGWu384Zw")]
[DisplayName("Compare Unit Price")]
public record CompareUnitPrice3
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_kYXtEdR7EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SecuritiesTransactionPrice11Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_kYXtE9R7EemZdYGWu384Zw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SecuritiesTransactionPrice11Choice_? Value2 { get; init; }
}
