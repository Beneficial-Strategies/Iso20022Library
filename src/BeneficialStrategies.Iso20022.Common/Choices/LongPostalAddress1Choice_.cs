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
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [KnownType(typeof(LongPostalAddress1Choice.Unstructured))]
    [KnownType(typeof(LongPostalAddress1Choice.Structured))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LongPostalAddress1Choice.Unstructured),nameof(LongPostalAddress1Choice.Unstructured))]
    [JsonDerivedType(typeof(LongPostalAddress1Choice.Structured),nameof(LongPostalAddress1Choice.Structured))]
    #endif
    [IsoId("_QG4pJdp-Ed-ak6NoX_4Aeg_-1972571676")]
    [DisplayName("Long Postal Address 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LongPostalAddress1Choice_
    #else
    public abstract partial class LongPostalAddress1Choice_
    #endif
    {
    }
}
