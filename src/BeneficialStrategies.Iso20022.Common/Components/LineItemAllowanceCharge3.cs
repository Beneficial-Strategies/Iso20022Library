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
[IsoId("__2vvIfFUEee_LsXdoqzkWg")]
[DisplayName("Line Item Allowance Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LineItemAllowanceCharge3
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
    [IsoId("___vTEfFUEee_LsXdoqzkWg")]
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
    [IsoId("___vTE_FUEee_LsXdoqzkWg")]
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
    [IsoId("___vTFfFUEee_LsXdoqzkWg")]
    [DisplayName("Basis Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisQty")]
    #endif
    [IsoXmlTag("BsisQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity16? BasisQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity16? BasisQuantity { get; init; } 
    #else
    public Quantity16? BasisQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage applied to calculate this allowance charge.
    /// </summary>
    [IsoId("___vTF_FUEee_LsXdoqzkWg")]
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
    [IsoId("___vTGfFUEee_LsXdoqzkWg")]
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
    [IsoId("___vTG_FUEee_LsXdoqzkWg")]
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
