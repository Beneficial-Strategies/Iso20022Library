// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction
/// </summary>
[IsoId("_buMzlPJxEeiJn9rM2Znz2w")]
[DisplayName("Sale Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleItem2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the product type of the sale line item.
    /// </summary>
    [IsoId("_pgLVs_JxEeiJn9rM2Znz2w")]
    [DisplayName("Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTp")]
    #endif
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductType { get; init; } 
    #else
    public System.String? ProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_pgLVtPJxEeiJn9rM2Znz2w")]
    [DisplayName("Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCd")]
    #endif
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductCode { get; init; } 
    #else
    public System.String? ProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a list of codes used to identify a product.
    /// </summary>
    [IsoId("_pgLVtfJxEeiJn9rM2Znz2w")]
    [DisplayName("Product Code Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCdTp")]
    #endif
    [IsoXmlTag("PdctCdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductCodeType1Code? ProductCodeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductCodeType1Code? ProductCodeType { get; init; } 
    #else
    public ProductCodeType1Code? ProductCodeType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional code related to the product.
    /// </summary>
    [IsoId("_1dhRefJxEeiJn9rM2Znz2w")]
    [DisplayName("Additional Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPdctCd")]
    #endif
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalProductCode { get; init; } 
    #else
    public System.String? AdditionalProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional type of codification  used to identify a product.
    /// </summary>
    [IsoId("_1dhRevJxEeiJn9rM2Znz2w")]
    [DisplayName("Additional Product Code Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPdctCdTp")]
    #endif
    [IsoXmlTag("AddtlPdctCdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalProductCodeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalProductCodeType { get; init; } 
    #else
    public System.String? AdditionalProductCodeType { get; set; } 
    #endif
    
    /// <summary>
    /// Code discriminator between a product code and its format to uniquely identify a specific product (for example, Item or pack of same items).
    /// </summary>
    [IsoId("_1dhRe_JxEeiJn9rM2Znz2w")]
    [DisplayName("Product Code Modifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCdModfr")]
    #endif
    [IsoXmlTag("PdctCdModfr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ProductCodeModifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ProductCodeModifier { get; init; } 
    #else
    public System.UInt64? ProductCodeModifier { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the product or item.
    /// </summary>
    [IsoId("_1dhRfPJxEeiJn9rM2Znz2w")]
    [DisplayName("Product Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctDesc")]
    #endif
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ProductDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductDescription { get; init; } 
    #else
    public System.String? ProductDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_1dhRffJxEeiJn9rM2Znz2w")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure1Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_1dhRfvJxEeiJn9rM2Znz2w")]
    [DisplayName("Other Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrUnitOfMeasr")]
    #endif
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherUnitOfMeasure { get; init; } 
    #else
    public System.String? OtherUnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_1dhRf_JxEeiJn9rM2Znz2w")]
    [DisplayName("Product Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctQty")]
    #endif
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ProductQuantity { get; init; } 
    #else
    public System.UInt64? ProductQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Original, non-adjusted cost of one unit of the product or service before discounts and taxes.
    /// </summary>
    [IsoId("_1dhRgPJxEeiJn9rM2Znz2w")]
    [DisplayName("Non Adjusted Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonAdjstdUnitPric")]
    #endif
    [IsoXmlTag("NonAdjstdUnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Original, non-adjusted total cost of a product or service before discounts and taxes.
    /// </summary>
    [IsoId("_1dhRg_JxEeiJn9rM2Znz2w")]
    [DisplayName("Non Adjusted Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonAdjstdTtlAmt")]
    #endif
    [IsoXmlTag("NonAdjstdTtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Adjustment made to the original price.
    /// </summary>
    [IsoId("_1dhRhfJxEeiJn9rM2Znz2w")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment10? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment10? Adjustment { get; init; } 
    #else
    public Adjustment10? Adjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Total cost of the line item amount, inclusive adjustments and exclusive of taxes.
    /// </summary>
    [IsoId("__SeLEfJ2EeiJn9rM2Znz2w")]
    [DisplayName("Adjusted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdAmt")]
    #endif
    [IsoXmlTag("AdjstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AdjustedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AdjustedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AdjustedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_PotZsfJ3EeiJn9rM2Znz2w")]
    [DisplayName("Insurance Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncInd")]
    #endif
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InsuranceIndicator { get; init; } 
    #else
    public System.String? InsuranceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_P_jMYfJ3EeiJn9rM2Znz2w")]
    [DisplayName("Insurance Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InsrncAmt")]
    #endif
    [IsoXmlTag("InsrncAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes applying to the good or item.
    /// </summary>
    [IsoId("_1dhRhPJxEeiJn9rM2Znz2w")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax33? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax33? Tax { get; init; } 
    #else
    public Tax33? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Total cost of the line item, inclusive of all applicable adjustments and taxes.
    /// </summary>
    [IsoId("_SjNb8fJ3EeiJn9rM2Znz2w")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
