// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
[IsoId("_PdBMwdp-Ed-ak6NoX_4Aeg_920823246")]
[DisplayName("Tax Party")]
public partial record TaxParty2
{
    #nullable enable
    
    /// <summary>
    /// Tax identification number of the debtor.
    /// </summary>
    [IsoId("_PdBMwtp-Ed-ak6NoX_4Aeg_920823361")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_PdBMw9p-Ed-ak6NoX_4Aeg_920823300")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; } 
    
    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_PdBMxNp-Ed-ak6NoX_4Aeg_920823277")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; } 
    
    /// <summary>
    /// Details of the authorised tax paying party.
    /// </summary>
    [IsoId("_PdBMxdp-Ed-ak6NoX_4Aeg_-137944593")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public TaxAuthorisation1? Authorisation { get; init; } 
    
    
    #nullable disable
    
}
