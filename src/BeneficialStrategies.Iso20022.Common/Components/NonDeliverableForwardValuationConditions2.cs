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
/// Set of parameters used to calculate the fixing rate to be applied to a non-deliverable agreement.
/// </summary>
[IsoId("_TIAQw9p-Ed-ak6NoX_4Aeg_1813124879")]
[DisplayName("Non Deliverable Forward Valuation Conditions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonDeliverableForwardValuationConditions2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonDeliverableForwardValuationConditions2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonDeliverableForwardValuationConditions2( string reqSettlementCurrency,System.DateOnly reqValuationDate )
    {
        SettlementCurrency = reqSettlementCurrency;
        ValuationDate = reqValuationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the currency in which the non deliverable trade has to be settled ie the deliverable currency.
    /// </summary>
    [IsoId("_TIAQxNp-Ed-ak6NoX_4Aeg_1813124956")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode SettlementCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SettlementCurrency { get; init; } 
    #else
    public string SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the rate used for calculating the net amount to be settled is observed.
    /// </summary>
    [IsoId("_TIAQxdp-Ed-ak6NoX_4Aeg_1813124914")]
    [DisplayName("Valuation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnDt")]
    #endif
    [IsoXmlTag("ValtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValuationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValuationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValuationDate { get; init; } 
    #else
    public System.DateOnly ValuationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Free format text that may contain valuation information such as the place, the time or the source of the rate.
    /// </summary>
    [IsoId("_TIAQxtp-Ed-ak6NoX_4Aeg_1813124939")]
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
    [IsoId("_TIAQx9p-Ed-ak6NoX_4Aeg_1813124896")]
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
