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
    [KnownType(typeof(SubBalanceQuantity5Choice.Quantity))]
    [KnownType(typeof(SubBalanceQuantity5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SubBalanceQuantity5Choice.Quantity),nameof(SubBalanceQuantity5Choice.Quantity))]
    [JsonDerivedType(typeof(SubBalanceQuantity5Choice.Proprietary),nameof(SubBalanceQuantity5Choice.Proprietary))]
    #endif
    [IsoId("_01_3kYjvEeONZKAAW4pOaQ")]
    [DisplayName("Sub Balance Quantity 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SubBalanceQuantity5Choice_
    #else
    public abstract partial class SubBalanceQuantity5Choice_
    #endif
    {
    }
}
