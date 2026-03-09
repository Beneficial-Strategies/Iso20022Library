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
/// Amount of money associated with a service.
/// </summary>
[IsoId("_ouYtsTk2EeapUO0vUIo9Xw")]
[DisplayName("Fee")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Fee3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("_6lR2wTk2EeapUO0vUIo9Xw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeType5Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType5Choice_? Type { get; init; } 
    #else
    public ChargeType5Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Modified value of the standard fee (charge/commission) amount applied on the order (the standard fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTdjk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Standard Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdStdAmt")]
    #endif
    [IsoXmlTag("RprdStdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RepairedStandardAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RepairedStandardAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RepairedStandardAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Modified value of the standard fee (charge/commission) rate applied on the order (the standard fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTdzk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Standard Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdStdRate")]
    #endif
    [IsoXmlTag("RprdStdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? RepairedStandardRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RepairedStandardRate { get; init; } 
    #else
    public System.Decimal? RepairedStandardRate { get; set; } 
    #endif
    
    /// <summary>
    /// Modified value of the discount amount applied on the order (the discount amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTeDk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Discount Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdDscntAmt")]
    #endif
    [IsoXmlTag("RprdDscntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RepairedDiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RepairedDiscountAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RepairedDiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Modified value of the discount rate applied on the order (the discount rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTeTk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Discount Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdDscntRate")]
    #endif
    [IsoXmlTag("RprdDscntRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? RepairedDiscountRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RepairedDiscountRate { get; init; } 
    #else
    public System.Decimal? RepairedDiscountRate { get; set; } 
    #endif
    
    /// <summary>
    /// Modified value of the requested fee (charge/commission) amount applied on the order (the requested fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_925m8HBJEeaE8MrXjRZ50Q")]
    [DisplayName("Repaired Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdReqdAmt")]
    #endif
    [IsoXmlTag("RprdReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RepairedRequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RepairedRequestedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RepairedRequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Modified value of the requested fee (charge/commission) rate applied on the order (the requested fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_925m8XBJEeaE8MrXjRZ50Q")]
    [DisplayName("Repaired Requested Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdReqdRate")]
    #endif
    [IsoXmlTag("RprdReqdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? RepairedRequestedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RepairedRequestedRate { get; init; } 
    #else
    public System.Decimal? RepairedRequestedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_kNZZUjk3EeapUO0vUIo9Xw")]
    [DisplayName("Commercial Agreement Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComrclAgrmtRef")]
    #endif
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommercialAgreementReference { get; init; } 
    #else
    public System.String? CommercialAgreementReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the CommercialAgreementReference is a new reference or not.
    /// </summary>
    [IsoId("_kNZZUzk3EeapUO0vUIo9Xw")]
    [DisplayName("New Commercial Agreement Reference Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewComrclAgrmtRefInd")]
    #endif
    [IsoXmlTag("NewComrclAgrmtRefInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NewCommercialAgreementReferenceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewCommercialAgreementReferenceIndicator { get; init; } 
    #else
    public System.String? NewCommercialAgreementReferenceIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
