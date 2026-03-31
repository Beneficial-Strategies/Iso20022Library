// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the nature of the relationship a member has with a system.
    /// </summary>
    [KnownType(typeof(SystemMemberType1Choice.Code))]
    [KnownType(typeof(SystemMemberType1Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemMemberType1Choice.Code), nameof(SystemMemberType1Choice.Code))]
    [JsonDerivedType(
        typeof(SystemMemberType1Choice.Proprietary),
        nameof(SystemMemberType1Choice.Proprietary)
    )]
    [IsoId("_Sr86gHhgEeidzqjNEfehPg")]
    [DisplayName("System Member Type 1 Choice")]
    public abstract record SystemMemberType1Choice_ { }
}
