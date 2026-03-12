// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further detailed information on the exchange rate that has been used in or is related to the transaction.
/// </summary>
[IsoId("_ZGiv0INlEeuHqfO1LgkE9Q")]
[DisplayName("Exchange Rate Information")]
public partial record ExchangeRateInformation2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the source of the rate information.
    /// </summary>
    [IsoId("_FxfKMINmEeuHqfO1LgkE9Q")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Provider { get; init; } 
    
    /// <summary>
    /// Identification of the specific rate, table or file that contains the rate information.
    /// </summary>
    [IsoId("_NnqcQINmEeuHqfO1LgkE9Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Identification { get; init; } 
    
    /// <summary>
    /// The date the exchange rate data is effective.
    /// </summary>
    [IsoId("_T8oaQINmEeuHqfO1LgkE9Q")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// The time the exchange rate data is effective.
    /// </summary>
    [IsoId("_Zsv-wINmEeuHqfO1LgkE9Q")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; } 
    
    /// <summary>
    /// Details of a specific exchange rate
    /// </summary>
    [IsoId("_VjbfUINuEeuHqfO1LgkE9Q")]
    [DisplayName("Exchange Rate Detail")]
    [IsoXmlTag("XchgRateDtl")]
    public ExchangeRateDetail1? ExchangeRateDetail { get; init; } 
    
    /// <summary>
    /// Rate lock details.
    /// </summary>
    [IsoId("_wmRsQIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Rate Lock")]
    [IsoXmlTag("RateLck")]
    public RateLock1? RateLock { get; init; } 
    
    
    #nullable disable
    
}
