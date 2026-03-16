// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Reason72Choice.
    /// </summary>
    [KnownType(typeof(PendingReason72Choice.Code))]
    [KnownType(typeof(PendingReason72Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason72Choice.Code),nameof(PendingReason72Choice.Code))]
    [JsonDerivedType(typeof(PendingReason72Choice.Proprietary),nameof(PendingReason72Choice.Proprietary))]
    [IsoId("_FlApgZzpEe-DHYbvdRjdbA")]
    [DisplayName("Pending Reason72Choice")]
    public abstract partial record PendingReason72Choice_
    {
    }
}
