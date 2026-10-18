// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <inheritdoc cref="IDateAndDateTime2Choice"/>
    [KnownType(typeof(DateAndDateTime2Choice.Date))]
    [KnownType(typeof(DateAndDateTime2Choice.DateTime))]
    [JsonDerivedType(typeof(DateAndDateTime2Choice.Date), nameof(DateAndDateTime2Choice.Date))]
    [JsonDerivedType(
        typeof(DateAndDateTime2Choice.DateTime),
        nameof(DateAndDateTime2Choice.DateTime)
    )]
    [IsoId("_fGuzgZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Date And Date Time 2 Choice")]
    public abstract partial record DateAndDateTime2Choice_ { }
}
