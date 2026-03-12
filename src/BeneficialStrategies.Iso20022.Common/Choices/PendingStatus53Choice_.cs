// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus53Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus53Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus53Choice.NoSpecifiedReason),nameof(PendingStatus53Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus53Choice.Reason),nameof(PendingStatus53Choice.Reason))]
    [IsoId("_kov6k5wsEeazcsnODTksnQ")]
    [DisplayName("Pending Status 53 Choice")]
    public abstract partial record PendingStatus53Choice_
    {
    }
}
