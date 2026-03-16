// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingProcessingStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingProcessingStatus14Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingProcessingStatus14Choice.NoSpecifiedReason),
        nameof(PendingProcessingStatus14Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingStatus14Choice.Reason),
        nameof(PendingProcessingStatus14Choice.Reason)
    )]
    [IsoId("_6BFbj5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Status 14 Choice")]
    public abstract record PendingProcessingStatus14Choice_ { }
}
