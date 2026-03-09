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
    [KnownType(typeof(SubBalanceQuantity3Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity3Choice.Proprietary))]
    [KnownType(typeof(SubBalanceQuantity3Choice.QuantityAndAvailability))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceQuantity3Choice.Quantity),nameof(SubBalanceQuantity3Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity3Choice.Proprietary),nameof(SubBalanceQuantity3Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceQuantity3Choice.QuantityAndAvailability),nameof(SubBalanceQuantity3Choice.QuantityAndAvailability))]
    #endif
    [IsoId("_QYLNfNp-Ed-ak6NoX_4Aeg_-1938942383")]
    [DisplayName("Sub Balance Quantity 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity3Choice_
    #else
    public abstract partial class SubBalanceQuantity3Choice_
    #endif
    {
    }
}
