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
    [KnownType(typeof(SubBalanceQuantity1Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity1Choice.QuantityAsDSS))]
    [KnownType(typeof(SubBalanceQuantity1Choice.QuantityAndAvailability))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceQuantity1Choice.Quantity),nameof(SubBalanceQuantity1Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity1Choice.QuantityAsDSS),nameof(SubBalanceQuantity1Choice.QuantityAsDSS))]
    [JsonDerivedType(typeof(SubBalanceQuantity1Choice.QuantityAndAvailability),nameof(SubBalanceQuantity1Choice.QuantityAndAvailability))]
    #endif
    [IsoId("_QYn5aNp-Ed-ak6NoX_4Aeg_-1945125702")]
    [DisplayName("Sub Balance Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity1Choice_
    #else
    public abstract partial class SubBalanceQuantity1Choice_
    #endif
    {
    }
}
