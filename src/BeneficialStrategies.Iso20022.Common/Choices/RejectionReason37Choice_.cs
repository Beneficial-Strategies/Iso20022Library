// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason37Choice.Code))]
    [KnownType(typeof(RejectionReason37Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason37Choice.Code),nameof(RejectionReason37Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason37Choice.Proprietary),nameof(RejectionReason37Choice.Proprietary))]
    [IsoId("_uaQ_OekIEemm4qhb2yFPOw")]
    [DisplayName("Rejection Reason 37 Choice")]
    public abstract partial record RejectionReason37Choice_
    {
    }
}
