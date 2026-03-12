// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the transaction amount.
/// </summary>
[IsoId("_wXx-4ZJREeuuktRxxQZoNQ")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount22
{
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_wePzQZJREeuuktRxxQZoNQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ISO8583AmountTypeCode Type { get; init; } 
    
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_wePzQ5JREeuuktRxxQZoNQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_F_QWgSuFEeyg-aG5nXcnfg")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 
    
    /// <summary>
    /// Detailed amount expressed in the transaction currency.
    /// </summary>
    [IsoId("_wePzRZJREeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Detailed amount expressed in the cardholder billing currency.
    /// </summary>
    [IsoId("_wePzR5JREeuuktRxxQZoNQ")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public ImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; } 
    
    /// <summary>
    /// Detailed amount expressed in the reconciliation currency. 
    /// </summary>
    [IsoId("_weQaUZJREeuuktRxxQZoNQ")]
    [DisplayName("Reconciliation Amount")]
    [IsoXmlTag("RcncltnAmt")]
    public ImpliedCurrencyAndAmount? ReconciliationAmount { get; init; } 
    
    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    [IsoId("_weQaU5JREeuuktRxxQZoNQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Description { get; init; } 
    
    
    #nullable disable
    
}
