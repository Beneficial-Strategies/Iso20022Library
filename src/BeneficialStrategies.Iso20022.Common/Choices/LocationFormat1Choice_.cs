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
    /// Choice between the formats to indicate the location of the meeting.
    /// </summary>
    [KnownType(typeof(LocationFormat1Choice.Address))]
    [KnownType(typeof(LocationFormat1Choice.LocationCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LocationFormat1Choice.Address),nameof(LocationFormat1Choice.Address))]
    [JsonDerivedType(typeof(LocationFormat1Choice.LocationCode),nameof(LocationFormat1Choice.LocationCode))]
    #endif
    [IsoId("_RXD3l9p-Ed-ak6NoX_4Aeg_-341096000")]
    [DisplayName("Location Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LocationFormat1Choice_
    #else
    public abstract partial class LocationFormat1Choice_
    #endif
    {
    }
}
