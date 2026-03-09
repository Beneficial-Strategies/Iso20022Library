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
    /// Specifies the type of a rate, a fixed or a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate21Choice.Fixed))]
    [KnownType(typeof(InterestRate21Choice.Floating))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRate21Choice.Fixed),nameof(InterestRate21Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate21Choice.Floating),nameof(InterestRate21Choice.Floating))]
    #endif
    [IsoId("_GO8-BQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Interest Rate 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRate21Choice_
    #else
    public abstract partial class InterestRate21Choice_
    #endif
    {
    }
}
