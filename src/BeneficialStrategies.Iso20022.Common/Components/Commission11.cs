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
[IsoId("_RsXZNtp-Ed-ak6NoX_4Aeg_1316757656")]
[DisplayName("Commission")]
public partial record Commission11
{
    #nullable enable
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_RshKMNp-Ed-ak6NoX_4Aeg_1316757691")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAnd13DecimalAmount? Amount { get; init; } 
    
    /// <summary>
    /// Commission expressed as a percentage.
    /// </summary>
    [IsoId("_RshKMdp-Ed-ak6NoX_4Aeg_1316758028")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; } 
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_RsqUINp-Ed-ak6NoX_4Aeg_1316757675")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CommissionType6Code? Type { get; init; } 
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_RsqUIdp-Ed-ak6NoX_4Aeg_-488067403")]
    [DisplayName("Extended Type")]
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedType { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_RsqUItp-Ed-ak6NoX_4Aeg_2125535368")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Indicates if the CommercialAgreementReference is a new reference or not.
    /// </summary>
    [IsoId("_RsqUI9p-Ed-ak6NoX_4Aeg_2110760457")]
    [DisplayName("New Commercial Agreement Reference Indicator")]
    [IsoXmlTag("NewComrclAgrmtRefInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewCommercialAgreementReferenceIndicator { get; init; } 
    
    
    #nullable disable
    
}
