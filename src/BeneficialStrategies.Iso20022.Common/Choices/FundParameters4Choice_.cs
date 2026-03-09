// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of fund parameters.
    /// </summary>
    [KnownType(typeof(FundParameters4Choice.NoCriteria))]
    [KnownType(typeof(FundParameters4Choice.Parameters))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FundParameters4Choice.NoCriteria),nameof(FundParameters4Choice.NoCriteria))]
    [JsonDerivedType(typeof(FundParameters4Choice.Parameters),nameof(FundParameters4Choice.Parameters))]
    #endif
    [IsoId("_J-otAWomEeipaMTLlhaKMQ")]
    [DisplayName("Fund Parameters 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundParameters4Choice_
    #else
    public abstract partial class FundParameters4Choice_
    #endif
    {
    }
}
