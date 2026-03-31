// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the system party type.
    /// </summary>
    [KnownType(typeof(SystemPartyType1Choice.Code))]
    [KnownType(typeof(SystemPartyType1Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemPartyType1Choice.Code), nameof(SystemPartyType1Choice.Code))]
    [JsonDerivedType(
        typeof(SystemPartyType1Choice.Proprietary),
        nameof(SystemPartyType1Choice.Proprietary)
    )]
    [IsoId("_DZrOc1hPEeih3fUfzR38Ig")]
    [DisplayName("System Party Type 1 Choice")]
    public abstract record SystemPartyType1Choice_ { }
}
