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
[IsoId("_dwup07QXEeeKRKrD60ELBQ")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate63
{
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_d_5uI7QXEeeKRKrD60ELBQ")]
    [DisplayName("Record Date")]
    [IsoXmlTag("RcrdDt")]
    public DateFormat43Choice_? RecordDate { get; init; }

    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_d_5uK7QXEeeKRKrD60ELBQ")]
    [DisplayName("Ex Dividend Date")]
    [IsoXmlTag("ExDvddDt")]
    public DateFormat43Choice_? ExDividendDate { get; init; }

    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_d_5uM7QXEeeKRKrD60ELBQ")]
    [DisplayName("Lottery Date")]
    [IsoXmlTag("LtryDt")]
    public DateFormat43Choice_? LotteryDate { get; init; }
}
