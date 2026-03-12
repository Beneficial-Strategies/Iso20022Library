// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the rate.
    /// </summary>
    [KnownType(typeof(RateType5Choice.Code))]
    [KnownType(typeof(RateType5Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType5Choice.Code),nameof(RateType5Choice.Code))]
    [JsonDerivedType(typeof(RateType5Choice.Proprietary),nameof(RateType5Choice.Proprietary))]
    [IsoId("_Quh39Np-Ed-ak6NoX_4Aeg_996830238")]
    [DisplayName("Rate Type 5 Choice")]
    public abstract partial record RateType5Choice_
    {
    }
}
