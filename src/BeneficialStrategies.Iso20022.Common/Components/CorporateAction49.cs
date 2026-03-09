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
/// Provides information about the corporate action event.
/// </summary>
[IsoId("_k9k-583xEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateAction49
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_k9k-6c3xEee5nJBZsW8MFQ")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate70? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate70? DateDetails { get; init; } 
    #else
    public CorporateActionDate70? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_k9k-683xEee5nJBZsW8MFQ")]
    [DisplayName("Event Stage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtStag")]
    #endif
    [IsoXmlTag("EvtStag")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventStageFormat15Choice_? EventStage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventStageFormat15Choice_? EventStage { get; init; } 
    #else
    public CorporateActionEventStageFormat15Choice_? EventStage { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the message is related to a claim on the associated corporate action event.
    /// </summary>
    [IsoId("_k9k-7c3xEee5nJBZsW8MFQ")]
    [DisplayName("Additional Business Process Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBizPrcInd")]
    #endif
    [IsoXmlTag("AddtlBizPrcInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBusinessProcessFormat13Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBusinessProcessFormat13Choice_? AdditionalBusinessProcessIndicator { get; init; } 
    #else
    public AdditionalBusinessProcessFormat13Choice_? AdditionalBusinessProcessIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_k9k-9c3xEee5nJBZsW8MFQ")]
    [DisplayName("Lottery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryTp")]
    #endif
    [IsoXmlTag("LtryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LotteryTypeFormat5Choice_? LotteryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LotteryTypeFormat5Choice_? LotteryType { get; init; } 
    #else
    public LotteryTypeFormat5Choice_? LotteryType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_k9k-_c3xEee5nJBZsW8MFQ")]
    [DisplayName("Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQty")]
    #endif
    [IsoXmlTag("SctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionQuantity10? SecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionQuantity10? SecuritiesQuantity { get; init; } 
    #else
    public CorporateActionQuantity10? SecuritiesQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
