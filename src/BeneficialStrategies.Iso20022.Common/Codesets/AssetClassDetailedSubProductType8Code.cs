// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Emissions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xVtRIA2hEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Emissions.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType8Code
{
    /// <summary>
    /// Commodity attribute of type emissions allowance CER (Certified Emission Reduction).
    /// Encoded/decoded by serializers as &quot;CERE&quot;.
    /// </summary>
    [EnumMember(Value = "CERE")]
    [IsoId("_1e-MkQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type emissions allowance CER (Certified Emission Reduction).")]
    CER = AssetClassDetailedSubProductTypeCode.CER, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type emissions allowance ERU (European Reduction Unit).
    /// Encoded/decoded by serializers as &quot;ERUE&quot;.
    /// </summary>
    [EnumMember(Value = "ERUE")]
    [IsoId("_1lg5cQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type emissions allowance ERU (European Reduction Unit).")]
    ERU = AssetClassDetailedSubProductTypeCode.ERU, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type emissions allowance EUA (European Union Allowance).
    /// Encoded/decoded by serializers as &quot;EUAE&quot;.
    /// </summary>
    [EnumMember(Value = "EUAE")]
    [IsoId("_1tslEQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type emissions allowance EUA (European Union Allowance).")]
    EUA = AssetClassDetailedSubProductTypeCode.EUA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).
    /// Encoded/decoded by serializers as &quot;EUAA&quot;.
    /// </summary>
    [EnumMember(Value = "EUAA")]
    [IsoId("_12U8oQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).")]
    EUAA = AssetClassDetailedSubProductTypeCode.EUAA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YVQEcfwfEeW4Wthd0Ze_kA")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
