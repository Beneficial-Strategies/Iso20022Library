// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus5Choice.Reason))]
    [JsonDerivedType(typeof(DeniedStatus5Choice.NoSpecifiedReason),nameof(DeniedStatus5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DeniedStatus5Choice.Reason),nameof(DeniedStatus5Choice.Reason))]
    [IsoId("_g8F74f7rEeCvPoRGOxRobQ")]
    [DisplayName("Denied Status 5 Choice")]
    public abstract partial record DeniedStatus5Choice_
    {
    }
}
