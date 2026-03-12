// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus43Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus43Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus43Choice.NoSpecifiedReason),nameof(PendingStatus43Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus43Choice.Reason),nameof(PendingStatus43Choice.Reason))]
    [IsoId("_cel4H5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Status 43 Choice")]
    public abstract partial record PendingStatus43Choice_
    {
    }
}
