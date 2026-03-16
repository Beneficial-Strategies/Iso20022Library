// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the number.
    /// </summary>
    [KnownType(typeof(Number1Choice.NumberIdentification))]
    [KnownType(typeof(Number1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(Number1Choice.NumberIdentification),
        nameof(Number1Choice.NumberIdentification)
    )]
    [JsonDerivedType(typeof(Number1Choice.Proprietary), nameof(Number1Choice.Proprietary))]
    [IsoId("_RdKfk9p-Ed-ak6NoX_4Aeg_2132216817")]
    [DisplayName("Number 1 Choice")]
    public abstract record Number1Choice_ { }
}
