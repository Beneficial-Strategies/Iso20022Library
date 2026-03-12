// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason37Choice.Code))]
    [KnownType(typeof(CancellationReason37Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason37Choice.Code),nameof(CancellationReason37Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason37Choice.Proprietary),nameof(CancellationReason37Choice.Proprietary))]
    [IsoId("_65NbEffUEeiNZp_PtLohLw")]
    [DisplayName("Cancellation Reason 37 Choice")]
    public abstract partial record CancellationReason37Choice_
    {
    }
}
