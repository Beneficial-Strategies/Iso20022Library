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
    [KnownType(typeof(InterestRate23Choice.Fixed))]
    [KnownType(typeof(InterestRate23Choice.Floating))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRate23Choice.Fixed),nameof(InterestRate23Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate23Choice.Floating),nameof(InterestRate23Choice.Floating))]
    #endif
    [IsoId("_6Hvyx1fREeqqKf65rDYWYw")]
    [DisplayName("Interest Rate 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRate23Choice_
    #else
    public abstract partial class InterestRate23Choice_
    #endif
    {
    }
}
