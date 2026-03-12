// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason36Choice.Code))]
    [KnownType(typeof(PendingReason36Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason36Choice.Code),nameof(PendingReason36Choice.Code))]
    [JsonDerivedType(typeof(PendingReason36Choice.Proprietary),nameof(PendingReason36Choice.Proprietary))]
    [IsoId("_5SGOi5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 36 Choice")]
    public abstract partial record PendingReason36Choice_
    {
    }
}
