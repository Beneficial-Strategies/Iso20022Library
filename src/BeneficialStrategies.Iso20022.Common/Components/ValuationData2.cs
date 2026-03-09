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
/// Set of data which contains the link to the opening of the non deliverable trade and supplementary information on its valuation.
/// </summary>
[IsoId("_TIKBxNp-Ed-ak6NoX_4Aeg_-1153647347")]
[DisplayName("Valuation Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValuationData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValuationData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValuationData2( System.String reqValuationReference )
    {
        ValuationReference = reqValuationReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the latest trade identification of the NDF opening trade.
    /// </summary>
    [IsoId("_TIKBxdp-Ed-ak6NoX_4Aeg_-1153647330")]
    [DisplayName("Valuation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnRef")]
    #endif
    [IsoXmlTag("ValtnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ValuationReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ValuationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ValuationReference { get; init; } 
    #else
    public System.String ValuationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency in which the non deliverable trade has to be settled ie the deliverable currency.
    /// </summary>
    [IsoId("_TIKBxtp-Ed-ak6NoX_4Aeg_-1153647004")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SettlementCurrency { get; init; } 
    #else
    public string? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Free format text that may contain information on the valuation such as the currency, the place, the time or the source of the rate.
    /// </summary>
    [IsoId("_TIKBx9p-Ed-ak6NoX_4Aeg_-1153647295")]
    [DisplayName("Additional Valuation Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlValtnInf")]
    #endif
    [IsoXmlTag("AddtlValtnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalValuationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalValuationInformation { get; init; } 
    #else
    public System.String? AdditionalValuationInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party through which the settlement will take place. It may contain the BIC of a central settlement system eg CLSBUS33.
    /// </summary>
    [IsoId("_TIKByNp-Ed-ak6NoX_4Aeg_-1153647029")]
    [DisplayName("Settlement Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPty")]
    #endif
    [IsoXmlTag("SttlmPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8Choice_? SettlementParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8Choice_? SettlementParty { get; init; } 
    #else
    public PartyIdentification8Choice_? SettlementParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
