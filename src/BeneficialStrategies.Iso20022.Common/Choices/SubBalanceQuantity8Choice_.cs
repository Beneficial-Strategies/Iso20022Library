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
    [KnownType(typeof(SubBalanceQuantity8Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity8Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity8Choice.QuantityAndAvailability))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceQuantity8Choice.Quantity),nameof(SubBalanceQuantity8Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity8Choice.Proprietary),nameof(SubBalanceQuantity8Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceQuantity8Choice.QuantityAndAvailability),nameof(SubBalanceQuantity8Choice.QuantityAndAvailability))]
    #endif
    [IsoId("_kcwoQSp8EeyR9JrVGfaMKw")]
    [DisplayName("Sub Balance Quantity 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity8Choice_
    #else
    public abstract partial class SubBalanceQuantity8Choice_
    #endif
    {
    }
}
