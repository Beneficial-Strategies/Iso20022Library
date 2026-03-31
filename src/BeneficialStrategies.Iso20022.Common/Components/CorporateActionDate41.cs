// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_UqUT7VhsEeS5jeC8QHrlrg")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate41
{
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_VF1yQ1hsEeS5jeC8QHrlrg")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat19Choice_? RecordDate { get; init; }

    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_VF1yS1hsEeS5jeC8QHrlrg")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat19Choice_? ExDividendDate { get; init; }

    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_Z7AKZFhsEeS5jeC8QHrlrg")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat19Choice_? LotteryDate { get; init; }
}
