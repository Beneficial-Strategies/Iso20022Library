// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason33Choice.Code))]
    [KnownType(typeof(RejectedReason33Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason33Choice.Code),nameof(RejectedReason33Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason33Choice.Proprietary),nameof(RejectedReason33Choice.Proprietary))]
    [IsoId("_Pn-g8QVHEeq4ZaI1b_-GPA")]
    [DisplayName("Rejected Reason 33 Choice")]
    public abstract partial record RejectedReason33Choice_
    {
    }
}
