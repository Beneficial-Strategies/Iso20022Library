// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security and its balance.
/// </summary>
[IsoId("_6G6_gfNlEeqRfth943bvEA")]
[DisplayName("Security Position")]
public record SecurityPosition13
{
    /// <summary>
    /// Identification of the security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_6bceA_NlEeqRfth943bvEA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    [IsoId("_6bceBfNlEeqRfth943bvEA")]
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<EligiblePosition10> Position { get; init; } = [];
}
