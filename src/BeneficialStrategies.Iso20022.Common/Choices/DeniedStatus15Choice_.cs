// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus15Choice.Reason))]
    [JsonDerivedType(typeof(DeniedStatus15Choice.NoSpecifiedReason),nameof(DeniedStatus15Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DeniedStatus15Choice.Reason),nameof(DeniedStatus15Choice.Reason))]
    [IsoId("_-rIDUTq1EeWyoP0PbocV1Q")]
    [DisplayName("Denied Status 15 Choice")]
    public abstract partial record DeniedStatus15Choice_
    {
    }
}
