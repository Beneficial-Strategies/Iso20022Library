// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Gives the name and the reference of the query.
/// </summary>
[IsoId("_RIAu89p-Ed-ak6NoX_4Aeg_-1267402499")]
[DisplayName("Query Reference")]
public record QueryReference
{
    /// <summary>
    /// Unique and unambiguous identification of the query.
    /// </summary>
    [IsoXmlTag("QryRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Value { get; init; }

    /// <summary>
    /// Name of the query.
    /// </summary>
    [IsoId("_RIAu9dp-Ed-ak6NoX_4Aeg_-1267402498")]
    [DisplayName("Query Name")]
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryName { get; init; }
}
