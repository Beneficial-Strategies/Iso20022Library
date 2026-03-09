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
    /// Choice between individual savings account information or additional portfolio information.
    /// </summary>
    [KnownType(typeof(ISAPortfolio4Choice.ISA))]
    [KnownType(typeof(ISAPortfolio4Choice.Portfolio))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ISAPortfolio4Choice.ISA),nameof(ISAPortfolio4Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio4Choice.Portfolio),nameof(ISAPortfolio4Choice.Portfolio))]
    #endif
    [IsoId("_0xR5cbNBEeewUI7-Tnew9A")]
    [DisplayName("ISA Portfolio 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ISAPortfolio4Choice_
    #else
    public abstract partial class ISAPortfolio4Choice_
    #endif
    {
    }
}
