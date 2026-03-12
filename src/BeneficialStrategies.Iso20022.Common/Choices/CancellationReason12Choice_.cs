// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason12Choice.Code))]
    [KnownType(typeof(CancellationReason12Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason12Choice.Code),nameof(CancellationReason12Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason12Choice.Proprietary),nameof(CancellationReason12Choice.Proprietary))]
    [IsoId("_nR4Ixf5DEeClUvPNHKL9Zw")]
    [DisplayName("Cancellation Reason 12 Choice")]
    public abstract partial record CancellationReason12Choice_
    {
    }
}
