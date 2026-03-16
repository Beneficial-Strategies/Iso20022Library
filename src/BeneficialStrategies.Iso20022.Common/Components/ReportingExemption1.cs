// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reporting exemption of a counterparty.
/// </summary>
[IsoId("_F10woBaIEe27wrM4RUjLog")]
[DisplayName("Reporting Exemption")]
public record ReportingExemption1
{
    /// <summary>
    /// Code specifying exemption applicable to a counterparty.
    /// </summary>
    [IsoId("_VXP3IBaIEe27wrM4RUjLog")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4Text Reason { get; init; }

    /// <summary>
    /// Textual description of applicable exemption.
    /// </summary>
    [IsoId("_afNPcBaIEe27wrM4RUjLog")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? Description { get; init; }
}
