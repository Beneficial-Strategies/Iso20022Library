// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus62Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus62Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus62Choice.NoSpecifiedReason),nameof(PendingStatus62Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus62Choice.Reason),nameof(PendingStatus62Choice.Reason))]
    [IsoId("_BVzBIQpIEeup4r-PFG2T5Q")]
    [DisplayName("Pending Status 62 Choice")]
    public abstract partial record PendingStatus62Choice_
    {
    }
}
