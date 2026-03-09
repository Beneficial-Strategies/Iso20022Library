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
    [KnownType(typeof(SubBalanceQuantity9Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity9Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity9Choice.QuantityAndAvailability))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceQuantity9Choice.Quantity),nameof(SubBalanceQuantity9Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity9Choice.Proprietary),nameof(SubBalanceQuantity9Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceQuantity9Choice.QuantityAndAvailability),nameof(SubBalanceQuantity9Choice.QuantityAndAvailability))]
    #endif
    [IsoId("_ciAo3Ti8Eeydid5dcNPKvg")]
    [DisplayName("Sub Balance Quantity 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity9Choice_
    #else
    public abstract partial class SubBalanceQuantity9Choice_
    #endif
    {
    }
}
