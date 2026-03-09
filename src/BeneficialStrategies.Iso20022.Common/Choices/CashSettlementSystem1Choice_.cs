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
    /// Choice of format for the cash settlement system.
    /// </summary>
    [KnownType(typeof(CashSettlementSystem1Choice.Code))]
    [KnownType(typeof(CashSettlementSystem1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashSettlementSystem1Choice.Code),nameof(CashSettlementSystem1Choice.Code))]
    [JsonDerivedType(typeof(CashSettlementSystem1Choice.Proprietary),nameof(CashSettlementSystem1Choice.Proprietary))]
    #endif
    [IsoId("_Qv3Ut9p-Ed-ak6NoX_4Aeg_-955027637")]
    [DisplayName("Cash Settlement System 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashSettlementSystem1Choice_
    #else
    public abstract partial class CashSettlementSystem1Choice_
    #endif
    {
    }
}
