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
    [KnownType(typeof(SubBalanceQuantity2Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity2Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity2Choice.QuantityAndAvailability))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceQuantity2Choice.Quantity),nameof(SubBalanceQuantity2Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity2Choice.Proprietary),nameof(SubBalanceQuantity2Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceQuantity2Choice.QuantityAndAvailability),nameof(SubBalanceQuantity2Choice.QuantityAndAvailability))]
    #endif
    [IsoId("_QZhRQ9p-Ed-ak6NoX_4Aeg_-1518979215")]
    [DisplayName("Sub Balance Quantity 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity2Choice_
    #else
    public abstract partial class SubBalanceQuantity2Choice_
    #endif
    {
    }
}
