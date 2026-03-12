// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_NbXONfNyEeqRfth943bvEA")]
[DisplayName("Party Identification")]
public partial record PartyIdentification237
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_Nu2K4fNyEeqRfth943bvEA")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required NameAndAddress17 NameAndAddress { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_Nu2K4_NyEeqRfth943bvEA")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; } 
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Nu2K5fNyEeqRfth943bvEA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification198Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Country in which the company is incorporated or legally registered. 
    /// </summary>
    [IsoId("_Nu2K5_NyEeqRfth943bvEA")]
    [DisplayName("Country Of Incorporation")]
    [IsoXmlTag("CtryOfIncorprtn")]
    public CountryCode? CountryOfIncorporation { get; init; } 
    
    /// <summary>
    /// Year during which the legal entity was officially incorporated.
    /// </summary>
    [IsoId("_Z5rJAPNyEeqRfth943bvEA")]
    [DisplayName("Year Of Incorporation")]
    [IsoXmlTag("YrOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    public IsoISOYear? YearOfIncorporation { get; init; } 
    
    /// <summary>
    /// Economical activity of the  investor.
    /// </summary>
    [IsoId("_Nu2K6fNyEeqRfth943bvEA")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.ISICIdentifier)]
    public IsoISICIdentifier? ActivityIndicator { get; init; } 
    
    /// <summary>
    /// Type of investor.
    /// </summary>
    [IsoId("_Nu2K6_NyEeqRfth943bvEA")]
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType1Choice_? InvestorType { get; init; } 
    
    /// <summary>
    /// Information about the ownership on an asset.
    /// </summary>
    [IsoId("_Nu2K7fNyEeqRfth943bvEA")]
    [DisplayName("Ownership")]
    [IsoXmlTag("Ownrsh")]
    public Ownership1? Ownership { get; init; } 
    
    
    #nullable disable
    
}
