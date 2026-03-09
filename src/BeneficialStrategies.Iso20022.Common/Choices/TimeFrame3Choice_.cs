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
    /// Choice between TimeFrame elements that define a period as number of days before an activity.
    /// </summary>
    [KnownType(typeof(TimeFrame3Choice.TradeMinus))]
    [KnownType(typeof(TimeFrame3Choice.RenunciationMinus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TimeFrame3Choice.TradeMinus),nameof(TimeFrame3Choice.TradeMinus))]
    [JsonDerivedType(typeof(TimeFrame3Choice.RenunciationMinus),nameof(TimeFrame3Choice.RenunciationMinus))]
    #endif
    [IsoId("_UAyS4tp-Ed-ak6NoX_4Aeg_606871558")]
    [DisplayName("Time Frame 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeFrame3Choice_
    #else
    public abstract partial class TimeFrame3Choice_
    #endif
    {
    }
}
