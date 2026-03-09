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
    [KnownType(typeof(InterestRate33Choice.Fixed))]
    [KnownType(typeof(InterestRate33Choice.Floating))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRate33Choice.Fixed),nameof(InterestRate33Choice.Fixed))]
    [JsonDerivedType(typeof(InterestRate33Choice.Floating),nameof(InterestRate33Choice.Floating))]
    #endif
    [IsoId("_CQQe8SJLEe2zWP9pqvmqdw")]
    [DisplayName("Interest Rate 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRate33Choice_
    #else
    public abstract partial class InterestRate33Choice_
    #endif
    {
    }
}
