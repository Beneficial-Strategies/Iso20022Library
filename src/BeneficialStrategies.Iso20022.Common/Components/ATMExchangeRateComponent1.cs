// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Exchange Rate Component1.
/// </summary>
[IsoId("_GtUHkJ2oEe-4seDr3Li2Ew")]
[DisplayName("ATM Exchange Rate Component1")]
public partial record ATMExchangeRateComponent1
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax256Text? AdditionalInformation { get; init; } 

    /// <summary>
    /// Exchange Rate.
    /// </summary>
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    public required IsoPercentageRate ExchangeRate { get; init; } 

    /// <summary>
    /// Publish Date.
    /// </summary>
    [DisplayName("Publish Date")]
    [IsoXmlTag("PblshDt")]
    public required IsoISODateTime PublishDate { get; init; } 

    
    #nullable disable
    
}
