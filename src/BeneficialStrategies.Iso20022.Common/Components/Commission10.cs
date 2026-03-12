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
[IsoId("_RsqUMNp-Ed-ak6NoX_4Aeg_-504427257")]
[DisplayName("Commission")]
public partial record Commission10
{
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_Rs0FINp-Ed-ak6NoX_4Aeg_-504427255")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CommissionType6Code? Type { get; init; } 
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_Rs0FIdp-Ed-ak6NoX_4Aeg_-74065538")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedType { get; init; } 
    
    /// <summary>
    /// Basis upon which a commission is charged, eg, flat fee.
    /// </summary>
    [IsoId("_Rs0FItp-Ed-ak6NoX_4Aeg_-504426872")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis4Code? Basis { get; init; } 
    
    /// <summary>
    /// Basis upon which a commission is charged, eg, flat fee.
    /// </summary>
    [IsoId("_Rs0FI9p-Ed-ak6NoX_4Aeg_51745564")]
    [DisplayName("Extended Basis")]
    [IsoXmlTag("XtndedBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedBasis { get; init; } 
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_Rs0FJNp-Ed-ak6NoX_4Aeg_-504426837")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    
    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_Rs0FJdp-Ed-ak6NoX_4Aeg_-504426819")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    [IsoId("_Rs0FJtp-Ed-ak6NoX_4Aeg_-504426794")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_Rs0FJ9p-Ed-ak6NoX_4Aeg_-504426777")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Voluntary non-enforcement of the right to all or part of a commission.
    /// </summary>
    [IsoId("_Rs0FKNp-Ed-ak6NoX_4Aeg_-504426732")]
    [DisplayName("Waiving Details")]
    [IsoXmlTag("WvgDtls")]
    public CommissionWaiver3? WaivingDetails { get; init; } 
    
    
    #nullable disable
    
}
