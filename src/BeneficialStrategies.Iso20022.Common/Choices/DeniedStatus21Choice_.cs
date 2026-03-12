// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus21Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus21Choice.Reason))]
    [JsonDerivedType(typeof(DeniedStatus21Choice.NoSpecifiedReason),nameof(DeniedStatus21Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(DeniedStatus21Choice.Reason),nameof(DeniedStatus21Choice.Reason))]
    [IsoId("_6QE555NLEeWGlc8L7oPDIg")]
    [DisplayName("Denied Status 21 Choice")]
    public abstract partial record DeniedStatus21Choice_
    {
    }
}
