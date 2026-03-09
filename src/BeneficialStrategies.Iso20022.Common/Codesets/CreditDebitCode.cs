// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is an increase or a decrease.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTfEdtp-Ed-ak6NoX_4Aeg_826087773")]
[Description(@"Specifies if an operation is an increase or a decrease.")]
[DerivedFrom(typeof(AmountDirectionCode))]
public enum CreditDebitCode
{
    /// <summary>
    /// Operation is an increase.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_bTfEd9p-Ed-ak6NoX_4Aeg_-635010261")]
    [Description(@"Operation is an increase.")]
    Credit = AmountDirectionCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Operation is a decrease.
    /// Encoded/decoded by serializers as &quot;DBIT&quot;.
    /// </summary>
    [EnumMember(Value = "DBIT")]
    [IsoId("_bTfEeNp-Ed-ak6NoX_4Aeg_-610075163")]
    [Description(@"Operation is a decrease.")]
    Debit = AmountDirectionCode.Debit, // same ordinal as derivation source for type conversions
    
}
