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
    /// Geographic location of the ATM specified by geographic coordinates or UTM coordinates.
    /// </summary>
    [KnownType(typeof(GeographicLocation1Choice.GeographicCoordinates))]
    [KnownType(typeof(GeographicLocation1Choice.UTMCoordinates))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GeographicLocation1Choice.GeographicCoordinates),nameof(GeographicLocation1Choice.GeographicCoordinates))]
    [JsonDerivedType(typeof(GeographicLocation1Choice.UTMCoordinates),nameof(GeographicLocation1Choice.UTMCoordinates))]
    #endif
    [IsoId("_4klZMIn4EeShMpas3885ww")]
    [DisplayName("Geographic Location 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeographicLocation1Choice_
    #else
    public abstract partial class GeographicLocation1Choice_
    #endif
    {
    }
}
