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
    [KnownType(typeof(TransactionIdentification1Choice.Transaction))]
    [KnownType(typeof(TransactionIdentification1Choice.MarginReporting))]
    [KnownType(typeof(TransactionIdentification1Choice.CollateralReuse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionIdentification1Choice.Transaction),nameof(TransactionIdentification1Choice.Transaction))]
    [JsonDerivedType(typeof(TransactionIdentification1Choice.MarginReporting),nameof(TransactionIdentification1Choice.MarginReporting))]
    [JsonDerivedType(typeof(TransactionIdentification1Choice.CollateralReuse),nameof(TransactionIdentification1Choice.CollateralReuse))]
    #endif
    [IsoId("_DD0DMK7LEemZxoEFHjN-AQ")]
    [DisplayName("Transaction Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionIdentification1Choice_
    #else
    public abstract partial class TransactionIdentification1Choice_
    #endif
    {
    }
}
