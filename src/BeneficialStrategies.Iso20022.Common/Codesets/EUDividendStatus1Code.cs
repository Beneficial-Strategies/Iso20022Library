// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aiKVNNp-Ed-ak6NoX_4Aeg_234091620")]
[Description(@"Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.")]
[DerivedFrom(typeof(EUDividendStatusCode))]
public enum EUDividendStatus1Code
{
    /// <summary>
    /// Dividend is in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_aiKVNdp-Ed-ak6NoX_4Aeg_1079111436")]
    [Description(@"Dividend is in the scope of the directive.")]
    DividendInScope = EUDividendStatusCode.DividendInScope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend is out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;DIVO&quot;.
    /// </summary>
    [EnumMember(Value = "DIVO")]
    [IsoId("_aiKVNtp-Ed-ak6NoX_4Aeg_1080036251")]
    [Description(@"Dividend is out of the scope of the directive.")]
    DividendOutScope = EUDividendStatusCode.DividendOutScope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown whether the dividend is in or out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aiKVN9p-Ed-ak6NoX_4Aeg_1080960307")]
    [Description(@"Unknown whether the dividend is in or out of the scope of the directive.")]
    DividendUnknown = EUDividendStatusCode.DividendUnknown, // same ordinal as derivation source for type conversions
    
}
