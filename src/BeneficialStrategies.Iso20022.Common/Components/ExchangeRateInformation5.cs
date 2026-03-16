// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Exchange Rate Information5.
/// </summary>
[IsoId("_8pxMcW3iEe6dwbOqHXrHWg")]
[DisplayName("Exchange Rate Information5")]
public partial record ExchangeRateInformation5
{
    #nullable enable

    /// <summary>
    /// Agreement Type.
    /// </summary>
    [DisplayName("Agreement Type")]
    [IsoXmlTag("AgrmtTp")]
    public ExchangeRateAgreementType1Code? AgreementType { get; init; } 

    /// <summary>
    /// Base Currency Code.
    /// </summary>
    [DisplayName("Base Currency Code")]
    [IsoXmlTag("BaseCcyCd")]
    public ISO3NumericCurrencyCode? BaseCurrencyCode { get; init; } 

    /// <summary>
    /// Counter Currency Code.
    /// </summary>
    [DisplayName("Counter Currency Code")]
    [IsoXmlTag("CntrCcyCd")]
    public ISO3NumericCurrencyCode? CounterCurrencyCode { get; init; } 

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// End Point.
    /// </summary>
    [DisplayName("End Point")]
    [IsoXmlTag("EndPt")]
    public Endpoint1Code? EndPoint { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; } 

    /// <summary>
    /// Other Agreement Type.
    /// </summary>
    [DisplayName("Other Agreement Type")]
    [IsoXmlTag("OthrAgrmtTp")]
    public IsoMax35Text? OtherAgreementType { get; init; } 

    /// <summary>
    /// Other End Point.
    /// </summary>
    [DisplayName("Other End Point")]
    [IsoXmlTag("OthrEndPt")]
    public IsoMax35Text? OtherEndPoint { get; init; } 

    /// <summary>
    /// Other Rate Type.
    /// </summary>
    [DisplayName("Other Rate Type")]
    [IsoXmlTag("OthrRateTp")]
    public IsoMax35Text? OtherRateType { get; init; } 

    /// <summary>
    /// Provider.
    /// </summary>
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public IsoMax70Text? Provider { get; init; } 

    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoBaseOne25Rate? Rate { get; init; } 

    /// <summary>
    /// Rate Lock Applied.
    /// </summary>
    [DisplayName("Rate Lock Applied")]
    [IsoXmlTag("RateLckApld")]
    public IsoTrueFalseIndicator? RateLockApplied { get; init; } 

    /// <summary>
    /// Rate Lock Eligible.
    /// </summary>
    [DisplayName("Rate Lock Eligible")]
    [IsoXmlTag("RateLckElgbl")]
    public IsoTrueFalseIndicator? RateLockEligible { get; init; } 

    /// <summary>
    /// Rate Lock Requested.
    /// </summary>
    [DisplayName("Rate Lock Requested")]
    [IsoXmlTag("RateLckReqd")]
    public IsoTrueFalseIndicator? RateLockRequested { get; init; } 

    /// <summary>
    /// Rate Type.
    /// </summary>
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public ExchangeRateType2Code? RateType { get; init; } 

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; } 

    
    #nullable disable
    
}
