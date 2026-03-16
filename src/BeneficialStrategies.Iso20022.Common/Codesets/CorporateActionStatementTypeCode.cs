// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the statement contains missing instructions only or all instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTMJhdp-Ed-ak6NoX_4Aeg_-454336053")]
[Description(
    @"Indicates whether the statement contains missing instructions only or all instructions."
)]
[Derivations(typeof(CorporateActionStatementType1Code), typeof(CorporateActionStatementType2Code))]
public enum CorporateActionStatementTypeCode
{
    /// <summary>
    /// Statement contains missing instructions.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_bTMJhtp-Ed-ak6NoX_4Aeg_-454336023")]
    [Description(@"Statement contains missing instructions.")]
    Missing,

    /// <summary>
    /// Statement contains all instructions.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_bTMJh9p-Ed-ak6NoX_4Aeg_-454335992")]
    [Description(@"Statement contains all instructions.")]
    All,

    /// <summary>
    /// Balance information with no instruction details provided.
    /// Encoded/decoded by serializers as &quot;BALO&quot;.
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_8PcooLtEEeilsanBGAzy4A")]
    [Description(@"Balance information with no instruction details provided.")]
    BalanceOnlyNotification,

    /// <summary>
    /// Balance information with instruction details.
    /// Encoded/decoded by serializers as &quot;BALI&quot;.
    /// </summary>
    [EnumMember(Value = "BALI")]
    [IsoId("_NMpwoLtFEeilsanBGAzy4A")]
    [Description(@"Balance information with instruction details.")]
    BalanceInformation,
}
