// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Reason67Choice.
    /// </summary>
    [KnownType(typeof(PendingReason67Choice.Code))]
    [KnownType(typeof(PendingReason67Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason67Choice.Code), nameof(PendingReason67Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason67Choice.Proprietary),
        nameof(PendingReason67Choice.Proprietary)
    )]
    [IsoId("_mOfasX_UEe6NNIFrPQqloA")]
    [DisplayName("Pending Reason67Choice")]
    public abstract record PendingReason67Choice_ { }
}
