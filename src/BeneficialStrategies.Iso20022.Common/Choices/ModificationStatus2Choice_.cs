// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of modification status.
    /// </summary>
    [KnownType(typeof(ModificationStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(ModificationStatus2Choice.Reason))]
    [JsonDerivedType(
        typeof(ModificationStatus2Choice.NoSpecifiedReason),
        nameof(ModificationStatus2Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ModificationStatus2Choice.Reason),
        nameof(ModificationStatus2Choice.Reason)
    )]
    [IsoId("_0kkl0QlIEeGATtfOBToyew_-1998753292")]
    [DisplayName("Modification Status 2 Choice")]
    public abstract record ModificationStatus2Choice_ { }
}
