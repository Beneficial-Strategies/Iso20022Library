// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType28Choice.Code))]
    [KnownType(typeof(RateType28Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType28Choice.Code),nameof(RateType28Choice.Code))]
    [JsonDerivedType(typeof(RateType28Choice.Proprietary),nameof(RateType28Choice.Proprietary))]
    [IsoId("_qA9pECeGEeOXAt_43VmZGw")]
    [DisplayName("Rate Type 28 Choice")]
    public abstract partial record RateType28Choice_
    {
    }
}
