// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
/// </summary>
[IsoId("_RKFyldp-Ed-ak6NoX_4Aeg_-1294803117")]
[DisplayName("User Defined Information")]
public record UserDefinedInformation1
{
    /// <summary>
    /// Identifies the nature of the user information.
    /// </summary>
    [IsoId("_RKFyltp-Ed-ak6NoX_4Aeg_-1252319958")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Label { get; init; }

    /// <summary>
    /// Specifies the content of the user information.
    /// </summary>
    [IsoId("_RKFyl9p-Ed-ak6NoX_4Aeg_-978956797")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Information { get; init; }
}
