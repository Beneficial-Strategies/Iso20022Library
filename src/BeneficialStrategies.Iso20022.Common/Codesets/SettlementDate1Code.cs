// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the date of settlement in coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZK_t9tp-Ed-ak6NoX_4Aeg_581713028")]
[Description(@"Indicates the date of settlement in coded form.")]
[DerivedFrom(typeof(SettlementDateCode))]
public enum SettlementDate1Code
{
    /// <summary>
    /// Transfer is to be effected as soon as possible.
    /// Encoded/decoded by serializers as &quot;ASAP&quot;.
    /// </summary>
    [EnumMember(Value = "ASAP")]
    [IsoId("_ZK_t99p-Ed-ak6NoX_4Aeg_581713029")]
    [Description(@"Transfer is to be effected as soon as possible.")]
    AsSoonAsPossible = SettlementDateCode.AsSoonAsPossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer is to be effected at the end of the contract.
    /// Encoded/decoded by serializers as &quot;ENDC&quot;.
    /// </summary>
    [EnumMember(Value = "ENDC")]
    [IsoId("_ZK_t-Np-Ed-ak6NoX_4Aeg_581713038")]
    [Description(@"Transfer is to be effected at the end of the contract.")]
    AtEndOfContract = SettlementDateCode.AtEndOfContract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement takes place when the financial instrument is issued by the issuer.
    /// Encoded/decoded by serializers as &quot;WHIF&quot;.
    /// </summary>
    [EnumMember(Value = "WHIF")]
    [IsoId("_ZLI34Np-Ed-ak6NoX_4Aeg_-732074064")]
    [Description(@"Settlement takes place when the financial instrument is issued by the issuer.")]
    WhenAndIfIssued = SettlementDateCode.WhenAndIfIssued, // same ordinal as derivation source for type conversions
    
}
