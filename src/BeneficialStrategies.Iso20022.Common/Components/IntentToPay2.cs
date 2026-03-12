// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of an intention to pay based on purchase orders or commercial invoice.
/// </summary>
[IsoId("_9-CfYRVaEeOCqpkCrPgk4g")]
[DisplayName("Intent To Pay")]
public partial record IntentToPay2
{
    #nullable enable
    
    /// <summary>
    /// Specifies if breakdown is by purchase order or commercial invoice.
    /// </summary>
    [IsoId("_Hn3ngBrZEeOVR9VN6fAMUg")]
    [DisplayName("Breakdown")]
    [IsoXmlTag("Brkdwn")]
    public required BreakDown1Choice_ Breakdown { get; init; } 
    
    /// <summary>
    /// Date at which the payment would be effected.
    /// </summary>
    [IsoId("_-X0RVxVaEeOCqpkCrPgk4g")]
    [DisplayName("Expected Payment Date")]
    [IsoXmlTag("XpctdPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ExpectedPaymentDate { get; init; } 
    
    /// <summary>
    /// Specifies the beneficiary&apos;s account information.
    /// </summary>
    [IsoId("_-X0RWRVaEeOCqpkCrPgk4g")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public SettlementTerms3? SettlementTerms { get; init; } 
    
    
    #nullable disable
    
}
