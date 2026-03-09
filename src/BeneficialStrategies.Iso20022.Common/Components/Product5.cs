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
/// Product to purchase.
/// </summary>
[IsoId("_lPknoZVaEeWuuIjj4l7kpg")]
[DisplayName("Product")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Product5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Product5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Product5( System.String reqProductCode )
    {
        ProductCode = reqProductCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_lbSIY5VaEeWuuIjj4l7kpg")]
    [DisplayName("Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCd")]
    #endif
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text ProductCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProductCode { get; init; } 
    #else
    public System.String ProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional product code related to the product.
    /// </summary>
    [IsoId("_lbSIZZVaEeWuuIjj4l7kpg")]
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
    /// Amount limit for the product.
    /// </summary>
    [IsoId("_lbSIb5VaEeWuuIjj4l7kpg")]
    [DisplayName("Amount Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtLmt")]
    #endif
    [IsoXmlTag("AmtLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AmountLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AmountLimit { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AmountLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity limit for the product.
    /// </summary>
    [IsoId("_lbSIaZVaEeWuuIjj4l7kpg")]
    [DisplayName("Quantity Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyLmt")]
    #endif
    [IsoXmlTag("QtyLmt")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? QuantityLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? QuantityLimit { get; init; } 
    #else
    public System.UInt64? QuantityLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_lbSIZ5VaEeWuuIjj4l7kpg")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure6Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure6Code? UnitOfMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
