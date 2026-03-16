// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the transaction modification status.
    /// </summary>
    [KnownType(typeof(ModificationStatusReason1Choice.Code))]
    [KnownType(typeof(ModificationStatusReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationStatusReason1Choice.Code),
        nameof(ModificationStatusReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ModificationStatusReason1Choice.Proprietary),
        nameof(ModificationStatusReason1Choice.Proprietary)
    )]
    [IsoId("_L89WiYlsEeePr-EGJjGYzQ")]
    [DisplayName("Modification Status Reason 1 Choice")]
    public abstract record ModificationStatusReason1Choice_ { }
}
