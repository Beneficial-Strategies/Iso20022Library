// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of conversion.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCNHNtp-Ed-ak6NoX_4Aeg_-673877093")]
[Description(@"Specifies the type of conversion.")]
[DerivedFrom(typeof(ConversionTypeCode))]
public enum ConversionType1Code
{
    /// <summary>
    /// This is a final conversion.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_bCNHN9p-Ed-ak6NoX_4Aeg_-371886103")]
    [Description(@"This is a final conversion.")]
    Final = ConversionTypeCode.Final, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// This is an interim conversion.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_bCNHONp-Ed-ak6NoX_4Aeg_-371886073")]
    [Description(@"This is an interim conversion.")]
    Interim = ConversionTypeCode.Interim, // same ordinal as derivation source for type conversions
    
}
