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
    [KnownType(typeof(ISAPortfolio1Choice.ISA))]
    [KnownType(typeof(ISAPortfolio1Choice.Portfolio))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ISAPortfolio1Choice.ISA),nameof(ISAPortfolio1Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio1Choice.Portfolio),nameof(ISAPortfolio1Choice.Portfolio))]
    #endif
    [IsoId("_IjgyAENIEeGHJ_bHJRPaIQ_1207099058")]
    [DisplayName("ISA Portfolio 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ISAPortfolio1Choice_
    #else
    public abstract partial class ISAPortfolio1Choice_
    #endif
    {
    }
}
