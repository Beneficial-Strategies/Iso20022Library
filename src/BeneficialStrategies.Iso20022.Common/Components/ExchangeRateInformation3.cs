// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Exchange Rate Information3.
/// </summary>
[IsoId("_X6_SkNH-Ee20cKCFrGj2Qw")]
[DisplayName("Exchange Rate Information3")]
public partial record ExchangeRateInformation3
{
    #nullable enable

    /// <summary>
    /// Contract Identification.
    /// </summary>
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    public IsoMax35Text? ContractIdentification { get; init; } 

    /// <summary>
    /// Rate Type.
    /// </summary>
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required ExchangeRateType4Code RateType { get; init; } 

    
    #nullable disable
    
}
