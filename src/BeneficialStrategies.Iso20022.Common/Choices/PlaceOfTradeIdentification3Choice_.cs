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
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    [KnownType(typeof(PlaceOfTradeIdentification3Choice.Country))]
    [KnownType(typeof(PlaceOfTradeIdentification3Choice.Exchange))]
    [KnownType(typeof(PlaceOfTradeIdentification3Choice.OverTheCounter))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PlaceOfTradeIdentification3Choice.Country),nameof(PlaceOfTradeIdentification3Choice.Country))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification3Choice.Exchange),nameof(PlaceOfTradeIdentification3Choice.Exchange))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification3Choice.OverTheCounter),nameof(PlaceOfTradeIdentification3Choice.OverTheCounter))]
    #endif
    [IsoId("_WNc-0tp-Ed-ak6NoX_4Aeg_-1162943357")]
    [DisplayName("Place Of Trade Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PlaceOfTradeIdentification3Choice_
    #else
    public abstract partial class PlaceOfTradeIdentification3Choice_
    #endif
    {
    }
}
