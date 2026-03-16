// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1WEodojEeC60axPepSq7g_534060743")]
[Description(@"Specifies the type of collateral.")]
[DerivedFrom(typeof(CollateralTypeCode))]
public enum CollateralType3Code
{
    /// <summary>
    /// Collateral type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("__1WEotojEeC60axPepSq7g_-80556502")]
    [Description(@"Collateral type is cash.")]
    Cash = CollateralTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("__1WEo9ojEeC60axPepSq7g_680208651")]
    [Description(@"Collateral type is securities.")]
    Securities = CollateralTypeCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type are physical entities, for example, airplanes for debt issued by the airline industry.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("__1WEpNojEeC60axPepSq7g_2147357414")]
    [Description(
        @"Collateral type are physical entities, for example, airplanes for debt issued by the airline industry."
    )]
    PhysicalEntities = CollateralTypeCode.PhysicalEntities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is an insurance contract.
    /// Encoded/decoded by serializers as &quot;INSU&quot;.
    /// </summary>
    [EnumMember(Value = "INSU")]
    [IsoId("__1WEpdojEeC60axPepSq7g_1134295920")]
    [Description(@"Collateral type is an insurance contract.")]
    Insurance = CollateralTypeCode.Insurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is stock certificates.
    /// Encoded/decoded by serializers as &quot;STCF&quot;.
    /// </summary>
    [EnumMember(Value = "STCF")]
    [IsoId("__1f1oNojEeC60axPepSq7g_-1329748207")]
    [Description(@"Collateral type is stock certificates.")]
    StockCertificate = CollateralTypeCode.StockCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is bonds.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("__1f1odojEeC60axPepSq7g_137400556")]
    [Description(@"Collateral type is bonds.")]
    Bond = CollateralTypeCode.Bond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collateral type is a bank guarantee.
    /// Encoded/decoded by serializers as &quot;GBBK&quot;.
    /// </summary>
    [EnumMember(Value = "GBBK")]
    [IsoId("__1f1otojEeC60axPepSq7g_-875660938")]
    [Description(@"Collateral type is a bank guarantee.")]
    BankGuarantee = CollateralTypeCode.BankGuarantee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other assets that could be used as collateral.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__1f1o9ojEeC60axPepSq7g_-702733106")]
    [Description(@"Other assets that could be used as collateral.")]
    Other = CollateralTypeCode.Other, // same ordinal as derivation source for type conversions
}
