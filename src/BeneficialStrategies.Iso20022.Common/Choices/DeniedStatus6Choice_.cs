// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus6Choice.Reason))]
    [JsonDerivedType(typeof(DeniedStatus6Choice.NoSpecifiedReason),nameof(DeniedStatus6Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DeniedStatus6Choice.Reason),nameof(DeniedStatus6Choice.Reason))]
    [IsoId("_p91CIf7rEeCvPoRGOxRobQ")]
    [DisplayName("Denied Status 6 Choice")]
    public abstract partial record DeniedStatus6Choice_
    {
    }
}
