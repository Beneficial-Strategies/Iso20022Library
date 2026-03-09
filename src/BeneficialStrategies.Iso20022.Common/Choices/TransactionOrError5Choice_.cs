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
    [KnownType(typeof(TransactionOrError5Choice.Transaction))]
    [KnownType(typeof(TransactionOrError5Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionOrError5Choice.Transaction),nameof(TransactionOrError5Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionOrError5Choice.BusinessError),nameof(TransactionOrError5Choice.BusinessError))]
    #endif
    [IsoId("_dmIBNdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Or Error 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionOrError5Choice_
    #else
    public abstract partial class TransactionOrError5Choice_
    #endif
    {
    }
}
