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
    /// Choice of formats for the transaction type.
    /// </summary>
    [KnownType(typeof(TransactionType2Choice.Type))]
    [KnownType(typeof(TransactionType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionType2Choice.Type),nameof(TransactionType2Choice.Type))]
    [JsonDerivedType(typeof(TransactionType2Choice.Proprietary),nameof(TransactionType2Choice.Proprietary))]
    #endif
    [IsoId("_SyV7QQf_EeSaceXTzyiZRg")]
    [DisplayName("Transaction Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionType2Choice_
    #else
    public abstract partial class TransactionType2Choice_
    #endif
    {
    }
}
