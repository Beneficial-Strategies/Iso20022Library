// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
/// </summary>
[IsoId("_QOo28dp-Ed-ak6NoX_4Aeg_-2063318861")]
[DisplayName("Intermediary")]
public partial record Intermediary13
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_QOo28tp-Ed-ak6NoX_4Aeg_-2063318809")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification4Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QOo289p-Ed-ak6NoX_4Aeg_-2063318388")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account2? Account { get; init; } 
    
    /// <summary>
    /// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
    /// </summary>
    [IsoId("_QOo29Np-Ed-ak6NoX_4Aeg_-2063318328")]
    [DisplayName("Waived Trailer Commission Indicator")]
    [IsoXmlTag("WvdTrlrComssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WaivedTrailerCommissionIndicator { get; init; } 
    
    /// <summary>
    /// Role or function performed by an intermediary in a given situation.
    /// </summary>
    [IsoId("_QOo29dp-Ed-ak6NoX_4Aeg_-2063318251")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole3Code? Role { get; init; } 
    
    /// <summary>
    /// Role or function performed by an intermediary in a given situation.
    /// </summary>
    [IsoId("_QOo29tp-Ed-ak6NoX_4Aeg_-2063318148")]
    [DisplayName("Extended Role")]
    [IsoXmlTag("XtndedRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedRole { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QOo299p-Ed-ak6NoX_4Aeg_-2063317356")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QOo2-Np-Ed-ak6NoX_4Aeg_-2063317261")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QOyn8Np-Ed-ak6NoX_4Aeg_-2063316930")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress4? NameAndAddress { get; init; } 
    
    
    #nullable disable
    
}
