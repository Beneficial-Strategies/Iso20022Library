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
/// Pricing component, such as a service, promotion, allowance or charge, for this line item.
/// </summary>
[IsoId("_S0Q8TgEcEeCQm6a_G2yO_w_145447968")]
[DisplayName("Line Item Allowance Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemAllowanceCharge1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication of whether or not this allowance charge is a charge.
    /// </summary>
    [IsoId("_S0Q8TwEcEeCQm6a_G2yO_w_2144378337")]
    [DisplayName("Charge Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgInd")]
    #endif
    [IsoXmlTag("ChrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ChargeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChargeIndicator { get; init; } 
    #else
    public System.String? ChargeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Actual monetary value of this allowance charge.
    /// </summary>
    [IsoId("_S0Q8UAEcEeCQm6a_G2yO_w_1865072585")]
    [DisplayName("Actual Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlAmt")]
    #endif
    [IsoXmlTag("ActlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? ActualAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? ActualAmount { get; init; } 
    #else
    public CurrencyAndAmount? ActualAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity on which this allowance charge is based.
    /// </summary>
    [IsoId("_S0aGIAEcEeCQm6a_G2yO_w_700685910")]
    [DisplayName("Basis Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisQty")]
    #endif
    [IsoXmlTag("BsisQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity3? BasisQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity3? BasisQuantity { get; init; } 
    #else
    public Quantity3? BasisQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage applied to calculate this allowance charge.
    /// </summary>
    [IsoId("_S0aGIQEcEeCQm6a_G2yO_w_-642810795")]
    [DisplayName("Calculation Percent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnPct")]
    #endif
    [IsoXmlTag("ClctnPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? CalculationPercent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CalculationPercent { get; init; } 
    #else
    public System.Decimal? CalculationPercent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the order in which the allowance or charge is applied.
    /// </summary>
    [IsoId("_S0aGIgEcEeCQm6a_G2yO_w_-1141593647")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SequenceNumber { get; init; } 
    #else
    public System.UInt64? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reason, expressed as text, for this allowance charge.
    /// </summary>
    [IsoId("_S0aGIwEcEeCQm6a_G2yO_w_-1352166303")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DiscountOrChargeType1Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DiscountOrChargeType1Choice_? Reason { get; init; } 
    #else
    public DiscountOrChargeType1Choice_? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
