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
    [KnownType(typeof(TransactionQuantities2Choice.Quantity))]
    [KnownType(typeof(TransactionQuantities2Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(TransactionQuantities2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionQuantities2Choice.Quantity),nameof(TransactionQuantities2Choice.Quantity))]
    [JsonDerivedType(typeof(TransactionQuantities2Choice.OriginalAndCurrentFaceAmount),nameof(TransactionQuantities2Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(TransactionQuantities2Choice.Proprietary),nameof(TransactionQuantities2Choice.Proprietary))]
    #endif
    [IsoId("_tqJEMVkyEeGeoaLUQk__nA_658347651")]
    [DisplayName("Transaction Quantities 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionQuantities2Choice_
    #else
    public abstract partial class TransactionQuantities2Choice_
    #endif
    {
    }
}
