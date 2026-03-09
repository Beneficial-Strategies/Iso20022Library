// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the structure of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-ycnIKDqEequlaOyi6MUhw")]
[Description(@"Specifies the structure of a financial instrument.")]
[DerivedFrom(typeof(ProductStructureCode))]
public enum ProductStructure1Code
{
    /// <summary>
    /// Product is a bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_V8ap8bVQEeqkjqDuFVh1-A")]
    [Description(@"Product is a bond.")]
    Bond = ProductStructureCode.Bond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUMM&quot;.
    /// </summary>
    [EnumMember(Value = "NUMM")]
    [IsoId("_WykO0bVQEeqkjqDuFVh1-A")]
    [Description(@"Product is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS).")]
    NonUCITSMoneyMarketFund = ProductStructureCode.NonUCITSMoneyMarketFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund.
    /// Encoded/decoded by serializers as &quot;UCMM&quot;.
    /// </summary>
    [EnumMember(Value = "UCMM")]
    [IsoId("_XXdrobVQEeqkjqDuFVh1-A")]
    [Description(@"Product is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund.")]
    UCITSMoneyMarketFund = ProductStructureCode.UCITSMoneyMarketFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product is an exchange traded commodity.
    /// Encoded/decoded by serializers as &quot;EXTC&quot;.
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_YkPAwbVQEeqkjqDuFVh1-A")]
    [Description(@"Product is an exchange traded commodity.")]
    ExchangeTradedCommodity = ProductStructureCode.ExchangeTradedCommodity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product is an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;UCIT&quot;.
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_ZVVGgbVQEeqkjqDuFVh1-A")]
    [Description(@"Product is an Undertaking for Collective Investment in Transferable Securities (UCITS).")]
    UCITS = ProductStructureCode.UCITS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product is a structured security.
    /// Encoded/decoded by serializers as &quot;SSEC&quot;.
    /// </summary>
    [EnumMember(Value = "SSEC")]
    [IsoId("_aEMXobVQEeqkjqDuFVh1-A")]
    [Description(@"Product is a structured security.")]
    StructuredSecurity = ProductStructureCode.StructuredSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product is a structured fund.
    /// Encoded/decoded by serializers as &quot;SFUN&quot;.
    /// </summary>
    [EnumMember(Value = "SFUN")]
    [IsoId("_ban_EbVQEeqkjqDuFVh1-A")]
    [Description(@"Product is a structured fund.")]
    StructuredFund = ProductStructureCode.StructuredFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product is a not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUCI&quot;.
    /// </summary>
    [EnumMember(Value = "NUCI")]
    [IsoId("_clAukbVQEeqkjqDuFVh1-A")]
    [Description(@"Product is a not an Undertaking for Collective Investment in Transferable Securities (UCITS).")]
    NonUCITS = ProductStructureCode.NonUCITS, // same ordinal as derivation source for type conversions
    
}
