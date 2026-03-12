// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus60Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus60Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus60Choice.NoSpecifiedReason),nameof(PendingStatus60Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus60Choice.Reason),nameof(PendingStatus60Choice.Reason))]
    [IsoId("_Pl8f8wVSEeqjd8n6wD9JVw")]
    [DisplayName("Pending Status 60 Choice")]
    public abstract partial record PendingStatus60Choice_
    {
    }
}
