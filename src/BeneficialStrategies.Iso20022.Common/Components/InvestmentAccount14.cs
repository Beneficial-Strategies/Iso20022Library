// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_RwiumNp-Ed-ak6NoX_4Aeg_1891202417")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount14
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_Rwiumdp-Ed-ak6NoX_4Aeg_1891202460")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification1 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_Rwiumtp-Ed-ak6NoX_4Aeg_1892123517")]
    [DisplayName("Account Name")]
    [IsoXmlTag("AcctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountName { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_Rwium9p-Ed-ak6NoX_4Aeg_1892123577")]
    [DisplayName("Account Designation")]
    [IsoXmlTag("AcctDsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountDesignation { get; init; } 
    
    /// <summary>
    /// Identification of an individual person whom legally owns the account.
    /// </summary>
    [IsoId("_Rwr4gNp-Ed-ak6NoX_4Aeg_-2080792073")]
    [DisplayName("Individual Owner Identification")]
    [IsoXmlTag("IndvOwnrId")]
    public IndividualPersonIdentificationChoice_? IndividualOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of an organisation that legally owns the account.
    /// </summary>
    [IsoId("_Rwr4gdp-Ed-ak6NoX_4Aeg_-1060958899")]
    [DisplayName("Organisation Owner Identification")]
    [IsoXmlTag("OrgOwnrId")]
    public PartyIdentification2Choice_? OrganisationOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Rwr4gtp-Ed-ak6NoX_4Aeg_173461103")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
