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
    /// Choice of 3 and 5 exact numeric number.
    /// </summary>
    [KnownType(typeof(Number3Choice.Short))]
    [KnownType(typeof(Number3Choice.Long))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Number3Choice.Short),nameof(Number3Choice.Short))]
    [JsonDerivedType(typeof(Number3Choice.Long),nameof(Number3Choice.Long))]
    #endif
    [IsoId("_QrP6dNp-Ed-ak6NoX_4Aeg_-1147595422")]
    [DisplayName("Number 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Number3Choice_
    #else
    public abstract partial class Number3Choice_
    #endif
    {
    }
}
