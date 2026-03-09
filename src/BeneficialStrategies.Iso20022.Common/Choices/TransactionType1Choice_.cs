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
    /// Choice of transaction type or corporation action event type.
    /// </summary>
    [KnownType(typeof(TransactionType1Choice.TransactionType))]
    [KnownType(typeof(TransactionType1Choice.CorporateActionType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionType1Choice.TransactionType),nameof(TransactionType1Choice.TransactionType))]
    [JsonDerivedType(typeof(TransactionType1Choice.CorporateActionType),nameof(TransactionType1Choice.CorporateActionType))]
    #endif
    [IsoId("_DDQMMAf_EeSaceXTzyiZRg")]
    [DisplayName("Transaction Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionType1Choice_
    #else
    public abstract partial class TransactionType1Choice_
    #endif
    {
    }
}
