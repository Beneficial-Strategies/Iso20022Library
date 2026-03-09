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
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_7-tU_UEEEeWVgfuHGaKtRQ")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate71
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_8LDucUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Proposed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdRate")]
    #endif
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ProposedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ProposedRate { get; init; } 
    #else
    public System.Decimal? ProposedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    [IsoId("_8LDueUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Oversubscription Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptRate")]
    #endif
    [IsoXmlTag("OvrsbcptRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat39Choice_? OversubscriptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat39Choice_? OversubscriptionRate { get; init; } 
    #else
    public RateAndAmountFormat39Choice_? OversubscriptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Requested tax rate that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_8LDugUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Requested Withholding Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdWhldgTaxRate")]
    #endif
    [IsoXmlTag("ReqdWhldgTaxRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat40Choice_? RequestedWithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat40Choice_? RequestedWithholdingTaxRate { get; init; } 
    #else
    public RateAndAmountFormat40Choice_? RequestedWithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_8LDui0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Requested Second Level Tax Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdScndLvlTaxRate")]
    #endif
    [IsoXmlTag("ReqdScndLvlTaxRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat40Choice_? RequestedSecondLevelTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat40Choice_? RequestedSecondLevelTaxRate { get; init; } 
    #else
    public RateAndAmountFormat40Choice_? RequestedSecondLevelTaxRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
