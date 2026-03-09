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
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide1Choice.Code))]
    [KnownType(typeof(MarketClientSide1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketClientSide1Choice.Code),nameof(MarketClientSide1Choice.Code))]
    [JsonDerivedType(typeof(MarketClientSide1Choice.Proprietary),nameof(MarketClientSide1Choice.Proprietary))]
    #endif
    [IsoId("_QvuKxdp-Ed-ak6NoX_4Aeg_-2065696030")]
    [DisplayName("Market Client Side 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketClientSide1Choice_
    #else
    public abstract partial class MarketClientSide1Choice_
    #endif
    {
    }
}
