// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type providing further information on balance restrictions.
/// </summary>
[IsoId("_8H0BRqMgEeCJ6YNENx4h-w_-1462773614")]
[DisplayName("Balance Restriction Type")]
public record BalanceRestrictionType1
{
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    [IsoId("_8H0BR6MgEeCJ6YNENx4h-w_-1080256634")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GenericIdentification1 Type { get; init; }

    /// <summary>
    /// Description of the restriction.
    /// </summary>
    [IsoId("_8H0BSKMgEeCJ6YNENx4h-w_1112293165")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// Classification of the type of processing restriction that the system should apply for the restriction.
    /// </summary>
    [IsoId("_8H0BSaMgEeCJ6YNENx4h-w_-1123411091")]
    [DisplayName("Processing Type")]
    [IsoXmlTag("PrcgTp")]
    public ProcessingType1Choice_? ProcessingType { get; init; }
}
