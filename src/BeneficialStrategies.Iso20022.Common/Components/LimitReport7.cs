// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the risk management limit or on a business error.
/// </summary>
[IsoId("_DAtgZ24-EeiU9cctagi5ow")]
[DisplayName("Limit Report")]
public record LimitReport7
{
    /// <summary>
    /// Identification of the limit on which information is requested.
    /// </summary>
    [IsoId("_DMyNg24-EeiU9cctagi5ow")]
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification5 LimitIdentification { get; init; }

    /// <summary>
    /// Requested information on the limit or business error report when information has not been found.
    /// </summary>
    [IsoId("_DMyNhW4-EeiU9cctagi5ow")]
    [DisplayName("Limit Or Error")]
    [IsoXmlTag("LmtOrErr")]
    public required LimitOrError4Choice_ LimitOrError { get; init; }
}
