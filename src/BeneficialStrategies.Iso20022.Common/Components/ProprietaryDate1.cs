// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Proprietary date information.
/// </summary>
[IsoId("_T6OX4Np-Ed-ak6NoX_4Aeg_325670124")]
[DisplayName("Proprietary Date")]
public record ProprietaryDate1
{
    /// <summary>
    /// Identifies the type of date reported.
    /// </summary>
    [IsoId("_T6OX4dp-Ed-ak6NoX_4Aeg_325670142")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_T6OX4tp-Ed-ak6NoX_4Aeg_325670167")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; }

    /// <summary>
    /// Date and time in ISO format.
    /// </summary>
    [IsoId("_T6OX49p-Ed-ak6NoX_4Aeg_597188315")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTime { get; init; }
}
