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
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction1Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction1Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction1Choice.StatementEntry))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingTransaction1Choice.Initiation),nameof(UnderlyingTransaction1Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction1Choice.Interbank),nameof(UnderlyingTransaction1Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction1Choice.StatementEntry),nameof(UnderlyingTransaction1Choice.StatementEntry))]
    #endif
    [IsoId("_P9DXuNp-Ed-ak6NoX_4Aeg_-2030379979")]
    [DisplayName("Underlying Transaction 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingTransaction1Choice_
    #else
    public abstract partial class UnderlyingTransaction1Choice_
    #endif
    {
    }
}
