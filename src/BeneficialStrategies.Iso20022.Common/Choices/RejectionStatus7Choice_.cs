// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of rejection status.
    /// </summary>
    [KnownType(typeof(RejectionStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus7Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus7Choice.NoSpecifiedReason),nameof(RejectionStatus7Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus7Choice.Reason),nameof(RejectionStatus7Choice.Reason))]
    [IsoId("_0j0X4wlIEeGATtfOBToyew_1026821782")]
    [DisplayName("Rejection Status 7 Choice")]
    public abstract partial record RejectionStatus7Choice_
    {
    }
}
