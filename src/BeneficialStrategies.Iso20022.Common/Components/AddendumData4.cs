// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum data structure is applicable to certain merchant verticals that require industry-specific data within transaction messages. 
/// </summary>
[IsoId("_D4FAcR1UEey8XKHwKquEQw")]
[DisplayName("Addendum Data")]
public partial record AddendumData4
{
    #nullable enable
    
    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_D-S9MR1UEey8XKHwKquEQw")]
    [DisplayName("Fleet")]
    [IsoXmlTag("Fleet")]
    public FleetData5? Fleet { get; init; } 
    
    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_sI2vkSX6Eeym0KcvJF9aDQ")]
    [DisplayName("Instalment")]
    [IsoXmlTag("Instlmt")]
    public Instalment4? Instalment { get; init; } 
    
    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_D-S9Mx1UEey8XKHwKquEQw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
