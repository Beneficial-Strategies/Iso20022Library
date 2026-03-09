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
    /// Choice of formats for the specification of the order type.
    /// </summary>
    [KnownType(typeof(TransactionType5Choice.Code))]
    [KnownType(typeof(TransactionType5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionType5Choice.Code),nameof(TransactionType5Choice.Code))]
    [JsonDerivedType(typeof(TransactionType5Choice.Proprietary),nameof(TransactionType5Choice.Proprietary))]
    #endif
    [IsoId("_x6jKoVsJEea4y99eritluQ")]
    [DisplayName("Transaction Type 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionType5Choice_
    #else
    public abstract partial class TransactionType5Choice_
    #endif
    {
    }
}
