// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_VPdsgtp-Ed-ak6NoX_4Aeg_-594951840")]
[DisplayName("Commission")]
public partial record Commission6
{
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_VPdsg9p-Ed-ak6NoX_4Aeg_-594951798")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CommissionType1? Type { get; init; } 
    
    /// <summary>
    /// Basis upon which a commission is charged, eg, flat fee.
    /// </summary>
    [IsoId("_VPdshNp-Ed-ak6NoX_4Aeg_-594951486")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis1? Basis { get; init; } 
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_VPdshdp-Ed-ak6NoX_4Aeg_-594951780")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    
    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_VPdshtp-Ed-ak6NoX_4Aeg_-594951763")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    [IsoId("_VPdsh9p-Ed-ak6NoX_4Aeg_-594951528")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_VPdsiNp-Ed-ak6NoX_4Aeg_-594951503")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Voluntary non-enforcement of the right to all or part of a commission.
    /// </summary>
    [IsoId("_VPdsidp-Ed-ak6NoX_4Aeg_1252714536")]
    [DisplayName("Waiving Details")]
    [IsoXmlTag("WvgDtls")]
    public CommissionWaiver2? WaivingDetails { get; init; } 
    
    
    #nullable disable
    
}
