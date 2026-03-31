// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of modification status.
    /// </summary>
    [KnownType(typeof(ModificationStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(ModificationStatus5Choice.Reason))]
    [JsonDerivedType(
        typeof(ModificationStatus5Choice.NoSpecifiedReason),
        nameof(ModificationStatus5Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ModificationStatus5Choice.Reason),
        nameof(ModificationStatus5Choice.Reason)
    )]
    [IsoId("_6QDrU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Modification Status 5 Choice")]
    public abstract record ModificationStatus5Choice_ { }
}
