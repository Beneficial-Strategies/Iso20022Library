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
    /// Reporting of position or transaction for trade lifecycle events.
    /// </summary>
    [KnownType(typeof(TradeData57Choice.DataSetAction))]
    [KnownType(typeof(TradeData57Choice.Report))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData57Choice.DataSetAction),nameof(TradeData57Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData57Choice.Report),nameof(TradeData57Choice.Report))]
    #endif
    [IsoId("_xXUb4WEUEe2P-L9DBerEgA")]
    [DisplayName("Trade Data 57 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData57Choice_
    #else
    public abstract partial class TradeData57Choice_
    #endif
    {
    }
}
