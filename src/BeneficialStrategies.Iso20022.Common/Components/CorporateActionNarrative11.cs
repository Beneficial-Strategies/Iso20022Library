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
/// Provides additional information such as the taxation conditions.
/// </summary>
[IsoId("_ULEQUNp-Ed-ak6NoX_4Aeg_-1561052303")]
[DisplayName("Corporate Action Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNarrative11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_ULNaMNp-Ed-ak6NoX_4Aeg_-1674891369")]
    [DisplayName("Additional Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxt")]
    #endif
    [IsoXmlTag("AddtlTxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? AdditionalText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? AdditionalText { get; init; } 
    #else
    public UpdatedAdditionalInformation2? AdditionalText { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_ULNaMdp-Ed-ak6NoX_4Aeg_1623003574")]
    [DisplayName("Narrative Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrrtvVrsn")]
    #endif
    [IsoXmlTag("NrrtvVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? NarrativeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? NarrativeVersion { get; init; } 
    #else
    public UpdatedAdditionalInformation2? NarrativeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_ULNaMtp-Ed-ak6NoX_4Aeg_625931221")]
    [DisplayName("Information Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfConds")]
    #endif
    [IsoXmlTag("InfConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? InformationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? InformationConditions { get; init; } 
    #else
    public UpdatedAdditionalInformation2? InformationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_ULNaM9p-Ed-ak6NoX_4Aeg_-371141132")]
    [DisplayName("Information To Comply With")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfToCmplyWth")]
    #endif
    [IsoXmlTag("InfToCmplyWth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? InformationToComplyWith { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? InformationToComplyWith { get; init; } 
    #else
    public UpdatedAdditionalInformation2? InformationToComplyWith { get; set; } 
    #endif
    
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_ULNaNNp-Ed-ak6NoX_4Aeg_-1368213485")]
    [DisplayName("Taxation Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnConds")]
    #endif
    [IsoXmlTag("TaxtnConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? TaxationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? TaxationConditions { get; init; } 
    #else
    public UpdatedAdditionalInformation2? TaxationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_ULNaNdp-Ed-ak6NoX_4Aeg_1929681458")]
    [DisplayName("Disclaimer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclmr")]
    #endif
    [IsoXmlTag("Dsclmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? Disclaimer { get; init; } 
    #else
    public UpdatedAdditionalInformation2? Disclaimer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_ULNaNtp-Ed-ak6NoX_4Aeg_932609105")]
    [DisplayName("Party Contact Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyCtctNrrtv")]
    #endif
    [IsoXmlTag("PtyCtctNrrtv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? PartyContactNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? PartyContactNarrative { get; init; } 
    #else
    public UpdatedAdditionalInformation2? PartyContactNarrative { get; set; } 
    #endif
    
    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, for example, beneficial ownership.
    /// </summary>
    [IsoId("_ULNaN9p-Ed-ak6NoX_4Aeg_-64463248")]
    [DisplayName("Declaration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrtnDtls")]
    #endif
    [IsoXmlTag("DclrtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? DeclarationDetails { get; init; } 
    #else
    public UpdatedAdditionalInformation2? DeclarationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_ULNaONp-Ed-ak6NoX_4Aeg_-1061535601")]
    [DisplayName("Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDtls")]
    #endif
    [IsoXmlTag("RegnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? RegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? RegistrationDetails { get; init; } 
    #else
    public UpdatedAdditionalInformation2? RegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_ULXLMNp-Ed-ak6NoX_4Aeg_2066556477")]
    [DisplayName("Basket Or Index Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsktOrIndxInf")]
    #endif
    [IsoXmlTag("BsktOrIndxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation2? BasketOrIndexInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation2? BasketOrIndexInformation { get; init; } 
    #else
    public UpdatedAdditionalInformation2? BasketOrIndexInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
