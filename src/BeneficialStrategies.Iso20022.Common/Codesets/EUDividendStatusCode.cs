// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aiKVONp-Ed-ak6NoX_4Aeg_235937580")]
[Description(
    @"Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments."
)]
[Derivations(typeof(EUDividendStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EUDividendStatusCode>))]
#endif
public enum EUDividendStatusCode
{
    /// <summary>
    /// Dividend is in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_aiUGMNp-Ed-ak6NoX_4Aeg_-1873978987")]
    [Description(@"Dividend is in the scope of the directive.")]
    DividendInScope,

    /// <summary>
    /// Dividend is out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;DIVO&quot;.
    /// </summary>
    [EnumMember(Value = "DIVO")]
    [IsoId("_aiUGMdp-Ed-ak6NoX_4Aeg_-1873978970")]
    [Description(@"Dividend is out of the scope of the directive.")]
    DividendOutScope,

    /// <summary>
    /// Unknown whether the dividend is in or out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aiUGMtp-Ed-ak6NoX_4Aeg_-1873978935")]
    [Description(@"Unknown whether the dividend is in or out of the scope of the directive.")]
    DividendUnknown,
}
