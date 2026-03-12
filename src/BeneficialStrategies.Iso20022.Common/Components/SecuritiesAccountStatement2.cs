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
[IsoId("_QDcSkeGBEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Statement")]
public partial record SecuritiesAccountStatement2
{
    #nullable enable
    
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    [IsoId("_QPfxkeGBEeWCAvUNsZ5u6g")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate SystemDate { get; init; } 
    
    /// <summary>
    /// Provides information on the actual change occurred to a securities account.
    /// </summary>
    [IsoId("_QPfxk-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Change")]
    [IsoXmlTag("Chng")]
    public SecuritiesAccountReferenceDataChange2? Change { get; init; } 
    
    
    #nullable disable
    
}
