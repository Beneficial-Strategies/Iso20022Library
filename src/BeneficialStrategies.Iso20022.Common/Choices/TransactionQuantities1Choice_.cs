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
    /// Specifies the quantities (eg of securities) in the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionQuantities1Choice.Quantity))]
    [KnownType(typeof(TransactionQuantities1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionQuantities1Choice.Quantity),nameof(TransactionQuantities1Choice.Quantity))]
    [JsonDerivedType(typeof(TransactionQuantities1Choice.Proprietary),nameof(TransactionQuantities1Choice.Proprietary))]
    #endif
    [IsoId("_RU0b5tp-Ed-ak6NoX_4Aeg_-584387568")]
    [DisplayName("Transaction Quantities 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionQuantities1Choice_
    #else
    public abstract partial class TransactionQuantities1Choice_
    #endif
    {
    }
}
