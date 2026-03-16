// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the statement contains missing instructions only or all instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mALAbtEEeilsanBGAzy4A")]
[Description(
    @"Indicates whether the statement contains missing instructions only or all instructions."
)]
[DerivedFrom(typeof(CorporateActionStatementTypeCode))]
public enum CorporateActionStatementType2Code
{
    /// <summary>
    /// Statement contains missing instructions.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_03aEEbtEEeilsanBGAzy4A")]
    [Description(@"Statement contains missing instructions.")]
    Missing = CorporateActionStatementTypeCode.Missing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Statement contains all instructions.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_03aEE7tEEeilsanBGAzy4A")]
    [Description(@"Statement contains all instructions.")]
    All = CorporateActionStatementTypeCode.All, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance information with no instruction details provided.
    /// Encoded/decoded by serializers as &quot;BALO&quot;.
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_WIwwAbtFEeilsanBGAzy4A")]
    [Description(@"Balance information with no instruction details provided.")]
    BalanceOnlyNotification = CorporateActionStatementTypeCode.BalanceOnlyNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance information with instruction details.
    /// Encoded/decoded by serializers as &quot;BALI&quot;.
    /// </summary>
    [EnumMember(Value = "BALI")]
    [IsoId("_WSKjortFEeilsanBGAzy4A")]
    [Description(@"Balance information with instruction details.")]
    BalanceInformation = CorporateActionStatementTypeCode.BalanceInformation, // same ordinal as derivation source for type conversions
}
