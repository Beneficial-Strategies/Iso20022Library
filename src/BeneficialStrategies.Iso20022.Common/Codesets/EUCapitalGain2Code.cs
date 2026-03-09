// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aiBLQ9p-Ed-ak6NoX_4Aeg_1447392602")]
[Description(@"Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.")]
[DerivedFrom(typeof(EUCapitalGainCode))]
public enum EUCapitalGain2Code
{
    /// <summary>
    /// Capital gain is in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSI&quot;.
    /// </summary>
    [EnumMember(Value = "EUSI")]
    [IsoId("_aiBLRNp-Ed-ak6NoX_4Aeg_1764162246")]
    [Description(@"Capital gain is in the scope of the directive.")]
    CapitalGainInScope = EUCapitalGainCode.CapitalGainInScope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Capital gain is out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSO&quot;.
    /// </summary>
    [EnumMember(Value = "EUSO")]
    [IsoId("_aiBLRdp-Ed-ak6NoX_4Aeg_1764162306")]
    [Description(@"Capital gain is out of the scope of the directive.")]
    CapitalGainOutScope = EUCapitalGainCode.CapitalGainOutScope, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown whether capital gain is in or out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aiBLRtp-Ed-ak6NoX_4Aeg_1764162323")]
    [Description(@"Unknown whether capital gain is in or out of the scope of the directive.")]
    CapitalGainUnknown = EUCapitalGainCode.CapitalGainUnknown, // same ordinal as derivation source for type conversions
    
}
