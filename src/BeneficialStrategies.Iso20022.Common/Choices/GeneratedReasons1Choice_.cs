// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the generated reason.
    /// </summary>
    [KnownType(typeof(GeneratedReasons1Choice.Code))]
    [KnownType(typeof(GeneratedReasons1Choice.Proprietary))]
    [JsonDerivedType(typeof(GeneratedReasons1Choice.Code), nameof(GeneratedReasons1Choice.Code))]
    [JsonDerivedType(
        typeof(GeneratedReasons1Choice.Proprietary),
        nameof(GeneratedReasons1Choice.Proprietary)
    )]
    [IsoId("_UYxVFdp-Ed-ak6NoX_4Aeg_-1972160125")]
    [DisplayName("Generated Reasons 1 Choice")]
    public abstract record GeneratedReasons1Choice_ { }
}
