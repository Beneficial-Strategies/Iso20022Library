// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of withdrawal reorganisation transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Sxi5QMY0EeesocHIuVGr7g")]
[Description(@"Specifies the type of withdrawal reorganisation transaction.")]
[DerivedFrom(typeof(ReorganisationWithdrawalTransactionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReorganisationWithdrawalTransactionType1Code>))]
#endif
public enum ReorganisationWithdrawalTransactionType1Code
{
    /// <summary>
    /// The reorganisation instruction cancellation is a protect withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;PROW&quot;.
    /// </summary>
    [EnumMember(Value = "PROW")]
    [IsoId("_lB3O8cY0EeesocHIuVGr7g")]
    [Description(
        @"The reorganisation instruction cancellation is a protect withdrawal transaction."
    )]
    ProtectWithdrawalTransaction =
        ReorganisationWithdrawalTransactionTypeCode.ProtectWithdrawalTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The reorganisation instruction cancellation is a voluntary offer instruction withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;VOIW&quot;.
    /// </summary>
    [EnumMember(Value = "VOIW")]
    [IsoId("_lHqU8cY0EeesocHIuVGr7g")]
    [Description(
        @"The reorganisation instruction cancellation is a voluntary offer instruction withdrawal transaction."
    )]
    VoluntaryOfferInstructionWithdrawal =
        ReorganisationWithdrawalTransactionTypeCode.VoluntaryOfferInstructionWithdrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant.
    /// Encoded/decoded by serializers as &quot;PRPW&quot;.
    /// </summary>
    [EnumMember(Value = "PRPW")]
    [IsoId("_lNURAcY0EeesocHIuVGr7g")]
    [Description(
        @"The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant."
    )]
    WithdrawalProtectOnBehalfOfAnotherParticipant =
        ReorganisationWithdrawalTransactionTypeCode.WithdrawalProtectOnBehalfOfAnotherParticipant, // same ordinal as derivation source for type conversions
}
