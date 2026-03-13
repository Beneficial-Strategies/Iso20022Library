// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
[IsoId("_Q5QhRdp-Ed-ak6NoX_4Aeg_-1175095471")]
[DisplayName("Local Market Annex")]
public partial record LocalMarketAnnex2
{
    #nullable enable
    
    /// <summary>
    /// Country in which the processing characteristic applies.
    /// </summary>
    [IsoId("_Q5QhRtp-Ed-ak6NoX_4Aeg_-1288934537")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public SimpleValueList<string> Country { get; init; } = [];
    // ID for the above is _Q5QhRtp-Ed-ak6NoX_4Aeg_-1288934537
    
    /// <summary>
    /// Organisation established primarily to provide financial services.
    /// </summary>
    [IsoId("_Q5QhR9p-Ed-ak6NoX_4Aeg_-560669029")]
    [DisplayName("Local Order Desk")]
    [IsoXmlTag("LclOrdrDsk")]
    public required ContactAttributes1 LocalOrderDesk { get; init; } 
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5QhSNp-Ed-ak6NoX_4Aeg_-912656733")]
    [DisplayName("Subscription Processing Characteristics")]
    [IsoXmlTag("SbcptPrcgChrtcs")]
    public required ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5ZrMNp-Ed-ak6NoX_4Aeg_928734591")]
    [DisplayName("Redemption Processing Characteristics")]
    [IsoXmlTag("RedPrcgChrtcs")]
    public required ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_Q5ZrMdp-Ed-ak6NoX_4Aeg_-653648231")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public ValueList<CashAccount22> SettlementDetails { get; init; } = [];
    // ID for the above is _Q5ZrMdp-Ed-ak6NoX_4Aeg_-653648231
    
    
    #nullable disable
    
}
