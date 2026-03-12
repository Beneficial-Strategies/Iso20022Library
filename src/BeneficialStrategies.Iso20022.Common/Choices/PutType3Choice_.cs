// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for put type.
    /// </summary>
    [KnownType(typeof(PutType3Choice.Code))]
    [KnownType(typeof(PutType3Choice.Proprietary))]
    [JsonDerivedType(typeof(PutType3Choice.Code),nameof(PutType3Choice.Code))]
    [JsonDerivedType(typeof(PutType3Choice.Proprietary),nameof(PutType3Choice.Proprietary))]
    [IsoId("_bj1s8eLcEeWFtOV72FbX9w")]
    [DisplayName("Put Type 3 Choice")]
    public abstract partial record PutType3Choice_
    {
    }
}
