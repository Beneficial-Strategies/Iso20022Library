// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of withdrawal reorganisation transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KbAQwOcpEei5aPS232E3Mw")]
[Description(@"Specifies the type of withdrawal reorganisation transaction.")]
[DerivedFrom(typeof(ReorganisationWithdrawalTransactionTypeCode))]
public enum ReorganisationWithdrawalTransactionType2Code
{
    /// <summary>
    /// The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant.
    /// Encoded/decoded by serializers as &quot;PRPW&quot;.
    /// </summary>
    [EnumMember(Value = "PRPW")]
    [IsoId("_Nax0kecpEei5aPS232E3Mw")]
    [Description(@"The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant.")]
    WithdrawalProtectOnBehalfOfAnotherParticipant = ReorganisationWithdrawalTransactionTypeCode.WithdrawalProtectOnBehalfOfAnotherParticipant, // same ordinal as derivation source for type conversions
    
}
