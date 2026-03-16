// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deletion of the current element.
/// </summary>
[IsoId("_RbYW5dp-Ed-ak6NoX_4Aeg_109024765")]
[DisplayName("Deletion")]
public record Deletion2
{
    /// <summary>
    /// Content of the deleted element.
    /// </summary>
    [IsoId("_RbYW5tp-Ed-ak6NoX_4Aeg_109024767")]
    [DisplayName("Deleted Value")]
    [IsoXmlTag("DeltdVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? DeletedValue { get; init; }
}
