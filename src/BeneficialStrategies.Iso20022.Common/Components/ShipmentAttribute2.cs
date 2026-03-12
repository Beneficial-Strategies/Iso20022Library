// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further details on the shipment conditions.
/// </summary>
[IsoId("_u9kHQbGYEeuSTr8k0UEM8A")]
[DisplayName("Shipment Attribute")]
public partial record ShipmentAttribute2
{
    #nullable enable
    
    /// <summary>
    /// Shipment conditions.
    /// </summary>
    [IsoId("_u-la8bGYEeuSTr8k0UEM8A")]
    [DisplayName("Conditions")]
    [IsoXmlTag("Conds")]
    public ShipmentCondition1Choice_? Conditions { get; init; } 
    
    /// <summary>
    /// Expected shipment date.
    /// </summary>
    [IsoId("_u-la87GYEeuSTr8k0UEM8A")]
    [DisplayName("Expected Date")]
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedDate { get; init; } 
    
    /// <summary>
    /// Country in which the counter party is located.
    /// </summary>
    [IsoId("_u-la9bGYEeuSTr8k0UEM8A")]
    [DisplayName("Country Of Counter Party")]
    [IsoXmlTag("CtryOfCntrPty")]
    public CountryCode? CountryOfCounterParty { get; init; } 
    
    
    #nullable disable
    
}
