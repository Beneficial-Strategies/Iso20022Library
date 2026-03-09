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
    /// Choice between a reason for no activity and the foreign exchange swaps segment transaction details.
    /// </summary>
    [KnownType(typeof(ForeignExchangeSwap2Choice.DataSetAction))]
    [KnownType(typeof(ForeignExchangeSwap2Choice.Transaction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ForeignExchangeSwap2Choice.DataSetAction),nameof(ForeignExchangeSwap2Choice.DataSetAction))]
    [JsonDerivedType(typeof(ForeignExchangeSwap2Choice.Transaction),nameof(ForeignExchangeSwap2Choice.Transaction))]
    #endif
    [IsoId("_qc3MAZ2WEeW_58xcYxhewg")]
    [DisplayName("Foreign Exchange Swap 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ForeignExchangeSwap2Choice_
    #else
    public abstract partial class ForeignExchangeSwap2Choice_
    #endif
    {
    }
}
