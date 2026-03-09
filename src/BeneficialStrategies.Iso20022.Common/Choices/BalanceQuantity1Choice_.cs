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
    /// Choice between formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity1Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity1Choice.QuantityAsDSS))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceQuantity1Choice.Quantity),nameof(BalanceQuantity1Choice.Quantity))]
    [JsonDerivedType(typeof(BalanceQuantity1Choice.QuantityAsDSS),nameof(BalanceQuantity1Choice.QuantityAsDSS))]
    #endif
    [IsoId("_RCDQ59p-Ed-ak6NoX_4Aeg_695361822")]
    [DisplayName("Balance Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceQuantity1Choice_
    #else
    public abstract partial class BalanceQuantity1Choice_
    #endif
    {
    }
}
