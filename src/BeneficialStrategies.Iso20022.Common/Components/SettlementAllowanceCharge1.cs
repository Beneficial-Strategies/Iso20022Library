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
/// Specifies a pricing component, such as a service, promotion, allowance or charge, for this trade settlement.
/// </summary>
[IsoId("_S0Q8SgEcEeCQm6a_G2yO_w_1558181804")]
[DisplayName("Settlement Allowance Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementAllowanceCharge1
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
    [IsoId("_S0Q8SwEcEeCQm6a_G2yO_w_23404513")]
    [DisplayName("Allowance Charge Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwncChrgInd")]
    #endif
    [IsoXmlTag("AllwncChrgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AllowanceChargeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllowanceChargeIndicator { get; init; } 
    #else
    public System.String? AllowanceChargeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Actual monetary amount specified for the allowance or charge.
    /// </summary>
    [IsoId("_S0Q8TAEcEeCQm6a_G2yO_w_-2142675469")]
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
    /// Reason, expressed as text, for this allowance or charge.
    /// </summary>
    [IsoId("_S0Q8TQEcEeCQm6a_G2yO_w_1081608763")]
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
