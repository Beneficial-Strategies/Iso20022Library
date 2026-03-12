// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the undertaking termination reason.
    /// </summary>
    [KnownType(typeof(TerminationReason1Choice.Code))]
    [KnownType(typeof(TerminationReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(TerminationReason1Choice.Code),nameof(TerminationReason1Choice.Code))]
    [JsonDerivedType(typeof(TerminationReason1Choice.Proprietary),nameof(TerminationReason1Choice.Proprietary))]
    [IsoId("_932rsXltEeG7BsjMvd1mEw_1357060754")]
    [DisplayName("Termination Reason 1 Choice")]
    public abstract partial record TerminationReason1Choice_
    {
    }
}
