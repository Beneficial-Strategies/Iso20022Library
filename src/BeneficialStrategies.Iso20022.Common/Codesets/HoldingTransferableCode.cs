// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aV8eI9p-Ed-ak6NoX_4Aeg_1872710990")]
[Description(
    @"Indicate whether or not registered investors are able to transfer some or all of their holdings to third parties."
)]
[Derivations(typeof(HoldingTransferable1Code), typeof(ReferToFundOrderDesk1Code))]
public enum HoldingTransferableCode
{
    /// <summary>
    /// Transfer is allowed.
    /// Encoded/decoded by serializers as &quot;TRAL&quot;.
    /// </summary>
    [EnumMember(Value = "TRAL")]
    [IsoId("_aV8eJNp-Ed-ak6NoX_4Aeg_1901341697")]
    [Description(@"Transfer is allowed.")]
    TransferAllowed,

    /// <summary>
    /// Transfer is not allowed.
    /// Encoded/decoded by serializers as &quot;TRNA&quot;.
    /// </summary>
    [EnumMember(Value = "TRNA")]
    [IsoId("_aV8eJdp-Ed-ak6NoX_4Aeg_1926274407")]
    [Description(@"Transfer is not allowed.")]
    TransferNotAllowed,

    /// <summary>
    /// Indicates that the operation is only possible in restricted circumstances.
    /// Encoded/decoded by serializers as &quot;RFOD&quot;.
    /// </summary>
    [EnumMember(Value = "RFOD")]
    [IsoId("_aV8eJtp-Ed-ak6NoX_4Aeg_-1992820992")]
    [Description(@"Indicates that the operation is only possible in restricted circumstances.")]
    ReferToFundOrderDesk,
}
