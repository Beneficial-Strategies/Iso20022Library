// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the debt issuer type for debt.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DebtIssuerType1Code")]
[Description(@"Specifies the debt issuer type for debt.")]
[DerivedFrom(typeof(ProductTypeV2Code))]
public enum DebtIssuerType1Code
{
    /// <summary>
    /// Identifies categories of instruments issued by corporates.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_DebtIssuerType1Code_Corporate")]
    [Description(@"Identifies categories of instruments issued by corporates.")]
    Corporate = ProductTypeV2Code.Corporate,

    /// <summary>
    /// Identifies categories of securities issued by states and local governments.
    /// Encoded/decoded by serializers as &quot;MUNI&quot;.
    /// </summary>
    [EnumMember(Value = "MUNI")]
    [IsoId("_DebtIssuerType1Code_Municipal")]
    [Description(@"Identifies categories of securities issued by states and local governments.")]
    Municipal = ProductTypeV2Code.Municipal,

    /// <summary>
    /// Firms or governments may issue bonds for special projects or through special purpose vehicles.
    /// Encoded/decoded by serializers as &quot;SPVS&quot;.
    /// </summary>
    [EnumMember(Value = "SPVS")]
    [IsoId("_DebtIssuerType1Code_SpecialProjectsAndSpecialPurposeVehicles")]
    [Description(@"Firms or governments may issue bonds for special projects or through special purpose vehicles.")]
    SpecialProjectsAndSpecialPurposeVehicles,

    /// <summary>
    /// Supranational entities refer to global entities that are not based in a specific nation.
    /// Encoded/decoded by serializers as &quot;SUPR&quot;.
    /// </summary>
    [EnumMember(Value = "SUPR")]
    [IsoId("_DebtIssuerType1Code_SupranationalEntities")]
    [Description(@"Supranational entities refer to global entities that are not based in a specific nation.")]
    SupranationalEntities,

    /// <summary>
    /// Asset type is sovereign.
    /// Encoded/decoded by serializers as &quot;SVGN&quot;.
    /// </summary>
    [EnumMember(Value = "SVGN")]
    [IsoId("_DebtIssuerType1Code_Sovereign")]
    [Description(@"Asset type is sovereign.")]
    Sovereign = ProductTypeV2Code.Sovereign,

}
