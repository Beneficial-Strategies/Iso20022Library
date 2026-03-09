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
    /// Choice between a standard code or proprietary code to specify the type of lottery.
    /// </summary>
    [KnownType(typeof(LotteryTypeFormat1Choice.Code))]
    [KnownType(typeof(LotteryTypeFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LotteryTypeFormat1Choice.Code),nameof(LotteryTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(LotteryTypeFormat1Choice.Proprietary),nameof(LotteryTypeFormat1Choice.Proprietary))]
    #endif
    [IsoId("_Q3BFmtp-Ed-ak6NoX_4Aeg_-29945278")]
    [DisplayName("Lottery Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LotteryTypeFormat1Choice_
    #else
    public abstract partial class LotteryTypeFormat1Choice_
    #endif
    {
    }
}
