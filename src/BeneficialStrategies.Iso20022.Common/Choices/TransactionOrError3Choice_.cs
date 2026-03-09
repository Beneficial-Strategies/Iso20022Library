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
    /// Choice between the transaction details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(TransactionOrError3Choice.Transaction))]
    [KnownType(typeof(TransactionOrError3Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionOrError3Choice.Transaction),nameof(TransactionOrError3Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionOrError3Choice.BusinessError),nameof(TransactionOrError3Choice.BusinessError))]
    #endif
    [IsoId("_NI2W15lPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Or Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionOrError3Choice_
    #else
    public abstract partial class TransactionOrError3Choice_
    #endif
    {
    }
}
