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
    [KnownType(typeof(AmountType3Choice.InstructedAmount))]
    [KnownType(typeof(AmountType3Choice.EquivalentAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AmountType3Choice.InstructedAmount),nameof(AmountType3Choice.InstructedAmount))]
    [JsonDerivedType(typeof(AmountType3Choice.EquivalentAmount),nameof(AmountType3Choice.EquivalentAmount))]
    #endif
    [IsoId("_P57LMNp-Ed-ak6NoX_4Aeg_326234878")]
    [DisplayName("Amount Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AmountType3Choice_
    #else
    public abstract partial class AmountType3Choice_
    #endif
    {
    }
}
