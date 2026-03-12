// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the restriction or limitation status.
    /// </summary>
    [KnownType(typeof(RestrictionStatus1Choice.Code))]
    [KnownType(typeof(RestrictionStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(RestrictionStatus1Choice.Code),nameof(RestrictionStatus1Choice.Code))]
    [JsonDerivedType(typeof(RestrictionStatus1Choice.Proprietary),nameof(RestrictionStatus1Choice.Proprietary))]
    [IsoId("_UWN50CFnEeW9XJWqfgXIIA")]
    [DisplayName("Restriction Status 1 Choice")]
    public abstract partial record RestrictionStatus1Choice_
    {
    }
}
