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
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References1Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References1Choice.PoolIdentification))]
    [KnownType(typeof(References1Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References1Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References1Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References1Choice.SecuritiesSettlementTransactionIdentification),nameof(References1Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References1Choice.PoolIdentification),nameof(References1Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References1Choice.IntraPositionMovementIdentification),nameof(References1Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References1Choice.AccountServicerTransactionIdentification),nameof(References1Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References1Choice.OtherTransactionIdentification),nameof(References1Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_USg8Fdp-Ed-ak6NoX_4Aeg_-441351742")]
    [DisplayName("References 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References1Choice_
    #else
    public abstract partial class References1Choice_
    #endif
    {
    }
}
