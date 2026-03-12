// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the exchange rate.
/// </summary>
[IsoId("_g9N7sINmEeuHqfO1LgkE9Q")]
[DisplayName("Exchange Rate Detail")]
public partial record ExchangeRateDetail1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the party to which this detail applies.
    /// </summary>
    [IsoId("_50VUUINoEeuHqfO1LgkE9Q")]
    [DisplayName("End Point")]
    [IsoXmlTag("EndPt")]
    public Endpoint1Code? EndPoint { get; init; } 
    
    /// <summary>
    /// Other nationally or privately defined endpoint.
    /// </summary>
    [IsoId("_JQ4h4INpEeuHqfO1LgkE9Q")]
    [DisplayName("Other End Point")]
    [IsoXmlTag("OthrEndPt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherEndPoint { get; init; } 
    
    /// <summary>
    /// Identifies the counter currency used for currency conversion for the transaction party.
    /// </summary>
    [IsoId("_ZXsNYINpEeuHqfO1LgkE9Q")]
    [DisplayName("Counter Currency Code")]
    [IsoXmlTag("CntrCcyCd")]
    public ISO3NumericCurrencyCode? CounterCurrencyCode { get; init; } 
    
    /// <summary>
    /// Identifies the base currency used for currency conversion for the transaction party.
    /// </summary>
    [IsoId("_jZtE4INpEeuHqfO1LgkE9Q")]
    [DisplayName("Base Currency Code")]
    [IsoXmlTag("BaseCcyCd")]
    public ISO3NumericCurrencyCode? BaseCurrencyCode { get; init; } 
    
    /// <summary>
    /// Contains the exchange rate.
    /// </summary>
    [IsoId("_zRp4MINtEeuHqfO1LgkE9Q")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.BaseOne25Rate)]
    public IsoBaseOne25Rate? Rate { get; init; } 
    
    /// <summary>
    /// Identifies the type of rate.
    /// </summary>
    [IsoId("_bcFjQIZ4EeuA-bTtGHZqdg")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public ExchangeRateType2Code? RateType { get; init; } 
    
    /// <summary>
    /// Other type of rate defined privately or at national level.
    /// </summary>
    [IsoId("_PHyqoIZ5EeuSbct6WWD-Ng")]
    [DisplayName("Other Rate Type")]
    [IsoXmlTag("OthrRateTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherRateType { get; init; } 
    
    /// <summary>
    /// Type of exchange rate agreement.
    /// </summary>
    [IsoId("_M4vHMIZ7EeuSbct6WWD-Ng")]
    [DisplayName("Agreement Type")]
    [IsoXmlTag("AgrmtTp")]
    public ExchangeRateAgreementType1Code? AgreementType { get; init; } 
    
    /// <summary>
    /// Other type of exchange rate agreement.
    /// </summary>
    [IsoId("_VgLeIIZ7EeuSbct6WWD-Ng")]
    [DisplayName("Other Agreement Type")]
    [IsoXmlTag("OthrAgrmtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherAgreementType { get; init; } 
    
    
    #nullable disable
    
}
