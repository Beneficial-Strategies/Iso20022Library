// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZVRrUNp-Ed-ak6NoX_4Aeg_2004734273")]
[Description(@"Specifies the category of a product.")]
[Derivations(typeof(ProductCategory1Code))]
public enum ProductCategoryCode
{
    /// <summary>
    /// Classification of goods as developed by the Customs Cooperation council.
    /// Encoded/decoded by serializers as &quot;HRTR&quot;.
    /// </summary>
    [EnumMember(Value = "HRTR")]
    [IsoId("_ZVRrUdp-Ed-ak6NoX_4Aeg_-1389799071")]
    [Description(@"Classification of goods as developed by the Customs Cooperation council.")]
    HarmonizedTariffCodeName,
    
    /// <summary>
    /// Product identifier used by the retail industry.
    /// Encoded/decoded by serializers as &quot;QOTA&quot;.
    /// </summary>
    [EnumMember(Value = "QOTA")]
    [IsoId("_ZVRrUtp-Ed-ak6NoX_4Aeg_-1360248489")]
    [Description(@"Product identifier used by the retail industry.")]
    QuotaCategory,
    
    /// <summary>
    /// Product Group Code.
    /// Encoded/decoded by serializers as &quot;PRGP&quot;.
    /// </summary>
    [EnumMember(Value = "PRGP")]
    [IsoId("_ZVRrU9p-Ed-ak6NoX_4Aeg_-1330694641")]
    [Description(@"Product Group Code.")]
    ProductGroup,
    
    /// <summary>
    /// Line of business code.
    /// Encoded/decoded by serializers as &quot;LOBU&quot;.
    /// </summary>
    [EnumMember(Value = "LOBU")]
    [IsoId("_ZVRrVNp-Ed-ak6NoX_4Aeg_-1231879023")]
    [Description(@"Line of business code.")]
    LineOfBusiness,
    
    /// <summary>
    /// Code for gender.
    /// Encoded/decoded by serializers as &quot;GNDR&quot;.
    /// </summary>
    [EnumMember(Value = "GNDR")]
    [IsoId("_ZVRrVdp-Ed-ak6NoX_4Aeg_-942816025")]
    [Description(@"Code for gender.")]
    Gender,
    
}
