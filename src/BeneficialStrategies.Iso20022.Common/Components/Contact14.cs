// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contact14.
/// </summary>
[IsoId("_YYdtSTE_Ee62xuUQ2zyZww")]
[DisplayName("Contact14")]
public partial record Contact14
{
    #nullable enable

    /// <summary>
    /// Department.
    /// </summary>
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    public IsoMax70Text? Department { get; init; } 

    /// <summary>
    /// Email Address.
    /// </summary>
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    public IsoMax256Text? EmailAddress { get; init; } 

    /// <summary>
    /// Email Purpose.
    /// </summary>
    [DisplayName("Email Purpose")]
    [IsoXmlTag("EmailPurp")]
    public IsoMax35Text? EmailPurpose { get; init; } 

    /// <summary>
    /// Fax Number.
    /// </summary>
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    public IsoPhoneNumber? FaxNumber { get; init; } 

    /// <summary>
    /// Job Title.
    /// </summary>
    [DisplayName("Job Title")]
    [IsoXmlTag("JobTitl")]
    public IsoMax35Text? JobTitle { get; init; } 

    /// <summary>
    /// Mobile Number.
    /// </summary>
    [DisplayName("Mobile Number")]
    [IsoXmlTag("MobNb")]
    public IsoPhoneNumber? MobileNumber { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax140Text? Name { get; init; } 

    /// <summary>
    /// Name Prefix.
    /// </summary>
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix2Code? NamePrefix { get; init; } 

    /// <summary>
    /// Other.
    /// </summary>
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherContact1> Other { get; init; } = [];

    /// <summary>
    /// Phone Number.
    /// </summary>
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    public IsoPhoneNumber? PhoneNumber { get; init; } 

    /// <summary>
    /// Preferred Method.
    /// </summary>
    [DisplayName("Preferred Method")]
    [IsoXmlTag("PrefrdMtd")]
    public PreferredContactMethod2Code? PreferredMethod { get; init; } 

    /// <summary>
    /// Responsibility.
    /// </summary>
    [DisplayName("Responsibility")]
    [IsoXmlTag("Rspnsblty")]
    public IsoMax35Text? Responsibility { get; init; } 

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public IsoMax2048Text? URLAddress { get; init; } 

    /// <summary>
    /// Valid From.
    /// </summary>
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public IsoISODate? ValidFrom { get; init; } 

    /// <summary>
    /// Valid To.
    /// </summary>
    [DisplayName("Valid To")]
    [IsoXmlTag("VldTo")]
    public IsoISODate? ValidTo { get; init; } 

    
    #nullable disable
    
}
