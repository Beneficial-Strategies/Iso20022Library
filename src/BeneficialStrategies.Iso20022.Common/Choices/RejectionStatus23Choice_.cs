// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus23Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus23Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus23Choice.NoSpecifiedReason),
        nameof(RejectionStatus23Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus23Choice.Reason),
        nameof(RejectionStatus23Choice.Reason)
    )]
    [IsoId("_6P-zW5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Status 23 Choice")]
    public abstract record RejectionStatus23Choice_ { }
}
