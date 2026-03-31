// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zzq3hNp-Ed-ak6NoX_4Aeg_-967340295")]
[Description(
    @"Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer."
)]
[Derivations(typeof(Payment1Code), typeof(Payment2Code))]
public enum PaymentCode
{
    /// <summary>
    /// The cash payment occurs or will occur upon receipt of proceeds from the issuer.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Zzq3hdp-Ed-ak6NoX_4Aeg_620523180")]
    [Description(
        @"The cash payment occurs or will occur upon receipt of proceeds from the issuer."
    )]
    ActualPayment,

    /// <summary>
    /// The cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer.
    /// Encoded/decoded by serializers as &quot;CONT&quot;.
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_Zzq3htp-Ed-ak6NoX_4Aeg_644534333")]
    [Description(
        @"The cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer."
    )]
    ContractualPayment,
}
