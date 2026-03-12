// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate is expressed as a percentage or a text.
    /// </summary>
    [KnownType(typeof(RateTypeChoice.PercentageRate))]
    [KnownType(typeof(RateTypeChoice.TextualRate))]
    [JsonDerivedType(typeof(RateTypeChoice.PercentageRate),nameof(RateTypeChoice.PercentageRate))]
    [JsonDerivedType(typeof(RateTypeChoice.TextualRate),nameof(RateTypeChoice.TextualRate))]
    [IsoId("_RIwV0dp-Ed-ak6NoX_4Aeg_-1267403783")]
    [DisplayName("Rate Type Choice")]
    public abstract partial record RateTypeChoice_
    {
    }
}
