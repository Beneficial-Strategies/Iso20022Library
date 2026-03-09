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
/// Provides additional information about mergers.
/// </summary>
[IsoId("_IY-XYFPaEeG1qPPaW9KJvg")]
[DisplayName("Merger Details Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MergerDetailsType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Differentiation of different types of merger.
    /// 合併/株式交換/株式移転の区分.
    /// </summary>
    [IsoId("_eG0j4FPaEeG1qPPaW9KJvg")]
    [DisplayName("Merger Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgrTp")]
    #endif
    [IsoXmlTag("MrgrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MergerTypeCode? MergerType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MergerTypeCode? MergerType { get; init; } 
    #else
    public MergerTypeCode? MergerType { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the counterparty in case of [sankaku] gappei: the scenario where a third party is involved as one of the counterparties in the merger but there is no security movement from the third party.
    /// </summary>
    [IsoId("_DPO70GHPEeGknP6xAc4fKw")]
    [DisplayName("Counterparty Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyDtls")]
    #endif
    [IsoXmlTag("CtrPtyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CounterpartyDetailsType1? CounterpartyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyDetailsType1? CounterpartyDetails { get; init; } 
    #else
    public CounterpartyDetailsType1? CounterpartyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the simplified merger regulatory condition of the parent company.
    /// 簡易区分.
    /// </summary>
    [IsoId("_tJIsgFPaEeG1qPPaW9KJvg")]
    [DisplayName("Simplified Merger Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SmplfdMrgrClssfctn")]
    #endif
    [IsoXmlTag("SmplfdMrgrClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MergerCode? SimplifiedMergerClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MergerCode? SimplifiedMergerClassification { get; init; } 
    #else
    public MergerCode? SimplifiedMergerClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the short form merger regulatory condition of the subsidiary company.
    /// 略式区分.
    /// </summary>
    [IsoId("_WIGg9WzgEeGa9q9Mq4E7uA")]
    [DisplayName("Short Form Merger Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtFormMrgrClssfctn")]
    #endif
    [IsoXmlTag("ShrtFormMrgrClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MergerCode? ShortFormMergerClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MergerCode? ShortFormMergerClassification { get; init; } 
    #else
    public MergerCode? ShortFormMergerClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Share unit quantity of the shares of the new company.
    /// 新設会社の単元株数.
    /// </summary>
    [IsoId("_2NisQFPaEeG1qPPaW9KJvg")]
    [DisplayName("Share Unit Quantity Of New Company")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrUnitQtyOfNewCpny")]
    #endif
    [IsoXmlTag("ShrUnitQtyOfNewCpny")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ShareUnitQuantityOfNewCompany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ShareUnitQuantityOfNewCompany { get; init; } 
    #else
    public System.UInt64? ShareUnitQuantityOfNewCompany { get; set; } 
    #endif
    
    
    #nullable disable
    
}
