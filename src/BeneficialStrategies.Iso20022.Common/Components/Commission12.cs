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
[IsoId("_RsEeQ9p-Ed-ak6NoX_4Aeg_356134401")]
[DisplayName("Commission")]
public partial record Commission12
{
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_RsEeRNp-Ed-ak6NoX_4Aeg_356134419")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType7Code Type { get; init; } 
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_RsEeRdp-Ed-ak6NoX_4Aeg_356134444")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedType { get; init; } 
    
    /// <summary>
    /// Basis upon which a commission is charged, eg, flat fee.
    /// </summary>
    [IsoId("_RsEeRtp-Ed-ak6NoX_4Aeg_356134479")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis4Code? Basis { get; init; } 
    
    /// <summary>
    /// Basis upon which a commission is charged, eg, flat fee.
    /// </summary>
    [IsoId("_RsEeR9p-Ed-ak6NoX_4Aeg_356134504")]
    [DisplayName("Extended Basis")]
    [IsoXmlTag("XtndedBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedBasis { get; init; } 
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_RsEeSNp-Ed-ak6NoX_4Aeg_356134539")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    [IsoId("_RsEeSdp-Ed-ak6NoX_4Aeg_356134574")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_RsNoMNp-Ed-ak6NoX_4Aeg_356134616")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    
    #nullable disable
    
}
