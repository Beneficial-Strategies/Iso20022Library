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
[IsoId("_hLSRESSDEeWdoOFYMt-Lzw")]
[DisplayName("Commission")]
public partial record Commission23
{
    #nullable enable
    
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_hoJMMSSDEeWdoOFYMt-Lzw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType3Choice_ Type { get; init; } 
    
    /// <summary>
    /// Basis upon which a commission is charged, for example, flat fee.
    /// </summary>
    [IsoId("_hoJMMySDEeWdoOFYMt-Lzw")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public CommissionBasis1Choice_? Basis { get; init; } 
    
    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_hoJMNSSDEeWdoOFYMt-Lzw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    [IsoId("_hoJMNySDEeWdoOFYMt-Lzw")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification70Choice_? RecipientIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_hoJMOSSDEeWdoOFYMt-Lzw")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    
    /// <summary>
    /// Voluntary non-enforcement of the right to part of a commission.
    /// </summary>
    [IsoId("_hoJMOySDEeWdoOFYMt-Lzw")]
    [DisplayName("Waiving Details")]
    [IsoXmlTag("WvgDtls")]
    public CommissionWaiver4? WaivingDetails { get; init; } 
    
    
    #nullable disable
    
}
