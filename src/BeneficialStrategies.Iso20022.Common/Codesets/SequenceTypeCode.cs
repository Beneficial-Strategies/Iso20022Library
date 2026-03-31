// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the current transaction that belongs to a sequence of transactions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZKZRAdp-Ed-ak6NoX_4Aeg_195863481")]
[Description(
    @"Specifies the type of the current transaction that belongs to a sequence of transactions."
)]
[Derivations(typeof(SequenceType1Code), typeof(SequenceType3Code), typeof(SequenceType2Code))]
public enum SequenceTypeCode
{
    /// <summary>
    /// First collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as &quot;FRST&quot;.
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_ZKZRAtp-Ed-ak6NoX_4Aeg_249427417")]
    [Description(@"First collection of a series of direct debit instructions.")]
    First,

    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used for regular direct debit transactions initiated by the creditor.
    /// Encoded/decoded by serializers as &quot;RCUR&quot;.
    /// </summary>
    [EnumMember(Value = "RCUR")]
    [IsoId("_ZKZRA9p-Ed-ak6NoX_4Aeg_492312855")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used for regular direct debit transactions initiated by the creditor."
    )]
    Recurring,

    /// <summary>
    /// Final collection of a series of direct debit instructions.
    /// Encoded/decoded by serializers as &quot;FNAL&quot;.
    /// </summary>
    [EnumMember(Value = "FNAL")]
    [IsoId("_ZKZRBNp-Ed-ak6NoX_4Aeg_264204564")]
    [Description(@"Final collection of a series of direct debit instructions.")]
    Final,

    /// <summary>
    /// Direct debit instruction where the debtor&apos;s authorisation is used to initiate one single direct debit transaction.
    /// Encoded/decoded by serializers as &quot;OOFF&quot;.
    /// </summary>
    [EnumMember(Value = "OOFF")]
    [IsoId("_ZKZRBdp-Ed-ak6NoX_4Aeg_567117639")]
    [Description(
        @"Direct debit instruction where the debtor's authorisation is used to initiate one single direct debit transaction."
    )]
    OneOff,

    /// <summary>
    /// Collection used to re-present previously reversed or returned direct debit transactions.
    /// Encoded/decoded by serializers as &quot;RPRE&quot;.
    /// </summary>
    [EnumMember(Value = "RPRE")]
    [IsoId("_t90OIlkyEeGeoaLUQk__nA_1851628055")]
    [Description(
        @"Collection used to re-present previously reversed or returned direct debit transactions."
    )]
    Represented,
}
