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
    /// Specifies the amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [KnownType(typeof(AmountType4Choice.InstructedAmount))]
    [KnownType(typeof(AmountType4Choice.EquivalentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountType4Choice.InstructedAmount),nameof(AmountType4Choice.InstructedAmount))]
    [JsonDerivedType(typeof(AmountType4Choice.EquivalentAmount),nameof(AmountType4Choice.EquivalentAmount))]
    #endif
    [IsoId("__S0AAVkJEeSeLKjZh_lWZw")]
    [DisplayName("Amount Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountType4Choice_
    #else
    public abstract partial class AmountType4Choice_
    #endif
    {
    }
}
