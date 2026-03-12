// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit of amounts for the customer.
/// </summary>
[IsoId("_awno0Yq2EeSIDtZ76p6McQ")]
[DisplayName("ATM Transaction Amounts")]
public partial record ATMTransactionAmounts3
{
    #nullable enable
    
    /// <summary>
    /// Type of limit.
    /// </summary>
    [IsoId("_vxjE8Iq2EeSIDtZ76p6McQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Label of the limit to display or print.
    /// </summary>
    [IsoId("__7eV4Iq2EeSIDtZ76p6McQ")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Label { get; init; } 
    
    /// <summary>
    /// Currency of the limit amount.
    /// </summary>
    [IsoId("_a9CUMYq2EeSIDtZ76p6McQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; } 
    
    /// <summary>
    /// Minimum amount value in the currency of the limit.
    /// </summary>
    [IsoId("_a9CUNYq2EeSIDtZ76p6McQ")]
    [DisplayName("Minimum Amount")]
    [IsoXmlTag("MinAmt")]
    public ImpliedCurrencyAndAmount? MinimumAmount { get; init; } 
    
    /// <summary>
    /// Maximum amount value in the currency of the limit.
    /// </summary>
    [IsoId("_a9CUM4q2EeSIDtZ76p6McQ")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    
    
    #nullable disable
    
}
