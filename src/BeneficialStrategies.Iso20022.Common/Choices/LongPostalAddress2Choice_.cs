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
    /// Information that locates and identifies a specific address, as defined by postal services either in a structured or unstructured way.
    /// </summary>
    [KnownType(typeof(LongPostalAddress2Choice.Unstructured))]
    [KnownType(typeof(LongPostalAddress2Choice.Structured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LongPostalAddress2Choice.Unstructured),nameof(LongPostalAddress2Choice.Unstructured))]
    [JsonDerivedType(typeof(LongPostalAddress2Choice.Structured),nameof(LongPostalAddress2Choice.Structured))]
    #endif
    [IsoId("_RVRH19p-Ed-ak6NoX_4Aeg_-1296060125")]
    [DisplayName("Long Postal Address 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LongPostalAddress2Choice_
    #else
    public abstract partial class LongPostalAddress2Choice_
    #endif
    {
    }
}
