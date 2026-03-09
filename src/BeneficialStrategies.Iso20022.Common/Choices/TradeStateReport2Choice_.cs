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
    /// Provides details for a trade state report.
    /// </summary>
    [KnownType(typeof(TradeStateReport2Choice.DataSetAction))]
    [KnownType(typeof(TradeStateReport2Choice.State))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeStateReport2Choice.DataSetAction),nameof(TradeStateReport2Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeStateReport2Choice.State),nameof(TradeStateReport2Choice.State))]
    #endif
    [IsoId("_e9vysQAFEeqefbt-QjTNnA")]
    [DisplayName("Trade State Report 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeStateReport2Choice_
    #else
    public abstract partial class TradeStateReport2Choice_
    #endif
    {
    }
}
