// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Independent amount could be defined at a trade level or portfolio level. It is assumed that their treatment will be based on the exposure convention that is whether netted together or treated on a gross basis.
/// </summary>
[IsoId("_UlI9I9p-Ed-ak6NoX_4Aeg_1735271850")]
[DisplayName("Aggregated Independent Amount")]
public record AggregatedIndependentAmount1
{
    /// <summary>
    /// Total independent amount defined in the confirmations of individual trades.
    /// </summary>
    [IsoId("_UlI9JNp-Ed-ak6NoX_4Aeg_-1821696591")]
    [DisplayName("Trade")]
    [IsoXmlTag("Trad")]
    public IndependentAmount1? Trade { get; init; }

    /// <summary>
    /// Portfolio level independent amount that reflects portfolio change over a short time period using statistical techniques such as volatility and risk factor correlations.
    /// </summary>
    [IsoId("_UlI9Jdp-Ed-ak6NoX_4Aeg_1452502446")]
    [DisplayName("Value At Risk")]
    [IsoXmlTag("ValAtRsk")]
    public IndependentAmount1? ValueAtRisk { get; init; }

    /// <summary>
    /// Portfolio level independent amount related to parties net open position. Net open position means the total of the net long FX and the net options in respect of each currency where: net long FX for any currency shall be the net amount (if any) of that currency which the party “A” is long as against party “B” in respect of all FX transactions.
    /// </summary>
    [IsoId("_UlI9Jtp-Ed-ak6NoX_4Aeg_1859006819")]
    [DisplayName("Net Open Position")]
    [IsoXmlTag("NetOpnPos")]
    public IndependentAmount1? NetOpenPosition { get; init; }

    /// <summary>
    /// Any other amount that should be considered to calculate the independent amount.
    /// </summary>
    [IsoId("_UlI9J9p-Ed-ak6NoX_4Aeg_-928458678")]
    [DisplayName("Other Amount")]
    [IsoXmlTag("OthrAmt")]
    public ValueList<IndependentAmount2> OtherAmount { get; init; } = [];
}
