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
    [KnownType(typeof(BalanceQuantity12Choice.Quantity))]
    [KnownType(typeof(BalanceQuantity12Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceQuantity12Choice.Quantity),nameof(BalanceQuantity12Choice.Quantity))]
    [JsonDerivedType(typeof(BalanceQuantity12Choice.Proprietary),nameof(BalanceQuantity12Choice.Proprietary))]
    #endif
    [IsoId("_5eTeU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Balance Quantity 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceQuantity12Choice_
    #else
    public abstract partial class BalanceQuantity12Choice_
    #endif
    {
    }
}
