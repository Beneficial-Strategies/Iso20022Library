// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of price type.
    /// </summary>
    [KnownType(typeof(PriceType2Choice.Market))]
    [KnownType(typeof(PriceType2Choice.Indicative))]
    [JsonDerivedType(typeof(PriceType2Choice.Market),nameof(PriceType2Choice.Market))]
    [JsonDerivedType(typeof(PriceType2Choice.Indicative),nameof(PriceType2Choice.Indicative))]
    [IsoId("_XLcRBdp-Ed-ak6NoX_4Aeg_-173872087")]
    [DisplayName("Price Type 2 Choice")]
    public abstract partial record PriceType2Choice_
    {
    }
}
