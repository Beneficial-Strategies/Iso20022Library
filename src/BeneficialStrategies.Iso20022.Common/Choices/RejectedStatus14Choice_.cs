// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus14Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus14Choice.NoSpecifiedReason),nameof(RejectedStatus14Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus14Choice.Reason),nameof(RejectedStatus14Choice.Reason))]
    [IsoId("_1izmIVhnEeSsH9MSoogb7Q")]
    [DisplayName("Rejected Status 14 Choice")]
    public abstract partial record RejectedStatus14Choice_
    {
    }
}
