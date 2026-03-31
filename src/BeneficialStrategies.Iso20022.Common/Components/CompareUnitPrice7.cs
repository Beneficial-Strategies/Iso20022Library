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
[IsoId("_72GXoU0iEeyQkYR0RbXyEg")]
[DisplayName("Compare Unit Price")]
public record CompareUnitPrice7
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_735uc00iEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public SecuritiesTransactionPrice14Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_735udU0iEeyQkYR0RbXyEg")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public SecuritiesTransactionPrice14Choice_? Value2 { get; init; }
}
