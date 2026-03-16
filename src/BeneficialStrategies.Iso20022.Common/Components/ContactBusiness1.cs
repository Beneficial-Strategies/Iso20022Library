// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact Business1.
/// </summary>
[IsoId("_7vkj4XNaEe6Y1uOeeiF_Eg")]
[DisplayName("Contact Business1")]
public partial record ContactBusiness1
{
    #nullable enable

    /// <summary>
    /// Email.
    /// </summary>
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; } 

    /// <summary>
    /// Fax.
    /// </summary>
    [DisplayName("Fax")]
    [IsoXmlTag("Fax")]
    public IsoPhoneNumber? Fax { get; init; } 

    /// <summary>
    /// Given Name.
    /// </summary>
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public IsoMax35Text? GivenName { get; init; } 

    /// <summary>
    /// Language.
    /// </summary>
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public ISO2ALanguageCode? Language { get; init; } 

    /// <summary>
    /// Last Name.
    /// </summary>
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public IsoMax35Text? LastName { get; init; } 

    /// <summary>
    /// Middle Name.
    /// </summary>
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public IsoMax35Text? MiddleName { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; } 

    /// <summary>
    /// Phone.
    /// </summary>
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public IsoPhoneNumber? Phone { get; init; } 

    /// <summary>
    /// Property Phone.
    /// </summary>
    [DisplayName("Property Phone")]
    [IsoXmlTag("PrprtyPhne")]
    public IsoPhoneNumber? PropertyPhone { get; init; } 

    /// <summary>
    /// Toll Free Phone.
    /// </summary>
    [DisplayName("Toll Free Phone")]
    [IsoXmlTag("TollFreePhne")]
    public IsoPhoneNumber? TollFreePhone { get; init; } 

    /// <summary>
    /// URL.
    /// </summary>
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public IsoMax256Text? URL { get; init; } 

    
    #nullable disable
    
}
