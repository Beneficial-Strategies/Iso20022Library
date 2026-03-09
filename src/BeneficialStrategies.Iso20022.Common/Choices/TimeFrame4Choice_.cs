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
    /// TimeFrame elements that define a period as number of days after an activity.
    /// </summary>
    [KnownType(typeof(TimeFrame4Choice.TradePlus))]
    [KnownType(typeof(TimeFrame4Choice.RenunciationPlus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeFrame4Choice.TradePlus),nameof(TimeFrame4Choice.TradePlus))]
    [JsonDerivedType(typeof(TimeFrame4Choice.RenunciationPlus),nameof(TimeFrame4Choice.RenunciationPlus))]
    #endif
    [IsoId("_UAew6dp-Ed-ak6NoX_4Aeg_1996622705")]
    [DisplayName("Time Frame 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeFrame4Choice_
    #else
    public abstract partial class TimeFrame4Choice_
    #endif
    {
    }
}
