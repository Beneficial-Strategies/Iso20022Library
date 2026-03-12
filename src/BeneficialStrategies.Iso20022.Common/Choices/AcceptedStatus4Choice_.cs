// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus4Choice.Reason))]
    [JsonDerivedType(typeof(AcceptedStatus4Choice.NoSpecifiedReason),nameof(AcceptedStatus4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcceptedStatus4Choice.Reason),nameof(AcceptedStatus4Choice.Reason))]
    [IsoId("_4TWNQEh6EeOUboEk24drjw")]
    [DisplayName("Accepted Status 4 Choice")]
    public abstract partial record AcceptedStatus4Choice_
    {
    }
}
