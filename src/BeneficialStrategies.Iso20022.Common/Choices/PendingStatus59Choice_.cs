// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus59Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus59Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus59Choice.NoSpecifiedReason),nameof(PendingStatus59Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus59Choice.Reason),nameof(PendingStatus59Choice.Reason))]
    [IsoId("_Szi6YgVREeqjd8n6wD9JVw")]
    [DisplayName("Pending Status 59 Choice")]
    public abstract partial record PendingStatus59Choice_
    {
    }
}
