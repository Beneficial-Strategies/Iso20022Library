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
    /// Provides transaction type and identification information.
    /// </summary>
    [KnownType(typeof(TransactionIdentification3Choice.Transaction))]
    [KnownType(typeof(TransactionIdentification3Choice.MarginReporting))]
    [KnownType(typeof(TransactionIdentification3Choice.CollateralReuse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionIdentification3Choice.Transaction),nameof(TransactionIdentification3Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionIdentification3Choice.MarginReporting),nameof(TransactionIdentification3Choice.MarginReporting))]
    [JsonDerivedType(typeof(TransactionIdentification3Choice.CollateralReuse),nameof(TransactionIdentification3Choice.CollateralReuse))]
    #endif
    [IsoId("_hXhZR8K4EeuFNp8LZAnorg")]
    [DisplayName("Transaction Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionIdentification3Choice_
    #else
    public abstract partial class TransactionIdentification3Choice_
    #endif
    {
    }
}
