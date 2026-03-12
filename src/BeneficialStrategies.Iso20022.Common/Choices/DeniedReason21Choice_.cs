// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason21Choice.Code))]
    [KnownType(typeof(DeniedReason21Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason21Choice.Code),nameof(DeniedReason21Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason21Choice.Proprietary),nameof(DeniedReason21Choice.Proprietary))]
    [IsoId("_6QE6EZNLEeWGlc8L7oPDIg")]
    [DisplayName("Denied Reason 21 Choice")]
    public abstract partial record DeniedReason21Choice_
    {
    }
}
