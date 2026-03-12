// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of fund parameters.
    /// </summary>
    [KnownType(typeof(FundParameters4Choice.NoCriteria))]
    [KnownType(typeof(FundParameters4Choice.Parameters))]
    [JsonDerivedType(typeof(FundParameters4Choice.NoCriteria),nameof(FundParameters4Choice.NoCriteria))]
    [JsonDerivedType(typeof(FundParameters4Choice.Parameters),nameof(FundParameters4Choice.Parameters))]
    [IsoId("_J-otAWomEeipaMTLlhaKMQ")]
    [DisplayName("Fund Parameters 4 Choice")]
    public abstract partial record FundParameters4Choice_
    {
    }
}
