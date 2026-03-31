// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Order Report2Choice.
    /// </summary>
    [KnownType(typeof(OrderReport2Choice.Cancellation))]
    [KnownType(typeof(OrderReport2Choice.New))]
    [JsonDerivedType(
        typeof(OrderReport2Choice.Cancellation),
        nameof(OrderReport2Choice.Cancellation)
    )]
    [JsonDerivedType(typeof(OrderReport2Choice.New), nameof(OrderReport2Choice.New))]
    [IsoId("_nyySARAVEe6N57R8Wekj-w")]
    [DisplayName("Order Report2Choice")]
    public abstract record OrderReport2Choice_ { }
}
