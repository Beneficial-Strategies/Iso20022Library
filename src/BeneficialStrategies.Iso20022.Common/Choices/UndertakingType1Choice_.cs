// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the undertaking type.
    /// </summary>
    [KnownType(typeof(UndertakingType1Choice.Code))]
    [KnownType(typeof(UndertakingType1Choice.Proprietary))]
    [JsonDerivedType(typeof(UndertakingType1Choice.Code), nameof(UndertakingType1Choice.Code))]
    [JsonDerivedType(
        typeof(UndertakingType1Choice.Proprietary),
        nameof(UndertakingType1Choice.Proprietary)
    )]
    [IsoId("_92qY6HltEeG7BsjMvd1mEw_72990354")]
    [DisplayName("Undertaking Type 1 Choice")]
    public abstract record UndertakingType1Choice_ { }
}
