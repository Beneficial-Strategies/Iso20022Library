// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVytJ9p-Ed-ak6NoX_4Aeg_-1439628964")]
[Description(
    @"Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties."
)]
[DerivedFrom(typeof(HoldingTransferableCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<HoldingTransferable1Code>))]
#endif
public enum HoldingTransferable1Code
{
    /// <summary>
    /// Transfer is allowed.
    /// Encoded/decoded by serializers as &quot;TRAL&quot;.
    /// </summary>
    [EnumMember(Value = "TRAL")]
    [IsoId("_aV8eINp-Ed-ak6NoX_4Aeg_-1077608606")]
    [Description(@"Transfer is allowed.")]
    TransferAllowed = HoldingTransferableCode.TransferAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer is not allowed.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_aV8eIdp-Ed-ak6NoX_4Aeg_-1064678911")]
    [Description(@"Transfer is not allowed.")]
    TransferNotAllowed = HoldingTransferableCode.TransferNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the operation is only possible in restricted circumstances.
    /// Encoded/decoded by serializers as &quot;RFOD&quot;.
    /// </summary>
    [EnumMember(Value = "RFOD")]
    [IsoId("_aV8eItp-Ed-ak6NoX_4Aeg_-823640508")]
    [Description(@"Indicates that the operation is only possible in restricted circumstances.")]
    ReferToFundOrderDesk = HoldingTransferableCode.ReferToFundOrderDesk, // same ordinal as derivation source for type conversions
}
