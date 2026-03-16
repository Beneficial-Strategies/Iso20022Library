// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is the result of a reversal operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-Bo8tp-Ed-ak6NoX_4Aeg_450609101")]
[Description(@"Specifies if an operation is the result of a reversal operation.")]
[DerivedFrom(typeof(AmountDirectionCode))]
public enum ReversalCode
{
    /// <summary>
    /// Debit entry used to reverse a previously booked credit entry.
    /// Encoded/decoded by serializers as &quot;RVCD&quot;.
    /// </summary>
    [EnumMember(Value = "RVCD")]
    [IsoId("_Y-Bo89p-Ed-ak6NoX_4Aeg_499553797")]
    [Description(@"Debit entry used to reverse a previously booked credit entry.")]
    ReversalCredit = AmountDirectionCode.ReversalCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Credit entry used to reverse a previously booked debit entry.
    /// Encoded/decoded by serializers as &quot;RVDB&quot;.
    /// </summary>
    [EnumMember(Value = "RVDB")]
    [IsoId("_Y-Bo9Np-Ed-ak6NoX_4Aeg_499553857")]
    [Description(@"Credit entry used to reverse a previously booked debit entry.")]
    ReversalDebit = AmountDirectionCode.ReversalDebit, // same ordinal as derivation source for type conversions
}
