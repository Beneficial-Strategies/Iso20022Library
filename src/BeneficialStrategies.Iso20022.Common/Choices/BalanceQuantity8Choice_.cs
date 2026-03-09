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
    /// Choice between quantity formats for the balance information.
    /// </summary>
    [KnownType(typeof(BalanceQuantity8Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceQuantity8Choice.Quantity),nameof(BalanceQuantity8Choice.Quantity))]
    [JsonDerivedType(typeof(BalanceQuantity8Choice.Proprietary),nameof(BalanceQuantity8Choice.Proprietary))]
    #endif
    [IsoId("_KPs90TnGEeWV5sr121Fc8A")]
    [DisplayName("Balance Quantity 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceQuantity8Choice_
    #else
    public abstract partial class BalanceQuantity8Choice_
    #endif
    {
    }
}
