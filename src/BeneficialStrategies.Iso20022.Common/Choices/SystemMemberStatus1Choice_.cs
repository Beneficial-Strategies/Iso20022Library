// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of a member within a system.
    /// </summary>
    [KnownType(typeof(SystemMemberStatus1Choice.Code))]
    [KnownType(typeof(SystemMemberStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SystemMemberStatus1Choice.Code),
        nameof(SystemMemberStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SystemMemberStatus1Choice.Proprietary),
        nameof(SystemMemberStatus1Choice.Proprietary)
    )]
    [IsoId("_V4OMw3hhEeidzqjNEfehPg")]
    [DisplayName("System Member Status 1 Choice")]
    public abstract record SystemMemberStatus1Choice_ { }
}
