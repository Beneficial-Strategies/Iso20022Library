// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides addtional information such as the taxation conditions.
/// </summary>
[IsoId("_UMQjFNp-Ed-ak6NoX_4Aeg_1627158994")]
[DisplayName("Corporate Action Narrative")]
public partial record CorporateActionNarrative1
{
    #nullable enable
    
    /// <summary>
    /// Provides conditional information related to the event, eg, an offer is subject to 50% acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_UMQjFdp-Ed-ak6NoX_4Aeg_1455730205")]
    [DisplayName("Information Conditions")]
    [IsoXmlTag("InfConds")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InformationConditions { get; init; } 
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, eg, not open to US/Canadian residents, QIB or SIL to be provided.
    /// </summary>
    [IsoId("_UMQjFtp-Ed-ak6NoX_4Aeg_1926725018")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InformationToComplyWith { get; init; } 
    
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message.
    /// </summary>
    [IsoId("_UMQjF9p-Ed-ak6NoX_4Aeg_1559163291")]
    [DisplayName("Taxation Conditions")]
    [IsoXmlTag("TaxtnConds")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? TaxationConditions { get; init; } 
    
    /// <summary>
    /// Provide the new name of a company following a name change.
    /// </summary>
    [IsoId("_UMQjGNp-Ed-ak6NoX_4Aeg_-1855110380")]
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? NewCompanyName { get; init; } 
    
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_UMQjGdp-Ed-ak6NoX_4Aeg_-1823711037")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public PartyIdentification2Choice_? Offeror { get; init; } 
    
    /// <summary>
    /// Provides the web address published for the event, ie the address for the Universal Resource Locator (URL), eg, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_UMQjGtp-Ed-ak6NoX_4Aeg_-1784925026")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; } 
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a|message.
    /// </summary>
    [IsoId("_UMZtANp-Ed-ak6NoX_4Aeg_-1766454729")]
    [DisplayName("Additional Text")]
    [IsoXmlTag("AddtlTxt")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalText { get; init; } 
    
    
    #nullable disable
    
}
