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
[IsoId("_LudzZsy0EeiqqJhU2tqK8A")]
[DisplayName("Additional Fee Reconciliation")]
public partial record AdditionalFeeReconciliation1
{
    #nullable enable
    
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    [IsoId("_Ludzasy0EeiqqJhU2tqK8A")]
    [DisplayName("Reconciliation Impact")]
    [IsoXmlTag("RcncltnImpct")]
    public required ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    
    /// <summary>
    /// contains the list of additional fee types.
    /// </summary>
    [IsoId("_LudzZ8y0EeiqqJhU2tqK8A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount10Code Type { get; init; } 
    
    /// <summary>
    /// Other amount type defined at national or private level.
    /// </summary>
    [IsoId("_LudzaMy0EeiqqJhU2tqK8A")]
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
    [IsoId("_Ludza8y0EeiqqJhU2tqK8A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_Ludzacy0EeiqqJhU2tqK8A")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Count { get; init; } 
    
    
    #nullable disable
    
}
