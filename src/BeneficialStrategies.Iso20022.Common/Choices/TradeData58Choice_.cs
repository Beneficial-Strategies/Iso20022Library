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
    [KnownType(typeof(TradeData58Choice.DataSetAction))]
    [KnownType(typeof(TradeData58Choice.State))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeData58Choice.DataSetAction),nameof(TradeData58Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData58Choice.State),nameof(TradeData58Choice.State))]
    #endif
    [IsoId("_B_8MQWEbEe2P-L9DBerEgA")]
    [DisplayName("Trade Data 58 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData58Choice_
    #else
    public abstract partial class TradeData58Choice_
    #endif
    {
    }
}
