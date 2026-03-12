// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier of a the related Invoice.
/// </summary>
[IsoId("_ee6h2-F6EeWCAvUNsZ5u6g")]
[DisplayName("Billing Identification")]
public partial record BillingIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Unique reference of a the related Invoice.
    /// </summary>
    [IsoId("_eqOZ8-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Billing Identification")]
    [IsoXmlTag("BllgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text BillingIdentification { get; init; } 
    
    
    #nullable disable
    
}
