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
    [KnownType(typeof(TransactionOrError4Choice.Transaction))]
    [KnownType(typeof(TransactionOrError4Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionOrError4Choice.Transaction),nameof(TransactionOrError4Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionOrError4Choice.BusinessError),nameof(TransactionOrError4Choice.BusinessError))]
    #endif
    [IsoId("_W6b5V249EeiU9cctagi5ow")]
    [DisplayName("Transaction Or Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionOrError4Choice_
    #else
    public abstract partial class TransactionOrError4Choice_
    #endif
    {
    }
}
