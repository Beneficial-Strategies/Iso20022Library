// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further detailed information on the exchange rate that has been used in the payment transaction.
/// </summary>
[IsoId("_QLp0Ytp-Ed-ak6NoX_4Aeg_-1204184302")]
[DisplayName("Exchange Rate Information")]
public partial record ExchangeRateInformation1
{
    #nullable enable
    
    /// <summary>
    /// The factor used for conversion of an amount from one currency to another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_QLp0Y9p-Ed-ak6NoX_4Aeg_-940984267")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Specifies the type used to complete the currency exchange.
    /// </summary>
    [IsoId("_QLp0ZNp-Ed-ak6NoX_4Aeg_-940984241")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public ExchangeRateType1Code? RateType { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous reference to the foreign exchange contract agreed between the initiating party/creditor and the debtor agent.
    /// </summary>
    [IsoId("_QLp0Zdp-Ed-ak6NoX_4Aeg_-941904256")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ContractIdentification { get; init; } 
    
    
    #nullable disable
    
}
