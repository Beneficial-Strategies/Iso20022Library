// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local Market Annex6.
/// </summary>
[IsoId("_LWM1qzdyEe6UObU50fB8Cw")]
[DisplayName("Local Market Annex6")]
public partial record LocalMarketAnnex6
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Cash Settlement Details.
    /// </summary>
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public ValueList<CashAccount205> CashSettlementDetails { get; init; } = [];

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ValueList<CountryCode> Country { get; init; } = [];

    /// <summary>
    /// Local Order Desk.
    /// </summary>
    [DisplayName("Local Order Desk")]
    [IsoXmlTag("LclOrdrDsk")]
    public required OrderDesk1 LocalOrderDesk { get; init; } 

    /// <summary>
    /// Redemption Processing Characteristics.
    /// </summary>
    [DisplayName("Redemption Processing Characteristics")]
    [IsoXmlTag("RedPrcgChrtcs")]
    public ProcessingCharacteristics10? RedemptionProcessingCharacteristics { get; init; } 

    /// <summary>
    /// Subscription Processing Characteristics.
    /// </summary>
    [DisplayName("Subscription Processing Characteristics")]
    [IsoXmlTag("SbcptPrcgChrtcs")]
    public ProcessingCharacteristics11? SubscriptionProcessingCharacteristics { get; init; } 

    /// <summary>
    /// Switch Processing Characteristics.
    /// </summary>
    [DisplayName("Switch Processing Characteristics")]
    [IsoXmlTag("SwtchPrcgChrtcs")]
    public ProcessingCharacteristics9? SwitchProcessingCharacteristics { get; init; } 

    
    #nullable disable
    
}
