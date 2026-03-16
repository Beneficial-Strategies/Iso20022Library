// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the repurchase agreement call processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZwscANp-Ed-ak6NoX_4Aeg_1866536533")]
[Description(
    @"Specifies additional information about the repurchase agreement call processed instruction."
)]
[DerivedFrom(typeof(RepoCallAcknowledgementReasonCode))]
public enum RepoCallAcknowledgementReason1Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZwscAdp-Ed-ak6NoX_4Aeg_1866536563")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = RepoCallAcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase agreement call is in process.
    /// Encoded/decoded by serializers as &quot;CALD&quot;.
    /// </summary>
    [EnumMember(Value = "CALD")]
    [IsoId("_ZwscAtp-Ed-ak6NoX_4Aeg_1866536564")]
    [Description(@"Repurchase agreement call is in process.")]
    InProcess = RepoCallAcknowledgementReasonCode.InProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase agreement call is issued.
    /// Encoded/decoded by serializers as &quot;CALI&quot;.
    /// </summary>
    [EnumMember(Value = "CALI")]
    [IsoId("_ZwscA9p-Ed-ak6NoX_4Aeg_1866536594")]
    [Description(@"Repurchase agreement call is issued.")]
    Issued = RepoCallAcknowledgementReasonCode.Issued, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase agreement call is processed.
    /// Encoded/decoded by serializers as &quot;CALP&quot;.
    /// </summary>
    [EnumMember(Value = "CALP")]
    [IsoId("_ZwscBNp-Ed-ak6NoX_4Aeg_1866536595")]
    [Description(@"Repurchase agreement call is processed.")]
    Processed = RepoCallAcknowledgementReasonCode.Processed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repurchase agreement call request is being processed.
    /// Encoded/decoded by serializers as &quot;CALR&quot;.
    /// </summary>
    [EnumMember(Value = "CALR")]
    [IsoId("_ZwscBdp-Ed-ak6NoX_4Aeg_1866536873")]
    [Description(@"Repurchase agreement call request is being processed.")]
    BeingProcessed = RepoCallAcknowledgementReasonCode.BeingProcessed, // same ordinal as derivation source for type conversions
}
