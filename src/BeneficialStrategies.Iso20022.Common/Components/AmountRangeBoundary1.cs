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
/// Limit for an amount range.
/// </summary>
[IsoId("_T4ItO9p-Ed-ak6NoX_4Aeg_-1155989003")]
[DisplayName("Amount Range Boundary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountRangeBoundary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountRangeBoundary1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountRangeBoundary1( ImpliedCurrencyAndAmount reqBoundaryAmount,System.String reqIncluded )
    {
        BoundaryAmount = reqBoundaryAmount;
        Included = reqIncluded;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount value of the range limit.
    /// </summary>
    [IsoId("_T4ItPNp-Ed-ak6NoX_4Aeg_-1036855293")]
    [DisplayName("Boundary Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BdryAmt")]
    #endif
    [IsoXmlTag("BdryAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount BoundaryAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount BoundaryAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount BoundaryAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount BoundaryAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the boundary amount is included in the range of amount values.
    /// </summary>
    [IsoId("_T4SeMNp-Ed-ak6NoX_4Aeg_-1036855240")]
    [DisplayName("Included")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incl")]
    #endif
    [IsoXmlTag("Incl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Included { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Included { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Included { get; init; } 
    #else
    public System.String Included { get; set; } 
    #endif
    
    
    #nullable disable
    
}
