// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_ouYtsTk2EeapUO0vUIo9Xw")]
[DisplayName("Fee")]
public partial record Fee3
{
    #nullable enable
    
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("_6lR2wTk2EeapUO0vUIo9Xw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType5Choice_? Type { get; init; } 
    
    /// <summary>
    /// Modified value of the standard fee (charge/commission) amount applied on the order (the standard fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTdjk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Standard Amount")]
    [IsoXmlTag("RprdStdAmt")]
    public ActiveCurrencyAndAmount? RepairedStandardAmount { get; init; } 
    
    /// <summary>
    /// Modified value of the standard fee (charge/commission) rate applied on the order (the standard fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTdzk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Standard Rate")]
    [IsoXmlTag("RprdStdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? RepairedStandardRate { get; init; } 
    
    /// <summary>
    /// Modified value of the discount amount applied on the order (the discount amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTeDk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Discount Amount")]
    [IsoXmlTag("RprdDscntAmt")]
    public ActiveCurrencyAndAmount? RepairedDiscountAmount { get; init; } 
    
    /// <summary>
    /// Modified value of the discount rate applied on the order (the discount rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_K_CTeTk3EeapUO0vUIo9Xw")]
    [DisplayName("Repaired Discount Rate")]
    [IsoXmlTag("RprdDscntRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? RepairedDiscountRate { get; init; } 
    
    /// <summary>
    /// Modified value of the requested fee (charge/commission) amount applied on the order (the requested fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_925m8HBJEeaE8MrXjRZ50Q")]
    [DisplayName("Repaired Requested Amount")]
    [IsoXmlTag("RprdReqdAmt")]
    public ActiveCurrencyAndAmount? RepairedRequestedAmount { get; init; } 
    
    /// <summary>
    /// Modified value of the requested fee (charge/commission) rate applied on the order (the requested fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    [IsoId("_925m8XBJEeaE8MrXjRZ50Q")]
    [DisplayName("Repaired Requested Rate")]
    [IsoXmlTag("RprdReqdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? RepairedRequestedRate { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_kNZZUjk3EeapUO0vUIo9Xw")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Indicates if the CommercialAgreementReference is a new reference or not.
    /// </summary>
    [IsoId("_kNZZUzk3EeapUO0vUIo9Xw")]
    [DisplayName("New Commercial Agreement Reference Indicator")]
    [IsoXmlTag("NewComrclAgrmtRefInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewCommercialAgreementReferenceIndicator { get; init; } 
    
    
    #nullable disable
    
}
