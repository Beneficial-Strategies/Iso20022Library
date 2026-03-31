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
[IsoId("_QTaCNdp-Ed-ak6NoX_4Aeg_-582916783")]
[DisplayName("Security Position")]
public record SecurityPosition6
{
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_QTaCNtp-Ed-ak6NoX_4Aeg_-446236804")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification11 Identification { get; init; }

    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    [IsoId("_QTaCN9p-Ed-ak6NoX_4Aeg_-858516755")]
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<EligiblePosition3> Position { get; init; } = [];
}
