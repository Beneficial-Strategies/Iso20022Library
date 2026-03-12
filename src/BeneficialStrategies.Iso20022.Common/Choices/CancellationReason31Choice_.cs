// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason31Choice.Code))]
    [KnownType(typeof(CancellationReason31Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason31Choice.Code),nameof(CancellationReason31Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason31Choice.Proprietary),nameof(CancellationReason31Choice.Proprietary))]
    [IsoId("_tTaksVM4Eear4I4mBVNwZg")]
    [DisplayName("Cancellation Reason 31 Choice")]
    public abstract partial record CancellationReason31Choice_
    {
    }
}
