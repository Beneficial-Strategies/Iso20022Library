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
    /// Choice of format for the transaction activity identification.
    /// </summary>
    [KnownType(typeof(TransactionActivity4Choice.Code))]
    [KnownType(typeof(TransactionActivity4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionActivity4Choice.Code),nameof(TransactionActivity4Choice.Code))]
    [JsonDerivedType(typeof(TransactionActivity4Choice.Proprietary),nameof(TransactionActivity4Choice.Proprietary))]
    #endif
    [IsoId("_8VKXSZNLEeWGlc8L7oPDIg")]
    [DisplayName("Transaction Activity 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionActivity4Choice_
    #else
    public abstract partial class TransactionActivity4Choice_
    #endif
    {
    }
}
