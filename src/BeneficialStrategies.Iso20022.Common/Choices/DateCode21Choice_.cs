// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a date code.
    /// </summary>
    [KnownType(typeof(DateCode21Choice.Code))]
    [KnownType(typeof(DateCode21Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode21Choice.Code), nameof(DateCode21Choice.Code))]
    [JsonDerivedType(typeof(DateCode21Choice.Proprietary), nameof(DateCode21Choice.Proprietary))]
    [IsoId("_btDb-0ENEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code 21 Choice")]
    public abstract record DateCode21Choice_ { }
}
