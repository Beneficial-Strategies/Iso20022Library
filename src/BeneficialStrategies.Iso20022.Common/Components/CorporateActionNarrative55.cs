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
[IsoId("_p4pvqTi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Narrative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNarrative55
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
    [IsoId("_p4pvrTi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxt")]
    #endif
    [IsoXmlTag("AddtlTxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? AdditionalText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? AdditionalText { get; init; } 
    #else
    public UpdatedAdditionalInformation16? AdditionalText { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_p4pvtTi7Eeydid5dcNPKvg")]
    [DisplayName("Narrative Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrrtvVrsn")]
    #endif
    [IsoXmlTag("NrrtvVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? NarrativeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? NarrativeVersion { get; init; } 
    #else
    public UpdatedAdditionalInformation16? NarrativeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_p4pvvTi7Eeydid5dcNPKvg")]
    [DisplayName("Information Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfConds")]
    #endif
    [IsoXmlTag("InfConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? InformationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? InformationConditions { get; init; } 
    #else
    public UpdatedAdditionalInformation16? InformationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_p4pvxTi7Eeydid5dcNPKvg")]
    [DisplayName("Information To Comply With")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfToCmplyWth")]
    #endif
    [IsoXmlTag("InfToCmplyWth")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? InformationToComplyWith { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? InformationToComplyWith { get; init; } 
    #else
    public UpdatedAdditionalInformation16? InformationToComplyWith { get; set; } 
    #endif
    
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_p4pvzTi7Eeydid5dcNPKvg")]
    [DisplayName("Taxation Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxtnConds")]
    #endif
    [IsoXmlTag("TaxtnConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? TaxationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? TaxationConditions { get; init; } 
    #else
    public UpdatedAdditionalInformation16? TaxationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_p4pv1Ti7Eeydid5dcNPKvg")]
    [DisplayName("Disclaimer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclmr")]
    #endif
    [IsoXmlTag("Dsclmr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? Disclaimer { get; init; } 
    #else
    public UpdatedAdditionalInformation16? Disclaimer { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_p4pv3Ti7Eeydid5dcNPKvg")]
    [DisplayName("Party Contact Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyCtctNrrtv")]
    #endif
    [IsoXmlTag("PtyCtctNrrtv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? PartyContactNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? PartyContactNarrative { get; init; } 
    #else
    public UpdatedAdditionalInformation16? PartyContactNarrative { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_p4pv5Ti7Eeydid5dcNPKvg")]
    [DisplayName("Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDtls")]
    #endif
    [IsoXmlTag("RegnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? RegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? RegistrationDetails { get; init; } 
    #else
    public UpdatedAdditionalInformation16? RegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_p4pv7Ti7Eeydid5dcNPKvg")]
    [DisplayName("Basket Or Index Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsktOrIndxInf")]
    #endif
    [IsoXmlTag("BsktOrIndxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? BasketOrIndexInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? BasketOrIndexInformation { get; init; } 
    #else
    public UpdatedAdditionalInformation16? BasketOrIndexInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_p4pv9Ti7Eeydid5dcNPKvg")]
    [DisplayName("Certification Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnBrkdwn")]
    #endif
    [IsoXmlTag("CertfctnBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? CertificationBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? CertificationBreakdown { get; init; } 
    #else
    public UpdatedAdditionalInformation16? CertificationBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_p4pv9zi7Eeydid5dcNPKvg")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedURLlnformation5? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedURLlnformation5? URLAddress { get; init; } 
    #else
    public UpdatedURLlnformation5? URLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information from the account servicer or a service provider solely intended for the next immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [IsoId("_p4pv_zi7Eeydid5dcNPKvg")]
    [DisplayName("Processing Text For Next Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgTxtForNxtIntrmy")]
    #endif
    [IsoXmlTag("PrcgTxtForNxtIntrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation16? ProcessingTextForNextIntermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation16? ProcessingTextForNextIntermediary { get; init; } 
    #else
    public UpdatedAdditionalInformation16? ProcessingTextForNextIntermediary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
