// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of search criteria for querying party reference data.
/// </summary>
[IsoId("_5ry10Z9wEeejnerJgFeC2w")]
[DisplayName("Party Data Search Criteria")]
public partial record PartyDataSearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    [IsoId("_55esgZ9wEeejnerJgFeC2w")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    public DatePeriodSearch1Choice_? OpeningDate { get; init; } 
    
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_55esg59wEeejnerJgFeC2w")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    public DatePeriodSearch1Choice_? ClosingDate { get; init; } 
    
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    [IsoId("_55eshZ9wEeejnerJgFeC2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SystemPartyType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    [IsoId("_PhqX0Ip_EeiEt5E1WBt_2Q")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_55esiZ9wEeejnerJgFeC2w")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public PartyIdentification136? PartyIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the identification of a restriction.
    /// </summary>
    [IsoId("_55esi59wEeejnerJgFeC2w")]
    [DisplayName("Restriction Identification")]
    [IsoXmlTag("RstrctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RestrictionIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the date when the restriction for the party has been issued.
    /// </summary>
    [IsoId("_55esjZ9wEeejnerJgFeC2w")]
    [DisplayName("Restriction Issue Date")]
    [IsoXmlTag("RstrctnIsseDt")]
    public DateAndDateTimeSearch4Choice_? RestrictionIssueDate { get; init; } 
    
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("_NhaAEowbEei289CGNqs21g")]
    [DisplayName("Residence Type")]
    [IsoXmlTag("ResTp")]
    public ResidenceType1Code? ResidenceType { get; init; } 
    
    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    [IsoId("_NhaAE4wbEei289CGNqs21g")]
    [DisplayName("Lock Status")]
    [IsoXmlTag("LckSts")]
    public PartyLockStatus1? LockStatus { get; init; } 
    
    
    #nullable disable
    
}
