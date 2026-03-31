// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addition of a new element.
/// </summary>
[IsoId("_RbYW4Np-Ed-ak6NoX_4Aeg_-262227221")]
[DisplayName("Addition")]
public record Addition2
{
    /// <summary>
    /// Content of the new element.
    /// </summary>
    [IsoId("_RbYW4dp-Ed-ak6NoX_4Aeg_-262227190")]
    [DisplayName("Proposed Value")]
    [IsoXmlTag("PropsdVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? ProposedValue { get; init; }
}
