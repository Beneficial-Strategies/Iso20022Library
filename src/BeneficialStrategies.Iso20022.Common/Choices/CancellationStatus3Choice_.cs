// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus3Choice.Reason))]
    [JsonDerivedType(typeof(CancellationStatus3Choice.NoSpecifiedReason),nameof(CancellationStatus3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationStatus3Choice.Reason),nameof(CancellationStatus3Choice.Reason))]
    [IsoId("_UUAJ0dp-Ed-ak6NoX_4Aeg_305134914")]
    [DisplayName("Cancellation Status 3 Choice")]
    public abstract partial record CancellationStatus3Choice_
    {
    }
}
