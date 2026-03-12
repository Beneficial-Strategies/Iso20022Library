// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason55Choice.Code))]
    [KnownType(typeof(RejectedReason55Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason55Choice.Code),nameof(RejectedReason55Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason55Choice.Proprietary),nameof(RejectedReason55Choice.Proprietary))]
    [IsoId("_pUJvEzQXEe2o-K1dwNg8Gg")]
    [DisplayName("Rejected Reason 55 Choice")]
    public abstract partial record RejectedReason55Choice_
    {
    }
}
