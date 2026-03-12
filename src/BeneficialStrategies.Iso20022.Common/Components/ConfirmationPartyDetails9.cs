// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_jf3VUY-kEeaEa8S_GI1QNA")]
[DisplayName("Confirmation Party Details")]
public partial record ConfirmationPartyDetails9
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_jwrYg4-kEeaEa8S_GI1QNA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification117Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_jwrYkY-kEeaEa8S_GI1QNA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification8? AlternateIdentification { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_jwrYk4-kEeaEa8S_GI1QNA")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_jwrYm4-kEeaEa8S_GI1QNA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation5? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Indicates whether the confirmation party is a member of the investor protection association required, eg, as per regulation.
    /// </summary>
    [IsoId("_jwrYnY-kEeaEa8S_GI1QNA")]
    [DisplayName("Investor Protection Association Membership")]
    [IsoXmlTag("InvstrPrtcnAssoctnMmbsh")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InvestorProtectionAssociationMembership { get; init; } 
    
    
    #nullable disable
    
}
