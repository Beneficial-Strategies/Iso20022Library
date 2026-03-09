// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Categorization of financial asset type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m9i30fNBEeCuA5Tr22BnwA_99681721")]
[Description(@"Categorization of financial asset type.")]
[DerivedFrom(typeof(FinancialAssetTypeCategoryCode))]
public enum FinancialAssetTypeCategory1Code
{
    /// <summary>
    /// Balance attributed to equities.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_m9i30vNBEeCuA5Tr22BnwA_1063862993")]
    [Description(@"Balance attributed to equities.")]
    Equities = FinancialAssetTypeCategoryCode.Equities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to debt instruments.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_m9i30_NBEeCuA5Tr22BnwA_250712475")]
    [Description(@"Balance attributed to debt instruments.")]
    DebtInstruments = FinancialAssetTypeCategoryCode.DebtInstruments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to entitlements.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_m9i31PNBEeCuA5Tr22BnwA_1925778616")]
    [Description(@"Balance attributed to entitlements.")]
    Entitlements = FinancialAssetTypeCategoryCode.Entitlements, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to derivatives.
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_m9i31fNBEeCuA5Tr22BnwA_853773557")]
    [Description(@"Balance attributed to derivatives.")]
    Derivatives = FinancialAssetTypeCategoryCode.Derivatives, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance attributed to money market instruments.
    /// Encoded/decoded by serializers as &quot;MMKT&quot;.
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_m9so0PNBEeCuA5Tr22BnwA_827954634")]
    [Description(@"Balance attributed to money market instruments.")]
    MoneyMarket = FinancialAssetTypeCategoryCode.MoneyMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other financial asset type balance according to a different classification, which is not explictly defined.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_m9so0fNBEeCuA5Tr22BnwA_714115568")]
    [Description(@"Other financial asset type balance according to a different classification, which is not explictly defined.")]
    Others = FinancialAssetTypeCategoryCode.Others, // same ordinal as derivation source for type conversions
    
}
