// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason32Choice.Code))]
    [KnownType(typeof(RejectedReason32Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason32Choice.Code), nameof(RejectedReason32Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason32Choice.Proprietary),
        nameof(RejectedReason32Choice.Proprietary)
    )]
    [IsoId("_Pl8fzwVSEeqjd8n6wD9JVw")]
    [DisplayName("Rejected Reason 32 Choice")]
    public abstract record RejectedReason32Choice_ { }
}
