// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason7Choice.Code))]
    [KnownType(typeof(DeniedReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason7Choice.Code),nameof(DeniedReason7Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason7Choice.Proprietary),nameof(DeniedReason7Choice.Proprietary))]
    [IsoId("_u-cEwFhoEeS8HfHHd4stCA")]
    [DisplayName("Denied Reason 7 Choice")]
    public abstract partial record DeniedReason7Choice_
    {
    }
}
