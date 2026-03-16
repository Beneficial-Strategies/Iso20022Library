// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GbRzsAF1EeutW5-TpeYJhA")]
[Description(
    @"Specifies the status of the settlement of a trade in a central matching and settlement system."
)]
[DerivedFrom(typeof(SettlementStatusCode))]
public enum SettlementStatus3Code
{
    /// <summary>
    /// Settlement is accepted for settlement.
    /// Encoded/decoded by serializers as &quot;ASTL&quot;.
    /// </summary>
    [EnumMember(Value = "ASTL")]
    [IsoId("_IFf50QF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is accepted for settlement.")]
    AcceptedForSettlement = SettlementStatusCode.AcceptedForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is awaiting authorisation.
    /// Encoded/decoded by serializers as &quot;AAUT&quot;.
    /// </summary>
    [EnumMember(Value = "AAUT")]
    [IsoId("_IKQeAQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is awaiting authorisation.")]
    AwaitingAuthorisation = SettlementStatusCode.AwaitingAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is awaiting confirmation of creation.
    /// Encoded/decoded by serializers as &quot;ACCF&quot;.
    /// </summary>
    [EnumMember(Value = "ACCF")]
    [IsoId("_IOk9UQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is awaiting confirmation of creation.")]
    AwaitingCreationConfirmation = SettlementStatusCode.AwaitingCreationConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is awaiting confirmation of rescind.
    /// Encoded/decoded by serializers as &quot;ARCF&quot;.
    /// </summary>
    [EnumMember(Value = "ARCF")]
    [IsoId("_IScJoQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is awaiting confirmation of rescind.")]
    AwaitingRescindConfirmation = SettlementStatusCode.AwaitingRescindConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is matched.
    /// Encoded/decoded by serializers as &quot;MTCH&quot;.
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_IWwo8QF1EeutW5-TpeYJhA")]
    [Description(@"Instruction is matched.")]
    Matched = SettlementStatusCode.Matched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Part, but not all, of a Trade&apos;s value has settled, and no further elements of the Trade&apos;s value are expected to be settled.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_IaxmQQF1EeutW5-TpeYJhA")]
    [Description(
        @"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled."
    )]
    PartiallySettled = SettlementStatusCode.PartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_IfPPgQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is rejected.")]
    Rejected = SettlementStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_IjQM0QF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is complete.")]
    Settled = SettlementStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement has been created.
    /// Encoded/decoded by serializers as &quot;STCR&quot;.
    /// </summary>
    [EnumMember(Value = "STCR")]
    [IsoId("_InRKIQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement has been created.")]
    SettlementTransactionCreated = SettlementStatusCode.SettlementTransactionCreated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is split.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_IruzYQF1EeutW5-TpeYJhA")]
    [Description(@"Settlement is split.")]
    Split = SettlementStatusCode.Split, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is unmatched.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_Ix1bYQF1EeutW5-TpeYJhA")]
    [Description(@"Instruction is unmatched.")]
    Unmatched = SettlementStatusCode.Unmatched, // same ordinal as derivation source for type conversions
}
