// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Returned Status2Choice.
    /// </summary>
    [KnownType(typeof(ReturnedStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(ReturnedStatus2Choice.Reason))]
    [JsonDerivedType(typeof(ReturnedStatus2Choice.NoSpecifiedReason),nameof(ReturnedStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ReturnedStatus2Choice.Reason),nameof(ReturnedStatus2Choice.Reason))]
    [IsoId("_wYfEaaGpEe-4O7NbwmwJkQ")]
    [DisplayName("Returned Status2Choice")]
    public abstract partial record ReturnedStatus2Choice_
    {
    }
}
