// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormat2Choice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormat2Choice.Country))]
    [KnownType(typeof(SafekeepingPlaceFormat2Choice.TypeAndIdentification))]
    [KnownType(typeof(SafekeepingPlaceFormat2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat2Choice.Identification),
        nameof(SafekeepingPlaceFormat2Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat2Choice.Country),
        nameof(SafekeepingPlaceFormat2Choice.Country)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat2Choice.TypeAndIdentification),
        nameof(SafekeepingPlaceFormat2Choice.TypeAndIdentification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormat2Choice.Proprietary),
        nameof(SafekeepingPlaceFormat2Choice.Proprietary)
    )]
    [IsoId("_SfVHNtp-Ed-ak6NoX_4Aeg_1791988633")]
    [DisplayName("Safekeeping Place Format 2 Choice")]
    public abstract record SafekeepingPlaceFormat2Choice_ { }
}
