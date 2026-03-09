// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aiBLR9p-Ed-ak6NoX_4Aeg_-993643887")]
[Description(@"Specifies whether capital gain is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June) for an income realised upon sale, a refund or redemption of shares and units etc.")]
[Derivations(typeof(EUCapitalGain1Code),typeof(EUCapitalGain2Code))]
public enum EUCapitalGainCode
{
    /// <summary>
    /// Capital gain is in the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSI&quot;.
    /// </summary>
    [EnumMember(Value = "EUSI")]
    [IsoId("_aiKVMNp-Ed-ak6NoX_4Aeg_-950239779")]
    [Description(@"Capital gain is in the scope of the directive.")]
    CapitalGainInScope,
    
    /// <summary>
    /// Capital gain is out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;EUSO&quot;.
    /// </summary>
    [EnumMember(Value = "EUSO")]
    [IsoId("_aiKVMdp-Ed-ak6NoX_4Aeg_-910528455")]
    [Description(@"Capital gain is out of the scope of the directive.")]
    CapitalGainOutScope,
    
    /// <summary>
    /// Unknown whether capital gain is in or out of the scope of the directive.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aiKVMtp-Ed-ak6NoX_4Aeg_-895750739")]
    [Description(@"Unknown whether capital gain is in or out of the scope of the directive.")]
    CapitalGainUnknown,
    
    /// <summary>
    /// Another type of EU capital gain.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aiKVM9p-Ed-ak6NoX_4Aeg_-1663687360")]
    [Description(@"Another type of EU capital gain.")]
    Other,
    
}
