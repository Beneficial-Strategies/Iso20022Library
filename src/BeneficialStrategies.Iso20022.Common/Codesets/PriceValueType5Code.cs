// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJk2E9p-Ed-ak6NoX_4Aeg_-647834844")]
[Description(@"Specifies the value of a price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType5Code
{
    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aJk2FNp-Ed-ak6NoX_4Aeg_-647834596")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown = PriceValueTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aJk2Fdp-Ed-ak6NoX_4Aeg_-647834587")]
    [Description(@"Price has not been established.")]
    OpenDated = PriceValueTypeCode.OpenDated, // same ordinal as derivation source for type conversions
    
}
