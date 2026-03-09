// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an mission allowance type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e3GDEGlHEeaLAKoEUNsD9g")]
[Description(@"Specifies an mission allowance type.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum EmissionAllowanceProductType2Code
{
    /// <summary>
    /// Commodity attribute of type emissions allowance CER (Certified Emission Reduction).
    /// Encoded/decoded by serializers as &quot;CERE&quot;.
    /// </summary>
    [EnumMember(Value = "CERE")]
    [IsoId("_mibXEWlHEeaLAKoEUNsD9g")]
    [Description(@"Commodity attribute of type emissions allowance CER (Certified Emission Reduction).")]
    CER = AssetClassDetailedSubProductTypeCode.CER, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type emissions allowance ERU (European Reduction Unit).
    /// Encoded/decoded by serializers as &quot;ERUE&quot;.
    /// </summary>
    [EnumMember(Value = "ERUE")]
    [IsoId("_m3pZIWlHEeaLAKoEUNsD9g")]
    [Description(@"Commodity attribute of type emissions allowance ERU (European Reduction Unit).")]
    ERU = AssetClassDetailedSubProductTypeCode.ERU, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type emissions allowance EUA (European Union Allowance).
    /// Encoded/decoded by serializers as &quot;EUAE&quot;.
    /// </summary>
    [EnumMember(Value = "EUAE")]
    [IsoId("_nHB48WlHEeaLAKoEUNsD9g")]
    [Description(@"Commodity attribute of type emissions allowance EUA (European Union Allowance).")]
    EUA = AssetClassDetailedSubProductTypeCode.EUA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).
    /// Encoded/decoded by serializers as &quot;EUAA&quot;.
    /// </summary>
    [EnumMember(Value = "EUAA")]
    [IsoId("_nNFdoWlHEeaLAKoEUNsD9g")]
    [Description(@"Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).")]
    EUAA = AssetClassDetailedSubProductTypeCode.EUAA, // same ordinal as derivation source for type conversions
    
}
