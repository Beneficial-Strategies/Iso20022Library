// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional fee reconciliation data.
/// </summary>
[IsoId("_fULtkaIAEeuiuNcvKhXmNQ")]
[DisplayName("Additional Fee Reconciliation")]
public partial record AdditionalFeeReconciliation2
{
    #nullable enable
    
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    [IsoId("_fZQa0aIAEeuiuNcvKhXmNQ")]
    [DisplayName("Reconciliation Impact")]
    [IsoXmlTag("RcncltnImpct")]
    public required ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    
    /// <summary>
    /// contains the list of additional fee types.
    /// </summary>
    [IsoId("_fZQa06IAEeuiuNcvKhXmNQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount21Code Type { get; init; } 
    
    /// <summary>
    /// Other amount type defined at national or private level.
    /// </summary>
    [IsoId("_fZQa1aIAEeuiuNcvKhXmNQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// ISO 8583:87 bit 82, 83, 84 &amp; 85
    /// ISO 8583:93/2003 bit 109 &amp; 110
    /// </summary>
    [IsoId("_fZQa16IAEeuiuNcvKhXmNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_fZQa2aIAEeuiuNcvKhXmNQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; } 
    
    
    #nullable disable
    
}
