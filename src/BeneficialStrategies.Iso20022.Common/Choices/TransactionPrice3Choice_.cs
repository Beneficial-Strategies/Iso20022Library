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
    /// Specifies the price information related to the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionPrice3Choice.DealPrice))]
    [KnownType(typeof(TransactionPrice3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionPrice3Choice.DealPrice),nameof(TransactionPrice3Choice.DealPrice))]
    [JsonDerivedType(typeof(TransactionPrice3Choice.Proprietary),nameof(TransactionPrice3Choice.Proprietary))]
    #endif
    [IsoId("_tp_6Q1kyEeGeoaLUQk__nA_-725028173")]
    [DisplayName("Transaction Price 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionPrice3Choice_
    #else
    public abstract partial class TransactionPrice3Choice_
    #endif
    {
    }
}
