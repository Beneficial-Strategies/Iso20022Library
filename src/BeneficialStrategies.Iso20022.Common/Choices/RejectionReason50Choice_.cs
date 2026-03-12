// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason50Choice.Code))]
    [KnownType(typeof(RejectionReason50Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason50Choice.Code),nameof(RejectionReason50Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason50Choice.Proprietary),nameof(RejectionReason50Choice.Proprietary))]
    [IsoId("_f98j4zi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Reason 50 Choice")]
    public abstract partial record RejectionReason50Choice_
    {
    }
}
