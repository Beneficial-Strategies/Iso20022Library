// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType36Choice.Code))]
    [KnownType(typeof(RateType36Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType36Choice.Code),nameof(RateType36Choice.Code))]
    [JsonDerivedType(typeof(RateType36Choice.Proprietary),nameof(RateType36Choice.Proprietary))]
    [IsoId("_Oph4EUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type 36 Choice")]
    public abstract partial record RateType36Choice_
    {
    }
}
