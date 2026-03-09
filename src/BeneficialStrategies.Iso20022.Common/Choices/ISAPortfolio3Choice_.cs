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
    /// Choice to provide additional portfolio information or individual savings account information (UK government scheme provided by UK based financial institutions only).
    /// </summary>
    [KnownType(typeof(ISAPortfolio3Choice.ISA))]
    [KnownType(typeof(ISAPortfolio3Choice.Portfolio))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ISAPortfolio3Choice.ISA),nameof(ISAPortfolio3Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio3Choice.Portfolio),nameof(ISAPortfolio3Choice.Portfolio))]
    #endif
    [IsoId("_3fnhcEXfEeGY6MkiuzuPOA_-1372155354")]
    [DisplayName("ISA Portfolio 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ISAPortfolio3Choice_
    #else
    public abstract partial class ISAPortfolio3Choice_
    #endif
    {
    }
}
