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
/// Allows to specify other collateral type by providing a description and the quantity.
/// </summary>
[IsoId("_dkcYoSqUEeyR9JrVGfaMKw")]
[DisplayName("Other Type Of Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OtherTypeOfCollateral3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OtherTypeOfCollateral3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OtherTypeOfCollateral3( System.String reqDescription )
    {
        Description = reqDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the collateral.
    /// </summary>
    [IsoId("_eI8z4SqUEeyR9JrVGfaMKw")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of other collateral.
    /// </summary>
    [IsoId("_eI8z4yqUEeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity33Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_? Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_? Quantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
