// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus67Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus67Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus67Choice.NoSpecifiedReason),nameof(PendingStatus67Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus67Choice.Reason),nameof(PendingStatus67Choice.Reason))]
    [IsoId("_dCK7qyW-EeygjNFjAlVoPA")]
    [DisplayName("Pending Status 67 Choice")]
    public abstract partial record PendingStatus67Choice_
    {
    }
}
