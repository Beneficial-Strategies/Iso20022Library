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
    /// Choice between TimeFrame elements that define a period as number of days after an activity.
    /// </summary>
    [KnownType(typeof(Timeframe2Choice.TradePlus))]
    [KnownType(typeof(Timeframe2Choice.RenunciationPlus))]
    [KnownType(typeof(Timeframe2Choice.Prepayment))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Timeframe2Choice.TradePlus),nameof(Timeframe2Choice.TradePlus))]
    [JsonDerivedType(typeof(Timeframe2Choice.RenunciationPlus),nameof(Timeframe2Choice.RenunciationPlus))]
    [JsonDerivedType(typeof(Timeframe2Choice.Prepayment),nameof(Timeframe2Choice.Prepayment))]
    #endif
    [IsoId("_UAoh69p-Ed-ak6NoX_4Aeg_-63604421")]
    [DisplayName("Timeframe 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Timeframe2Choice_
    #else
    public abstract partial class Timeframe2Choice_
    #endif
    {
    }
}
