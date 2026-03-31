// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z-Gl5Np-Ed-ak6NoX_4Aeg_608029284")]
[Description(
    @"Specifies the reason why a cancellation request sent for the related instruction is pending."
)]
[DerivedFrom(typeof(PendingFailingReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PendingCancellationReason2Code>))]
#endif
public enum PendingCancellationReason2Code
{
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Z-Gl5dp-Ed-ak6NoX_4Aeg_608029315")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Prior payment credited to account based contractual income collection agreement has been collected from issuer.
    /// Encoded/decoded by serializers as &quot;PCNF&quot;.
    /// </summary>
    [EnumMember(Value = "PCNF")]
    [IsoId("_Z-Gl5tp-Ed-ak6NoX_4Aeg_608031128")]
    [Description(
        @"Prior payment credited to account based contractual income collection agreement has been collected from issuer."
    )]
    ConfirmationOfPayment = PendingFailingReasonCode.ConfirmationOfPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instruments does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_Z-Gl59p-Ed-ak6NoX_4Aeg_608031188")]
    [Description(@"Quantity of financial instruments does not match.")]
    QuantityDisagreement = PendingFailingReasonCode.QuantityDisagreement, // same ordinal as derivation source for type conversions
}
