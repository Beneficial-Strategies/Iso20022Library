// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the current transaction that belongs to a sequence of transactions. Specific attributes are required for the first, the recurring and the last instructions of a series, as well as the specification of a unique transaction (one-off direct debit transaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKPgAtp-Ed-ak6NoX_4Aeg_650235099")]
[Description(
    @"Specifies the type of the current transaction that belongs to a sequence of transactions. Specific attributes are required for the first, the recurring and the last instructions of a series, as well as the specification of a unique transaction (one-off direct debit transaction)."
)]
[DerivedFrom(typeof(SequenceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SequenceType1Code>))]
#endif
public enum SequenceType1Code
{
    /// <summary>
    /// First collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as &quot;FRST&quot;.
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_ZKPgA9p-Ed-ak6NoX_4Aeg_650235429")]
    [Description(@"First collection of a series of direct debit instructions.")]
    First = SequenceTypeCode.First, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used for regular direct debit transactions initiated by the creditor.
    /// Encoded/decoded by serializers as &quot;RCUR&quot;.
    /// </summary>
    [EnumMember(Value = "RCUR")]
    [IsoId("_ZKPgBNp-Ed-ak6NoX_4Aeg_650235490")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used for regular direct debit transactions initiated by the creditor."
    )]
    Recurring = SequenceTypeCode.Recurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as &quot;FNAL&quot;.
    /// </summary>
    [EnumMember(Value = "FNAL")]
    [IsoId("_ZKPgBdp-Ed-ak6NoX_4Aeg_650235532")]
    [Description(@"Final collection of a series of direct debit instructions.")]
    Final = SequenceTypeCode.Final, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used to initiate one single direct debit transaction.
    /// Encoded/decoded by serializers as &quot;OOFF&quot;.
    /// </summary>
    [EnumMember(Value = "OOFF")]
    [IsoId("_ZKPgBtp-Ed-ak6NoX_4Aeg_650235798")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used to initiate one single direct debit transaction."
    )]
    OneOff = SequenceTypeCode.OneOff, // same ordinal as derivation source for type conversions
}
