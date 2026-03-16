// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of withdrawal reorganisation transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FkyZgMYzEeesocHIuVGr7g")]
[Description(@"Specifies the type of withdrawal reorganisation transaction.")]
[Derivations(
    typeof(ReorganisationWithdrawalTransactionType1Code),
    typeof(ReorganisationWithdrawalTransactionType2Code)
)]
public enum ReorganisationWithdrawalTransactionTypeCode
{
    /// <summary>
    /// The reorganisation instruction cancellation is a protect withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;PROW&quot;.
    /// </summary>
    [EnumMember(Value = "PROW")]
    [IsoId("_P7H7MMYzEeesocHIuVGr7g")]
    [Description(
        @"The reorganisation instruction cancellation is a protect withdrawal transaction."
    )]
    ProtectWithdrawalTransaction,

    /// <summary>
    /// The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant.
    /// Encoded/decoded by serializers as &quot;PRPW&quot;.
    /// </summary>
    [EnumMember(Value = "PRPW")]
    [IsoId("_yM7-kMYzEeesocHIuVGr7g")]
    [Description(
        @"The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant."
    )]
    WithdrawalProtectOnBehalfOfAnotherParticipant,

    /// <summary>
    /// The reorganisation instruction cancellation is a voluntary offer instruction withdrawal transaction.
    /// Encoded/decoded by serializers as &quot;VOIW&quot;.
    /// </summary>
    [EnumMember(Value = "VOIW")]
    [IsoId("_D0o1EMY0EeesocHIuVGr7g")]
    [Description(
        @"The reorganisation instruction cancellation is a voluntary offer instruction withdrawal transaction."
    )]
    VoluntaryOfferInstructionWithdrawal,
}
