// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request sent for the related instruction is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z-Gl4dp-Ed-ak6NoX_4Aeg_332106838")]
[Description(
    @"Specifies the reason why a cancellation request sent for the related instruction is pending."
)]
[DerivedFrom(typeof(PendingFailingReasonCode))]
public enum PendingCancellationReason1Code
{
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Z-Gl4tp-Ed-ak6NoX_4Aeg_332106961")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting confirmation from the counterparty.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_Z-Gl49p-Ed-ak6NoX_4Aeg_332107239")]
    [Description(@"Awaiting confirmation from the counterparty.")]
    AwaitingConfirmation = PendingFailingReasonCode.AwaitingConfirmation, // same ordinal as derivation source for type conversions
}
