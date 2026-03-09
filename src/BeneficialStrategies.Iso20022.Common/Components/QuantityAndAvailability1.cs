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
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_QZhRR9p-Ed-ak6NoX_4Aeg_-987951378")]
[DisplayName("Quantity And Availability")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityAndAvailability1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QuantityAndAvailability1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QuantityAndAvailability1( FinancialInstrumentQuantity1Choice_ reqQuantity,System.String reqAvailabilityIndicator )
    {
        Quantity = reqQuantity;
        AvailabilityIndicator = reqAvailabilityIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QZhRSNp-Ed-ak6NoX_4Aeg_-987951353")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the quantity of securities on the sub-balance is available.
    /// </summary>
    [IsoId("_QZqbMNp-Ed-ak6NoX_4Aeg_-987951336")]
    [DisplayName("Availability Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvlbtyInd")]
    #endif
    [IsoXmlTag("AvlbtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AvailabilityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AvailabilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AvailabilityIndicator { get; init; } 
    #else
    public System.String AvailabilityIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
