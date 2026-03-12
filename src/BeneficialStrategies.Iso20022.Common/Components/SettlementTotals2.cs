// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement totals or the report.
/// </summary>
[IsoId("_ciULEZMnEeuleeHpFMMhmQ")]
[DisplayName("Settlement Totals")]
public partial record SettlementTotals2
{
    #nullable enable
    
    /// <summary>
    /// Settlement totals for the acquirer.
    /// </summary>
    [IsoId("_cpvBsZMnEeuleeHpFMMhmQ")]
    [DisplayName("Acquirer Totals")]
    [IsoXmlTag("AcqrrTtls")]
    public SettlementCategoryTotal2? AcquirerTotals { get; init; } 
    
    /// <summary>
    /// Settlement totals for the issuer.
    /// </summary>
    [IsoId("_cpvBs5MnEeuleeHpFMMhmQ")]
    [DisplayName("Issuer Totals")]
    [IsoXmlTag("IssrTtls")]
    public SettlementCategoryTotal2? IssuerTotals { get; init; } 
    
    /// <summary>
    /// Other settlement totals.
    /// </summary>
    [IsoId("_cpvBtZMnEeuleeHpFMMhmQ")]
    [DisplayName("Other Totals")]
    [IsoXmlTag("OthrTtls")]
    public SettlementCategoryTotal2? OtherTotals { get; init; } 
    
    /// <summary>
    /// Total amount settled.
    /// </summary>
    [IsoId("_cpvBt5MnEeuleeHpFMMhmQ")]
    [DisplayName("Total Settlement Amount")]
    [IsoXmlTag("TtlSttlmAmt")]
    public SettlementCategoryTotal2? TotalSettlementAmount { get; init; } 
    
    
    #nullable disable
    
}
