// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the price type.
    /// </summary>
    [KnownType(typeof(UnitPriceType2Choice.Code))]
    [KnownType(typeof(UnitPriceType2Choice.Proprietary))]
    [JsonDerivedType(typeof(UnitPriceType2Choice.Code), nameof(UnitPriceType2Choice.Code))]
    [JsonDerivedType(
        typeof(UnitPriceType2Choice.Proprietary),
        nameof(UnitPriceType2Choice.Proprietary)
    )]
    [IsoId("_N23jAQc_EeSyIPzOZ6VzBQ")]
    [DisplayName("Unit Price Type 2 Choice")]
    public abstract record UnitPriceType2Choice_ { }
}
