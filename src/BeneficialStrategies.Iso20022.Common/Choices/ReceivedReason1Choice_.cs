// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of a received status.
    /// </summary>
    [KnownType(typeof(ReceivedReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(ReceivedReason1Choice.Reason))]
    [JsonDerivedType(typeof(ReceivedReason1Choice.NoSpecifiedReason),nameof(ReceivedReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ReceivedReason1Choice.Reason),nameof(ReceivedReason1Choice.Reason))]
    [IsoId("_9wz1bljqEeOnqqBHs8Gasw")]
    [DisplayName("Received Reason 1 Choice")]
    public abstract partial record ReceivedReason1Choice_
    {
    }
}
