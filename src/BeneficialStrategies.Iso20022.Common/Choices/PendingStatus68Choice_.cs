// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus68Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus68Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus68Choice.NoSpecifiedReason),nameof(PendingStatus68Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus68Choice.Reason),nameof(PendingStatus68Choice.Reason))]
    [IsoId("_piJUEzi7Eeydid5dcNPKvg")]
    [DisplayName("Pending Status 68 Choice")]
    public abstract partial record PendingStatus68Choice_
    {
    }
}
