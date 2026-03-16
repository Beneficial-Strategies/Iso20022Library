// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the current transaction that belongs to a sequence of transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t90OI1kyEeGeoaLUQk__nA_2097556198")]
[Description(
    @"Specifies the type of the current transaction that belongs to a sequence of transactions."
)]
[DerivedFrom(typeof(SequenceTypeCode))]
public enum SequenceType3Code
{
    /// <summary>
    /// First collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as &quot;FRST&quot;.
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_t90OJFkyEeGeoaLUQk__nA_908612180")]
    [Description(@"First collection of a series of direct debit instructions.")]
    First = SequenceTypeCode.First, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used for regular direct debit transactions initiated by the creditor.
    /// Encoded/decoded by serializers as &quot;RCUR&quot;.
    /// </summary>
    [EnumMember(Value = "RCUR")]
    [IsoId("_t99_IFkyEeGeoaLUQk__nA_1026483165")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used for regular direct debit transactions initiated by the creditor."
    )]
    Recurring = SequenceTypeCode.Recurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as &quot;FNAL&quot;.
    /// </summary>
    [EnumMember(Value = "FNAL")]
    [IsoId("_t99_IVkyEeGeoaLUQk__nA_-1801335368")]
    [Description(@"Final collection of a series of direct debit instructions.")]
    Final = SequenceTypeCode.Final, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used to initiate one single direct debit transaction.
    /// Encoded/decoded by serializers as &quot;OOFF&quot;.
    /// </summary>
    [EnumMember(Value = "OOFF")]
    [IsoId("_t99_IlkyEeGeoaLUQk__nA_1948646475")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used to initiate one single direct debit transaction."
    )]
    OneOff = SequenceTypeCode.OneOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection used to re-present previously reversed or returned direct debit transactions.
    /// Encoded/decoded by serializers as &quot;RPRE&quot;.
    /// </summary>
    [EnumMember(Value = "RPRE")]
    [IsoId("_t99_I1kyEeGeoaLUQk__nA_-1832965217")]
    [Description(
        @"Collection used to re-present previously reversed or returned direct debit transactions."
    )]
    Represented = SequenceTypeCode.Represented, // same ordinal as derivation source for type conversions
}
