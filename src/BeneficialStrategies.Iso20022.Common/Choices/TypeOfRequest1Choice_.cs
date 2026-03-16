// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a type of request.
    /// </summary>
    [KnownType(typeof(TypeOfRequest1Choice.Code))]
    [KnownType(typeof(TypeOfRequest1Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfRequest1Choice.Code), nameof(TypeOfRequest1Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfRequest1Choice.Proprietary),
        nameof(TypeOfRequest1Choice.Proprietary)
    )]
    [IsoId("_wZdgANvdEeqxGfKJubfhIw")]
    [DisplayName("Type Of Request 1 Choice")]
    public abstract record TypeOfRequest1Choice_ { }
}
