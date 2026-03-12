// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for call type.
    /// </summary>
    [KnownType(typeof(CallType3Choice.Code))]
    [KnownType(typeof(CallType3Choice.Proprietary))]
    [JsonDerivedType(typeof(CallType3Choice.Code),nameof(CallType3Choice.Code))]
    [JsonDerivedType(typeof(CallType3Choice.Proprietary),nameof(CallType3Choice.Proprietary))]
    [IsoId("_fBEo0eLcEeWFtOV72FbX9w")]
    [DisplayName("Call Type 3 Choice")]
    public abstract partial record CallType3Choice_
    {
    }
}
