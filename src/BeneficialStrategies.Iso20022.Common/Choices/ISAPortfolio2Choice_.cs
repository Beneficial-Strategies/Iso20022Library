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
    [KnownType(typeof(ISAPortfolio2Choice.ISA))]
    [KnownType(typeof(ISAPortfolio2Choice.Portfolio))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ISAPortfolio2Choice.ISA),nameof(ISAPortfolio2Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio2Choice.Portfolio),nameof(ISAPortfolio2Choice.Portfolio))]
    #endif
    [IsoId("_3fnhckXfEeGY6MkiuzuPOA_858119227")]
    [DisplayName("ISA Portfolio 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ISAPortfolio2Choice_
    #else
    public abstract partial class ISAPortfolio2Choice_
    #endif
    {
    }
}
