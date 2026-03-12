// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus53Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus53Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus53Choice.NoSpecifiedReason),nameof(RejectedStatus53Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus53Choice.Reason),nameof(RejectedStatus53Choice.Reason))]
    [IsoId("_oj4IyzQXEe2o-K1dwNg8Gg")]
    [DisplayName("Rejected Status 53 Choice")]
    public abstract partial record RejectedStatus53Choice_
    {
    }
}
