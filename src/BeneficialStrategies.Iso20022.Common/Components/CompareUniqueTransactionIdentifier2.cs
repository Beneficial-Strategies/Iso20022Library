// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a Transaction Identifier.
/// </summary>
[IsoId("_Bil10TAvEe2Ne600gC45nw")]
[DisplayName("Compare Unique Transaction Identifier")]
public record CompareUniqueTransactionIdentifier2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_BjjfITAvEe2Ne600gC45nw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public UniqueTransactionIdentifier2Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_BjjfIzAvEe2Ne600gC45nw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public UniqueTransactionIdentifier2Choice_? Value2 { get; init; }
}
