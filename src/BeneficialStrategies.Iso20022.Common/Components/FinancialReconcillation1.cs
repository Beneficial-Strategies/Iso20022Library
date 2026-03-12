// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains financial reconciliation data.
/// </summary>
[IsoId("_OeFcWcypEeiqqJhU2tqK8A")]
[DisplayName("Financial Reconcillation")]
public partial record FinancialReconcillation1
{
    #nullable enable
    
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    [IsoId("_OeGDY8ypEeiqqJhU2tqK8A")]
    [DisplayName("Reconciliation Impact")]
    [IsoXmlTag("RcncltnImpct")]
    public required ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    
    /// <summary>
    /// Contains the reconciliation category.
    /// </summary>
    [IsoId("_OeGDZcypEeiqqJhU2tqK8A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReconciliationCategory1Code Type { get; init; } 
    
    /// <summary>
    /// Other reconciliation category defined at national or private level.
    /// </summary>
    [IsoId("_OeGDYcypEeiqqJhU2tqK8A")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// ISO 8583:87 bit 86,87,88 &amp; 89
    /// ISO 8583:93 bit 86,87,88 ,89,105 &amp; 106
    /// ISO 8583:2003 bit 74-1,74-3,74-5,74-7,74-9 &amp; 74-11
    /// </summary>
    [IsoId("_OeGDZMypEeiqqJhU2tqK8A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Number of transactions.
    /// ISO 8583:87 bit 74, 75, 76, 77, 78, 79 &amp; 81
    /// ISO 8583:93 bit 74, 75, 76, 77, 78, 79, 80, 81, 83, 84, 85, 90, 107 &amp; 108
    /// ISO 8583:2003 bit 74-2, 74-4, 74-6, 74-8, 74-10, 74-12, 75-1, 75-2, 75-4, 75-5, 75-6, 76-7, 75-8 &amp; 75-9
    /// </summary>
    [IsoId("_hSSlYcytEeiqqJhU2tqK8A")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; } 
    
    
    #nullable disable
    
}
