// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason65Choice.Code))]
    [KnownType(typeof(PendingReason65Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason65Choice.Code),nameof(PendingReason65Choice.Code))]
    [JsonDerivedType(typeof(PendingReason65Choice.Proprietary),nameof(PendingReason65Choice.Proprietary))]
    [IsoId("_f99MPTi8Eeydid5dcNPKvg")]
    [DisplayName("Pending Reason 65 Choice")]
    public abstract partial record PendingReason65Choice_
    {
    }
}
