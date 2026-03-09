// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the repurchase agreement call processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSvUtNp-Ed-ak6NoX_4Aeg_632190422")]
[Description(@"Specifies additional information about the repurchase agreement call processed instruction.")]
[DerivedFrom(typeof(RepoCallAcknowledgementReasonCode))]
public enum RepoCallAcknowledgementReason2Code
{
    /// <summary>
    /// Repurchase agreement call is in process.
    /// Encoded/decoded by serializers as &quot;CALD&quot;.
    /// </summary>
    [EnumMember(Value = "CALD")]
    [IsoId("_ZSvUtdp-Ed-ak6NoX_4Aeg_-364881931")]
    [Description(@"Repurchase agreement call is in process.")]
    InProcess = RepoCallAcknowledgementReasonCode.InProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repurchase agreement call is processed.
    /// Encoded/decoded by serializers as &quot;CALP&quot;.
    /// </summary>
    [EnumMember(Value = "CALP")]
    [IsoId("_ZSvUttp-Ed-ak6NoX_4Aeg_-478720997")]
    [Description(@"Repurchase agreement call is processed.")]
    Processed = RepoCallAcknowledgementReasonCode.Processed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_ZSvUt9p-Ed-ak6NoX_4Aeg_1840624684")]
    [Description(@"Received after the account servicer's deadline. Processed on best effort basis.")]
    AccountServicerDeadlineMissed = RepoCallAcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
}
