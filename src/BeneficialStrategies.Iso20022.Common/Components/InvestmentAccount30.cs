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
[IsoId("_Rz0FB9p-Ed-ak6NoX_4Aeg_1707158574")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount30
{
    #nullable enable
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_Rz0FCNp-Ed-ak6NoX_4Aeg_430254594")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required SecuritiesAccount5 Account { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_Rz92ANp-Ed-ak6NoX_4Aeg_1708078660")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Rz92Adp-Ed-ak6NoX_4Aeg_-1876009616")]
    [DisplayName("Owner")]
    [IsoXmlTag("Ownr")]
    public PartyIdentification2Choice_? Owner { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_Rz92Atp-Ed-ak6NoX_4Aeg_-1757799352")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public PartyIdentification2Choice_? Servicer { get; init; } 
    
    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    [IsoId("_Rz92A9p-Ed-ak6NoX_4Aeg_-708116020")]
    [DisplayName("Sub Account")]
    [IsoXmlTag("SubAcct")]
    public SubAccount3? SubAccount { get; init; } 
    
    
    #nullable disable
    
}
