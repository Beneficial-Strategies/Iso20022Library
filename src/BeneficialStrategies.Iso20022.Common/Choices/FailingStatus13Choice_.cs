// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus13Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus13Choice.NoSpecifiedReason),nameof(FailingStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus13Choice.Reason),nameof(FailingStatus13Choice.Reason))]
    [IsoId("_9wP7USW-EeygjNFjAlVoPA")]
    [DisplayName("Failing Status 13 Choice")]
    public abstract partial record FailingStatus13Choice_
    {
    }
}
