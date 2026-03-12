// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_QCHd4tp-Ed-ak6NoX_4Aeg_-1362353308")]
[DisplayName("Individual Person")]
public partial record IndividualPerson8
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QCHd49p-Ed-ak6NoX_4Aeg_-1362352862")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Name { get; init; } 
    
    /// <summary>
    /// First name of a person.
    /// </summary>
    [IsoId("_QCHd5Np-Ed-ak6NoX_4Aeg_-1362350362")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GivenName { get; init; } 
    
    /// <summary>
    /// Specifies the terms used to formally address a person.
    /// </summary>
    [IsoId("_QCHd5dp-Ed-ak6NoX_4Aeg_-1354042162")]
    [DisplayName("Name Prefix")]
    [IsoXmlTag("NmPrfx")]
    public NamePrefix1Code? NamePrefix { get; init; } 
    
    /// <summary>
    /// Additional information about a person that follows a person&apos;s name, for example, qualification such as Doctor of Philosophy (PhD).
    /// </summary>
    [IsoId("_QCHd5tp-Ed-ak6NoX_4Aeg_-1354041990")]
    [DisplayName("Name Suffix")]
    [IsoXmlTag("NmSfx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NameSuffix { get; init; } 
    
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    [IsoId("_QCHd59p-Ed-ak6NoX_4Aeg_-1354041947")]
    [DisplayName("Gender")]
    [IsoXmlTag("Gndr")]
    public GenderCode? Gender { get; init; } 
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QCRO4Np-Ed-ak6NoX_4Aeg_-1354041887")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BirthDate { get; init; } 
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_QCRO4dp-Ed-ak6NoX_4Aeg_-1354041515")]
    [DisplayName("Social Security Number")]
    [IsoXmlTag("SclSctyNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SocialSecurityNumber { get; init; } 
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_QCRO4tp-Ed-ak6NoX_4Aeg_349983267")]
    [DisplayName("Individual Investor Address")]
    [IsoXmlTag("IndvInvstrAdr")]
    public required PostalAddress1 IndividualInvestorAddress { get; init; } 
    
    
    #nullable disable
    
}
