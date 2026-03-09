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
    /// Choice between a fixed rate and a floating rate.
    /// </summary>
    [KnownType(typeof(InterestRate20Choice.Fixed))]
    [KnownType(typeof(InterestRate20Choice.Floating))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRate20Choice.Fixed),nameof(InterestRate20Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate20Choice.Floating),nameof(InterestRate20Choice.Floating))]
    #endif
    [IsoId("_hBu-xax2Eem81-uIvTF5rQ")]
    [DisplayName("Interest Rate 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRate20Choice_
    #else
    public abstract partial class InterestRate20Choice_
    #endif
    {
    }
}
