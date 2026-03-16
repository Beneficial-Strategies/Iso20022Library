// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine a date format.
    /// </summary>
    [KnownType(typeof(Date2Choice.Code))]
    [KnownType(typeof(Date2Choice.Proprietary))]
    [JsonDerivedType(typeof(Date2Choice.Code), nameof(Date2Choice.Code))]
    [JsonDerivedType(typeof(Date2Choice.Proprietary), nameof(Date2Choice.Proprietary))]
    [IsoId("_UdW4MNopEeCWg-hsBVGrDA_1543925499")]
    [DisplayName("Date 2 Choice")]
    public abstract record Date2Choice_ { }
}
