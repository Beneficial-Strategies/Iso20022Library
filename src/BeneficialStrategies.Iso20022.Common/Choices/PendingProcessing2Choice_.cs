// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the Pending Processing status.
    /// </summary>
    [KnownType(typeof(PendingProcessing2Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessing2Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessing2Choice.NoSpecifiedReason),
        nameof(PendingProcessing2Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessing2Choice.Reason),
        nameof(PendingProcessing2Choice.Reason)
    )]
    [IsoId("_mHx3sQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Pending Processing 2 Choice")]
    public abstract record PendingProcessing2Choice_ { }
}
