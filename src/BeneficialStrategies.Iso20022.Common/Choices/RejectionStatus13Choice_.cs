// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus13Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus13Choice.NoSpecifiedReason),nameof(RejectionStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus13Choice.Reason),nameof(RejectionStatus13Choice.Reason))]
    [IsoId("_-ojZ8SwtEeOEV5XHD-BKpw")]
    [DisplayName("Rejection Status 13 Choice")]
    public abstract partial record RejectionStatus13Choice_
    {
    }
}
