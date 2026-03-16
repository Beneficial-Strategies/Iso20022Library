// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a once off transaction is covered or whether recurring transactions are covered.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKPgB9p-Ed-ak6NoX_4Aeg_868377274")]
[Description(
    @"Specifies whether a once off transaction is covered or whether recurring transactions are covered."
)]
[DerivedFrom(typeof(SequenceTypeCode))]
public enum SequenceType2Code
{
    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used for regular direct debit transactions initiated by the creditor.
    /// Encoded/decoded by serializers as &quot;RCUR&quot;.
    /// </summary>
    [EnumMember(Value = "RCUR")]
    [IsoId("_ZKPgCNp-Ed-ak6NoX_4Aeg_868377522")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used for regular direct debit transactions initiated by the creditor."
    )]
    Recurring = SequenceTypeCode.Recurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used to initiate one single direct debit transaction.
    /// Encoded/decoded by serializers as &quot;OOFF&quot;.
    /// </summary>
    [EnumMember(Value = "OOFF")]
    [IsoId("_ZKZRANp-Ed-ak6NoX_4Aeg_868377553")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used to initiate one single direct debit transaction."
    )]
    OneOff = SequenceTypeCode.OneOff, // same ordinal as derivation source for type conversions
}
