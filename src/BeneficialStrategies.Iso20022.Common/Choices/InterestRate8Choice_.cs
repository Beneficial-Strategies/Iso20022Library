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
    /// Choice between a fixed rate and a variable rate.
    /// </summary>
    [KnownType(typeof(InterestRate8Choice.Fixed))]
    [KnownType(typeof(InterestRate8Choice.Floating))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRate8Choice.Fixed),nameof(InterestRate8Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate8Choice.Floating),nameof(InterestRate8Choice.Floating))]
    #endif
    [IsoId("_H7ydeX5aEea2k7EBUopqxw")]
    [DisplayName("Interest Rate 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRate8Choice_
    #else
    public abstract partial class InterestRate8Choice_
    #endif
    {
    }
}
