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
    /// Set of data concerning the reporting trade..
    /// </summary>
    [KnownType(typeof(TradeData36Choice.DataSetAction))]
    [KnownType(typeof(TradeData36Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData36Choice.DataSetAction),nameof(TradeData36Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData36Choice.Report),nameof(TradeData36Choice.Report))]
    #endif
    [IsoId("_MvN7scK8EeuMhqg3CsEu6Q")]
    [DisplayName("Trade Data 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData36Choice_
    #else
    public abstract partial class TradeData36Choice_
    #endif
    {
    }
}
