// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
[IsoId("_k2l3kO5NEeCisYr99QEiWA_-1812697527")]
[DisplayName("Cash Account Statement")]
public partial record CashAccountStatement1
{
    #nullable enable
    
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_k2l3ke5NEeCisYr99QEiWA_1470807263")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SystemDate { get; init; } 
    
    /// <summary>
    /// Provides information on the actual change occurred to the cash account.
    /// </summary>
    [IsoId("_k2l3ku5NEeCisYr99QEiWA_1400190648")]
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public CashAccountReferenceDataChange1? Change { get; init; } 
    
    
    #nullable disable
    
}
