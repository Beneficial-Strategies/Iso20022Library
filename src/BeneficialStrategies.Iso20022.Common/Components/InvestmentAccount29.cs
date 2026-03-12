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
[IsoId("_RxbfZ9p-Ed-ak6NoX_4Aeg_-2016735960")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount29
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_RxbfaNp-Ed-ak6NoX_4Aeg_-2016735934")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_Rxbfadp-Ed-ak6NoX_4Aeg_-2016735918")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; } 
    
    /// <summary>
    /// Legal form of the fund, eg, UCITS, SICAV, OEIC, Unit Trust, and FCP.
    /// </summary>
    [IsoId("_Rxbfatp-Ed-ak6NoX_4Aeg_-2016735883")]
    [DisplayName("Fund Type")]
    [IsoXmlTag("FndTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FundType { get; init; } 
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_Rxbfa9p-Ed-ak6NoX_4Aeg_-2016735617")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; } 
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_RxlQYNp-Ed-ak6NoX_4Aeg_-2016735555")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public FinancialInstrument10? SecurityDetails { get; init; } 
    
    /// <summary>
    /// Identification of an individual person whom legally owns the account.
    /// </summary>
    [IsoId("_RxlQYdp-Ed-ak6NoX_4Aeg_-2016735419")]
    [DisplayName("Individual Owner Identification")]
    [IsoXmlTag("IndvOwnrId")]
    public IndividualPersonIdentificationChoice_? IndividualOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of an organisation that legally owns the account.
    /// </summary>
    [IsoId("_RxlQYtp-Ed-ak6NoX_4Aeg_-2016735454")]
    [DisplayName("Organisation Owner Identification")]
    [IsoXmlTag("OrgOwnrId")]
    public PartyIdentification5Choice_? OrganisationOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_RxlQY9p-Ed-ak6NoX_4Aeg_-2016735376")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary7> Intermediary { get; init; } = new ValueList<Intermediary7>(){};
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_RxlQZNp-Ed-ak6NoX_4Aeg_-2016735514")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
