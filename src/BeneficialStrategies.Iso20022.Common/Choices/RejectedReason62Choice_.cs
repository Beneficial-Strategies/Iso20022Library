// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Reason62Choice.
    /// </summary>
    [KnownType(typeof(RejectedReason62Choice.Code))]
    [KnownType(typeof(RejectedReason62Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason62Choice.Code),nameof(RejectedReason62Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason62Choice.Proprietary),nameof(RejectedReason62Choice.Proprietary))]
    [IsoId("_UqcwWXSdEe6VWZz2tTgENw")]
    [DisplayName("Rejected Reason62Choice")]
    public abstract partial record RejectedReason62Choice_
    {
    }
}
