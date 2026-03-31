// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the formats to express a date and time.
    /// </summary>
    [KnownType(typeof(DateFormat2Choice.Date))]
    [KnownType(typeof(DateFormat2Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat2Choice.Date), nameof(DateFormat2Choice.Date))]
    [JsonDerivedType(typeof(DateFormat2Choice.DateCode), nameof(DateFormat2Choice.DateCode))]
    [IsoId("_RVH96Np-Ed-ak6NoX_4Aeg_1196051260")]
    [DisplayName("Date Format 2 Choice")]
    public abstract record DateFormat2Choice_ { }
}
