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
    /// Choice between different ways of specifying the method to determine as from when shares have been held by an investor.
    /// </summary>
    [KnownType(typeof(RequestShareHeldDate1Choice.DateCalculationMethod))]
    [KnownType(typeof(RequestShareHeldDate1Choice.DateCalculationDescription))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RequestShareHeldDate1Choice.DateCalculationMethod),nameof(RequestShareHeldDate1Choice.DateCalculationMethod))]
    [JsonDerivedType(typeof(RequestShareHeldDate1Choice.DateCalculationDescription),nameof(RequestShareHeldDate1Choice.DateCalculationDescription))]
    #endif
    [IsoId("_iOMVYFSTEempisJfoIfvvQ")]
    [DisplayName("Request Share Held Date 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RequestShareHeldDate1Choice_
    #else
    public abstract partial class RequestShareHeldDate1Choice_
    #endif
    {
    }
}
