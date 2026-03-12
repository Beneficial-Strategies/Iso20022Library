// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between search criteria based on dates and date ranges.
    /// </summary>
    [KnownType(typeof(DateTimeSearch2Choice.FromDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.ToDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.FromToDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.EqualDateTime))]
    [KnownType(typeof(DateTimeSearch2Choice.NotEqualDateTime))]
    [JsonDerivedType(typeof(DateTimeSearch2Choice.FromDateTime),nameof(DateTimeSearch2Choice.FromDateTime))]
    [JsonDerivedType(typeof(DateTimeSearch2Choice.ToDateTime),nameof(DateTimeSearch2Choice.ToDateTime))]
    [JsonDerivedType(typeof(DateTimeSearch2Choice.FromToDateTime),nameof(DateTimeSearch2Choice.FromToDateTime))]
    [JsonDerivedType(typeof(DateTimeSearch2Choice.EqualDateTime),nameof(DateTimeSearch2Choice.EqualDateTime))]
    [JsonDerivedType(typeof(DateTimeSearch2Choice.NotEqualDateTime),nameof(DateTimeSearch2Choice.NotEqualDateTime))]
    [IsoId("_68F8RX3sEeibM9CPDGCw0g")]
    [DisplayName("Date Time Search 2 Choice")]
    public abstract partial record DateTimeSearch2Choice_
    {
    }
}
