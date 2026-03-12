// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
[IsoId("_ULz3Jdp-Ed-ak6NoX_4Aeg_-1558716045")]
[DisplayName("Corporate Action Narrative")]
public partial record CorporateActionNarrative6
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_ULz3Jtp-Ed-ak6NoX_4Aeg_-1558715753")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    public UpdatedAdditionalInformation1? AdditionalText { get; init; } 
    
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_ULz3J9p-Ed-ak6NoX_4Aeg_-1558715736")]
    [DisplayName("Narrative Version")]
    [IsoXmlTag("NrrtvVrsn")]
    public UpdatedAdditionalInformation1? NarrativeVersion { get; init; } 
    
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_ULz3KNp-Ed-ak6NoX_4Aeg_-1558715693")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    public UpdatedAdditionalInformation1? InformationConditions { get; init; } 
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_ULz3Kdp-Ed-ak6NoX_4Aeg_-1558715658")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public UpdatedAdditionalInformation1? InformationToComplyWith { get; init; } 
    
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_UL9BENp-Ed-ak6NoX_4Aeg_-1558715580")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    public UpdatedAdditionalInformation1? TaxationConditions { get; init; } 
    
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_UL9BEdp-Ed-ak6NoX_4Aeg_-1558715537")]
    [DisplayName("Disclaimer")]
    [IsoXmlTag("Dsclmr")]
    public UpdatedAdditionalInformation1? Disclaimer { get; init; } 
    
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_UL9BEtp-Ed-ak6NoX_4Aeg_-1558715477")]
    [DisplayName("Party Contact Narrative")]
    [IsoXmlTag("PtyCtctNrrtv")]
    public UpdatedAdditionalInformation1? PartyContactNarrative { get; init; } 
    
    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, for example, beneficial ownership.
    /// </summary>
    [IsoId("_UL9BE9p-Ed-ak6NoX_4Aeg_-544029832")]
    [DisplayName("Declaration Details")]
    [IsoXmlTag("DclrtnDtls")]
    public UpdatedAdditionalInformation1? DeclarationDetails { get; init; } 
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_UL9BFNp-Ed-ak6NoX_4Aeg_-456297248")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public UpdatedAdditionalInformation1? RegistrationDetails { get; init; } 
    
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [IsoId("_UL9BFdp-Ed-ak6NoX_4Aeg_-1133617066")]
    [DisplayName("Basket Or Index Information")]
    [IsoXmlTag("BsktOrIndxInf")]
    public UpdatedAdditionalInformation1? BasketOrIndexInformation { get; init; } 
    
    
    #nullable disable
    
}
