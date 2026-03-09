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
    /// Set of elements identifying the price information related to the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionPrice1Choice.DealPrice))]
    [KnownType(typeof(TransactionPrice1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionPrice1Choice.DealPrice),nameof(TransactionPrice1Choice.DealPrice))]
    [JsonDerivedType(typeof(TransactionPrice1Choice.Proprietary),nameof(TransactionPrice1Choice.Proprietary))]
    #endif
    [IsoId("_RUrR9Np-Ed-ak6NoX_4Aeg_1516952051")]
    [DisplayName("Transaction Price 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionPrice1Choice_
    #else
    public abstract partial class TransactionPrice1Choice_
    #endif
    {
    }
}
