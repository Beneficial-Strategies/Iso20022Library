// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a trade clearing status.
/// </summary>
[IsoId("_WfLBoTAoEe2Ne600gC45nw")]
[DisplayName("Compare Trade Clearing Status")]
public record CompareTradeClearingStatus3
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_WgIq8TAoEe2Ne600gC45nw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public Cleared23Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_WgIq8zAoEe2Ne600gC45nw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public Cleared23Choice_? Value2 { get; init; }
}
