// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a proprietary or narrative reason and no reason for the rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus29Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus29Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus29Choice.NoSpecifiedReason),nameof(RejectedStatus29Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus29Choice.Reason),nameof(RejectedStatus29Choice.Reason))]
    [IsoId("_fh9eqYeWEemJ1cSJJmVYRQ")]
    [DisplayName("Rejected Status 29 Choice")]
    public abstract partial record RejectedStatus29Choice_
    {
    }
}
