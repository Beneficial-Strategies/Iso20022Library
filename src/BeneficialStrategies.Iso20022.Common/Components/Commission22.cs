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
[IsoId("_dbfigz8BEeSIqOPJHpnleA")]
[DisplayName("Commission")]
public partial record Commission22
{
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_d10t8T8BEeSIqOPJHpnleA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType3Choice_ Type { get; init; } 
    
    /// <summary>
    /// Basis upon which a commission is charged, for example, flat fee.
    /// </summary>
    [IsoId("_d10t8z8BEeSIqOPJHpnleA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public CommissionBasis1Choice_? Basis { get; init; } 
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_d10t9T8BEeSIqOPJHpnleA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    [IsoId("_d10t9z8BEeSIqOPJHpnleA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_d10t-T8BEeSIqOPJHpnleA")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Voluntary non-enforcement of the right to part of a commission.
    /// </summary>
    [IsoId("_d10t-z8BEeSIqOPJHpnleA")]
    [DisplayName("Waiving Details")]
    [IsoXmlTag("WvgDtls")]
    public CommissionWaiver4? WaivingDetails { get; init; } 
    
    
    #nullable disable
    
}
