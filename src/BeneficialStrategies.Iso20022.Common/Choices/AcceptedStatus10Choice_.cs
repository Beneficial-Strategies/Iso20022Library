// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus10Choice.Reason))]
    [JsonDerivedType(typeof(AcceptedStatus10Choice.NoSpecifiedReason),nameof(AcceptedStatus10Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcceptedStatus10Choice.Reason),nameof(AcceptedStatus10Choice.Reason))]
    [IsoId("_6HWbjZNLEeWGlc8L7oPDIg")]
    [DisplayName("Accepted Status 10 Choice")]
    public abstract partial record AcceptedStatus10Choice_
    {
    }
}
