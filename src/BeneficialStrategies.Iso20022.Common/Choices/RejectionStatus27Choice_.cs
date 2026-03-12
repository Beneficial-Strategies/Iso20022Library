// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of rejection status.
    /// </summary>
    [KnownType(typeof(RejectionStatus27Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus27Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus27Choice.NoSpecifiedReason),nameof(RejectionStatus27Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus27Choice.Reason),nameof(RejectionStatus27Choice.Reason))]
    [IsoId("_Vl2wcZNSEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Status 27 Choice")]
    public abstract partial record RejectionStatus27Choice_
    {
    }
}
