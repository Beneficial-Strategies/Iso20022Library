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
    [KnownType(typeof(LotteryTypeFormat5Choice.Code))]
    [KnownType(typeof(LotteryTypeFormat5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LotteryTypeFormat5Choice.Code),nameof(LotteryTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(LotteryTypeFormat5Choice.Proprietary),nameof(LotteryTypeFormat5Choice.Proprietary))]
    #endif
    [IsoId("_cdS3gZKQEeWHWpTQn1FFVg")]
    [DisplayName("Lottery Type Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LotteryTypeFormat5Choice_
    #else
    public abstract partial class LotteryTypeFormat5Choice_
    #endif
    {
    }
}
