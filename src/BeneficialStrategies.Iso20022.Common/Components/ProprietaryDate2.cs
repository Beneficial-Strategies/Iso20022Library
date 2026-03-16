// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a proprietary date.
/// </summary>
[IsoId("_T6YI4tp-Ed-ak6NoX_4Aeg_225663436")]
[DisplayName("Proprietary Date")]
public record ProprietaryDate2
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_T6YI49p-Ed-ak6NoX_4Aeg_225663466")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_T6YI5Np-Ed-ak6NoX_4Aeg_225663497")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required DateAndDateTimeChoice_ Date { get; init; }
}
