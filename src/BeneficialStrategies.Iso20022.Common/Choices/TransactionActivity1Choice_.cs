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
    [KnownType(typeof(TransactionActivity1Choice.Code))]
    [KnownType(typeof(TransactionActivity1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionActivity1Choice.Code),nameof(TransactionActivity1Choice.Code))]
    [JsonDerivedType(typeof(TransactionActivity1Choice.Proprietary),nameof(TransactionActivity1Choice.Proprietary))]
    #endif
    [IsoId("_QwUAqNp-Ed-ak6NoX_4Aeg_537035239")]
    [DisplayName("Transaction Activity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionActivity1Choice_
    #else
    public abstract partial class TransactionActivity1Choice_
    #endif
    {
    }
}
