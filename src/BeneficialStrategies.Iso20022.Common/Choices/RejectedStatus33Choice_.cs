// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus33Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus33Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus33Choice.NoSpecifiedReason),nameof(RejectedStatus33Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus33Choice.Reason),nameof(RejectedStatus33Choice.Reason))]
    [IsoId("_Pl8fowVSEeqjd8n6wD9JVw")]
    [DisplayName("Rejected Status 33 Choice")]
    public abstract partial record RejectedStatus33Choice_
    {
    }
}
