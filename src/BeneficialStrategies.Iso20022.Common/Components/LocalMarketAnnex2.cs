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
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
[IsoId("_Q5QhRdp-Ed-ak6NoX_4Aeg_-1175095471")]
[DisplayName("Local Market Annex")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LocalMarketAnnex2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LocalMarketAnnex2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LocalMarketAnnex2( ContactAttributes1 reqLocalOrderDesk,ProcessingCharacteristics2 reqSubscriptionProcessingCharacteristics,ProcessingCharacteristics3 reqRedemptionProcessingCharacteristics )
    {
        LocalOrderDesk = reqLocalOrderDesk;
        SubscriptionProcessingCharacteristics = reqSubscriptionProcessingCharacteristics;
        RedemptionProcessingCharacteristics = reqRedemptionProcessingCharacteristics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country in which the processing characteristic applies.
    /// </summary>
    [IsoId("_Q5QhRtp-Ed-ak6NoX_4Aeg_-1288934537")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    public SimpleValueList<string> Country { get; init; } = new SimpleValueList<string>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Q5QhRtp-Ed-ak6NoX_4Aeg_-1288934537
    
    /// <summary>
    /// Organisation established primarily to provide financial services.
    /// </summary>
    [IsoId("_Q5QhR9p-Ed-ak6NoX_4Aeg_-560669029")]
    [DisplayName("Local Order Desk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclOrdrDsk")]
    #endif
    [IsoXmlTag("LclOrdrDsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactAttributes1 LocalOrderDesk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContactAttributes1 LocalOrderDesk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes1 LocalOrderDesk { get; init; } 
    #else
    public ContactAttributes1 LocalOrderDesk { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5QhSNp-Ed-ak6NoX_4Aeg_-912656733")]
    [DisplayName("Subscription Processing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPrcgChrtcs")]
    #endif
    [IsoXmlTag("SbcptPrcgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics2 SubscriptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to the instrument, ie, not to the market.
    /// </summary>
    [IsoId("_Q5ZrMNp-Ed-ak6NoX_4Aeg_928734591")]
    [DisplayName("Redemption Processing Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPrcgChrtcs")]
    #endif
    [IsoXmlTag("RedPrcgChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics3 RedemptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_Q5ZrMdp-Ed-ak6NoX_4Aeg_-653648231")]
    [DisplayName("Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDtls")]
    #endif
    [IsoXmlTag("SttlmDtls")]
    public ValueList<CashAccount22> SettlementDetails { get; init; } = new ValueList<CashAccount22>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Q5ZrMdp-Ed-ak6NoX_4Aeg_-653648231
    
    
    #nullable disable
    
}
