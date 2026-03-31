// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a party identification or account identification.
/// </summary>
[IsoId("_P_luWNp-Ed-ak6NoX_4Aeg_618188227")]
[DisplayName("Simple Identification Information")]
public record SimpleIdentificationInformation2
{
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_P_u4QNp-Ed-ak6NoX_4Aeg_618188642")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max34Text)]
    [StringLength(maximumLength: 34, MinimumLength = 1)]
    public required IsoMax34Text Identification { get; init; }
}
