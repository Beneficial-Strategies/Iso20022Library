// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for security status.
    /// </summary>
    [KnownType(typeof(SecurityStatus3Choice.Code))]
    [KnownType(typeof(SecurityStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(SecurityStatus3Choice.Code),nameof(SecurityStatus3Choice.Code))]
    [JsonDerivedType(typeof(SecurityStatus3Choice.Proprietary),nameof(SecurityStatus3Choice.Proprietary))]
    [IsoId("_F8MPEeLcEeWFtOV72FbX9w")]
    [DisplayName("Security Status 3 Choice")]
    public abstract partial record SecurityStatus3Choice_
    {
    }
}
