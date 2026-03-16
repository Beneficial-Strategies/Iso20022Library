// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification275.
/// </summary>
[IsoId("_xP8b11x7Ee6fgZt44_IqFA")]
[DisplayName("Party Identification275")]
public partial record PartyIdentification275
{
    #nullable enable

    /// <summary>
    /// Activity Indicator.
    /// </summary>
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public ActivityIndicator1Choice_? ActivityIndicator { get; init; } 

    /// <summary>
    /// Country Of Incorporation.
    /// </summary>
    [DisplayName("Country Of Incorporation")]
    [IsoXmlTag("CtryOfIncorprtn")]
    public CountryCode? CountryOfIncorporation { get; init; } 

    /// <summary>
    /// Email Address.
    /// </summary>
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    public IsoMax256Text? EmailAddress { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification198Choice_ Identification { get; init; } 

    /// <summary>
    /// Investor Type.
    /// </summary>
    [DisplayName("Investor Type")]
    [IsoXmlTag("InvstrTp")]
    public InvestorType1Choice_? InvestorType { get; init; } 

    /// <summary>
    /// Name And Address.
    /// </summary>
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required NameAndAddress17 NameAndAddress { get; init; } 

    /// <summary>
    /// Ownership.
    /// </summary>
    [DisplayName("Ownership")]
    [IsoXmlTag("Ownrsh")]
    public Ownership1? Ownership { get; init; } 

    /// <summary>
    /// Year Of Incorporation.
    /// </summary>
    [DisplayName("Year Of Incorporation")]
    [IsoXmlTag("YrOfIncorprtn")]
    public IsoISOYear? YearOfIncorporation { get; init; } 

    
    #nullable disable
    
}
