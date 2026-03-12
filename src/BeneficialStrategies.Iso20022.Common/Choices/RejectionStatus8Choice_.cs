// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus8Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus8Choice.NoSpecifiedReason),nameof(RejectionStatus8Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus8Choice.Reason),nameof(RejectionStatus8Choice.Reason))]
    [IsoId("_0ka00wlIEeGATtfOBToyew_-1151748703")]
    [DisplayName("Rejection Status 8 Choice")]
    public abstract partial record RejectionStatus8Choice_
    {
    }
}
