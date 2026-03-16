// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit Identification3Choice.
    /// </summary>
    [KnownType(typeof(LimitIdentification3Choice.AllCurrent))]
    [KnownType(typeof(LimitIdentification3Choice.AllDefault))]
    [KnownType(typeof(LimitIdentification3Choice.Current))]
    [KnownType(typeof(LimitIdentification3Choice.Default))]
    [JsonDerivedType(typeof(LimitIdentification3Choice.AllCurrent),nameof(LimitIdentification3Choice.AllCurrent))]
    [JsonDerivedType(typeof(LimitIdentification3Choice.AllDefault),nameof(LimitIdentification3Choice.AllDefault))]
    [JsonDerivedType(typeof(LimitIdentification3Choice.Current),nameof(LimitIdentification3Choice.Current))]
    [JsonDerivedType(typeof(LimitIdentification3Choice.Default),nameof(LimitIdentification3Choice.Default))]
    [IsoId("_0T7ldTEyEe6g-ffJsqGiSA")]
    [DisplayName("Limit Identification3Choice")]
    public abstract partial record LimitIdentification3Choice_
    {
    }
}
