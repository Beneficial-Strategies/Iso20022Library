// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason25Choice.Code))]
    [KnownType(typeof(RejectionReason25Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason25Choice.Code),nameof(RejectionReason25Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason25Choice.Proprietary),nameof(RejectionReason25Choice.Proprietary))]
    [IsoId("_ecZ5BTt5EeW638lNyHKv7A")]
    [DisplayName("Rejection Reason 25 Choice")]
    public abstract partial record RejectionReason25Choice_
    {
    }
}
