// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZhNttp-Ed-ak6NoX_4Aeg_1034999409")]
[Description(@"Specifies the type of collateral.")]
[DerivedFrom(typeof(CollateralTypeCode))]
public enum CollateralType2Code
{
    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_YZhNt9p-Ed-ak6NoX_4Aeg_-490160893")]
    [Description(@"Collateral type is cash.")]
    Cash = CollateralTypeCode.Cash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_YZhNuNp-Ed-ak6NoX_4Aeg_-2046528295")]
    [Description(@"Collateral type is securities.")]
    Securities = CollateralTypeCode.Securities, // same ordinal as derivation source for type conversions
    
}
