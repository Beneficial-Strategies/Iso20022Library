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
    /// Identifies an airport by its code or by its name and the town where it is located.
    /// </summary>
    [KnownType(typeof(AirportName1Choice.AirportCode))]
    [KnownType(typeof(AirportName1Choice.OtherAirportDescription))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AirportName1Choice.AirportCode),nameof(AirportName1Choice.AirportCode))]
    [JsonDerivedType(typeof(AirportName1Choice.OtherAirportDescription),nameof(AirportName1Choice.OtherAirportDescription))]
    #endif
    [IsoId("_SsSlI9p-Ed-ak6NoX_4Aeg_-992731401")]
    [DisplayName("Airport Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AirportName1Choice_
    #else
    public abstract partial class AirportName1Choice_
    #endif
    {
    }
}
