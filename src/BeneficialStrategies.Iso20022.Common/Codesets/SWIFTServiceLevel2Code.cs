// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code identifying which SWIFT service level applies to the payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZRGV9Np-Ed-ak6NoX_4Aeg_1129333378")]
[Description(@"Code identifying which SWIFT service level applies to the payment instruction.")]
[DerivedFrom(typeof(SWIFTServiceLevelCode))]
public enum SWIFTServiceLevel2Code
{
    /// <summary>
    /// Credit transfer is to be processed according to the SWIFTPay Service Level.
    /// Encoded/decoded by serializers as &quot;SPAY&quot;.
    /// </summary>
    [EnumMember(Value = "SPAY")]
    [IsoId("_ZRGV9dp-Ed-ak6NoX_4Aeg_1129333388")]
    [Description(@"Credit transfer is to be processed according to the SWIFTPay Service Level.")]
    SWIFTPay = SWIFTServiceLevelCode.SWIFTPay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transfer is to be processed according to the Standard Service Level.
    /// Encoded/decoded by serializers as &quot;SSTD&quot;.
    /// </summary>
    [EnumMember(Value = "SSTD")]
    [IsoId("_ZRGV9tp-Ed-ak6NoX_4Aeg_1129333389")]
    [Description(@"Credit transfer is to be processed according to the Standard Service Level.")]
    Standard = SWIFTServiceLevelCode.Standard, // same ordinal as derivation source for type conversions
    
}
