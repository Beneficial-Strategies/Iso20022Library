// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the transaction is collateralised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5CiEQC5TEeK7-OZOLIksSw")]
[Description(@"Specifies whether the transaction is collateralised.")]
[DerivedFrom(typeof(CollateralisationIndicatorCode))]
public enum CollateralisationIndicator1Code
{
    /// <summary>
    /// Transaction is fully collateralised.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_At8bUS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is fully collateralised.")]
    FullyCollateralised = CollateralisationIndicatorCode.FullyCollateralised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is one-way collateralised.
    /// Encoded/decoded by serializers as &quot;ONEW&quot;.
    /// </summary>
    [EnumMember(Value = "ONEW")]
    [IsoId("_Ax7jcS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is one-way collateralised.")]
    OneWayCollateralised = CollateralisationIndicatorCode.OneWayCollateralised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is partially collateralised.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_A2-bgS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is partially collateralised.")]
    PartiallyCollateralised = CollateralisationIndicatorCode.PartiallyCollateralised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is uncollateralised.
    /// Encoded/decoded by serializers as &quot;UNCO&quot;.
    /// </summary>
    [EnumMember(Value = "UNCO")]
    [IsoId("_A7OpYS5VEeKwTrPDLMbLxA")]
    [Description(@"Transaction is uncollateralised.")]
    Uncollateralised = CollateralisationIndicatorCode.Uncollateralised, // same ordinal as derivation source for type conversions
}
