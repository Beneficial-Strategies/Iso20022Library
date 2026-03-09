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
    /// Type of interest rate of the loan.
    /// </summary>
    [KnownType(typeof(Rates1Choice.Fixed))]
    [KnownType(typeof(Rates1Choice.Floating))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Rates1Choice.Fixed),nameof(Rates1Choice.Fixed))]
    [JsonDerivedType(typeof(Rates1Choice.Floating),nameof(Rates1Choice.Floating))]
    #endif
    [IsoId("_4OX54Hg1EeuXJdYjLmnO3w")]
    [DisplayName("Rates 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Rates1Choice_
    #else
    public abstract partial class Rates1Choice_
    #endif
    {
    }
}
