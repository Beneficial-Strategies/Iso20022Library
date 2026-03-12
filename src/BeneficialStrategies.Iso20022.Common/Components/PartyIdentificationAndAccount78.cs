// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_APRnktokEeC60axPepSq7g_-1228300605")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount78
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_APRnk9okEeC60axPepSq7g_-1342139671")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification32Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_APRnlNokEeC60axPepSq7g_1955755272")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification5? AlternateIdentification { get; init; } 
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_APRnldokEeC60axPepSq7g_-264334851")]
    [DisplayName("Side")]
    [IsoXmlTag("Sd")]
    public ClearingSide1Code? Side { get; init; } 
    
    /// <summary>
    /// Identifies the clearing member account at the CCP through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_APbYkNokEeC60axPepSq7g_1035721620")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public SecuritiesAccount20? ClearingAccount { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_APbYkdokEeC60axPepSq7g_-1573255774")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [IsoId("_APbYktokEeC60axPepSq7g_1724639169")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
