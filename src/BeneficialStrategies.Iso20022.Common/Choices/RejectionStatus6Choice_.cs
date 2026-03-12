// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus6Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus6Choice.NoSpecifiedReason),nameof(RejectionStatus6Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus6Choice.Reason),nameof(RejectionStatus6Choice.Reason))]
    [IsoId("_UCsAgf7rEeCvPoRGOxRobQ")]
    [DisplayName("Rejection Status 6 Choice")]
    public abstract partial record RejectionStatus6Choice_
    {
    }
}
