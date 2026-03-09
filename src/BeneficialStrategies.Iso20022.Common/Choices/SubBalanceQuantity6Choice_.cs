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
    [KnownType(typeof(SubBalanceQuantity6Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity6Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity6Choice.QuantityAndAvailability))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceQuantity6Choice.Quantity),nameof(SubBalanceQuantity6Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity6Choice.Proprietary),nameof(SubBalanceQuantity6Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceQuantity6Choice.QuantityAndAvailability),nameof(SubBalanceQuantity6Choice.QuantityAndAvailability))]
    #endif
    [IsoId("_MLLzLznGEeWV5sr121Fc8A")]
    [DisplayName("Sub Balance Quantity 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity6Choice_
    #else
    public abstract partial class SubBalanceQuantity6Choice_
    #endif
    {
    }
}
