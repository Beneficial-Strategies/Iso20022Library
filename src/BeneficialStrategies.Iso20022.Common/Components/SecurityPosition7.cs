// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the securities for which the meeting is organised.
/// </summary>
[IsoId("_QSNvYtp-Ed-ak6NoX_4Aeg_-517737874")]
[DisplayName("Security Position")]
public record SecurityPosition7
{
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_QSNvY9p-Ed-ak6NoX_4Aeg_960778354")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification11 Identification { get; init; }

    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    [IsoId("_QSNvZNp-Ed-ak6NoX_4Aeg_1347603459")]
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<EligiblePosition4> Position { get; init; } = [];
}
