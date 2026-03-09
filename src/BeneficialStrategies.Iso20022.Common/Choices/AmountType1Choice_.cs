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
    /// Amount of money to be transferred between the debtor and creditor, expressed in debtor&apos;s account currency or converted in another currency.
    /// </summary>
    [KnownType(typeof(AmountType1Choice.InstructedAmount))]
    [KnownType(typeof(AmountType1Choice.EquivalentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountType1Choice.InstructedAmount),nameof(AmountType1Choice.InstructedAmount))]
    [JsonDerivedType(typeof(AmountType1Choice.EquivalentAmount),nameof(AmountType1Choice.EquivalentAmount))]
    #endif
    [IsoId("_PrUuhtp-Ed-ak6NoX_4Aeg_-1333132724")]
    [DisplayName("Amount Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountType1Choice_
    #else
    public abstract partial class AmountType1Choice_
    #endif
    {
    }
}
