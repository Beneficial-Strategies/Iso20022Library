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
    /// Specifies the quantities (such as securities) in the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionQuantities3Choice.Quantity))]
    [KnownType(typeof(TransactionQuantities3Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(TransactionQuantities3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionQuantities3Choice.Quantity),nameof(TransactionQuantities3Choice.Quantity))]
    [JsonDerivedType(typeof(TransactionQuantities3Choice.OriginalAndCurrentFaceAmount),nameof(TransactionQuantities3Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(TransactionQuantities3Choice.Proprietary),nameof(TransactionQuantities3Choice.Proprietary))]
    #endif
    [IsoId("_dBfEgXkcEei6JsZKrqN0hQ")]
    [DisplayName("Transaction Quantities 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionQuantities3Choice_
    #else
    public abstract partial class TransactionQuantities3Choice_
    #endif
    {
    }
}
