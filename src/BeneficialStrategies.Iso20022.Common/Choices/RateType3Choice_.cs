// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the rate.
    /// </summary>
    [KnownType(typeof(RateType3Choice.Code))]
    [KnownType(typeof(RateType3Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType3Choice.Code),nameof(RateType3Choice.Code))]
    [JsonDerivedType(typeof(RateType3Choice.Proprietary),nameof(RateType3Choice.Proprietary))]
    [IsoId("_RBJ5B9p-Ed-ak6NoX_4Aeg_811184279")]
    [DisplayName("Rate Type 3 Choice")]
    public abstract partial record RateType3Choice_
    {
    }
}
