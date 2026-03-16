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
[IsoId("_QT2uKNp-Ed-ak6NoX_4Aeg_583952553")]
[DisplayName("Security Position")]
public record SecurityPosition5
{
    /// <summary>
    /// Security held in an account on which the balance is calculated.
    /// </summary>
    [IsoId("_QT_4ENp-Ed-ak6NoX_4Aeg_583952562")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3 Identification { get; init; }

    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    [IsoId("_QT_4Edp-Ed-ak6NoX_4Aeg_1240575085")]
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<EligiblePosition2> Position { get; init; } = [];
}
