// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IExchangeRateInformation1"/>
[IsoId("_QLp0Ytp-Ed-ak6NoX_4Aeg_-1204184302")]
[DisplayName("Exchange Rate Information")]
public partial record ExchangeRateInformation1
{
    /// <inheritdoc cref="IExchangeRateInformation1.ExchangeRate"/>
    [IsoId("_QLp0Y9p-Ed-ak6NoX_4Aeg_-940984267")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IExchangeRateInformation1.RateType"/>
    [IsoId("_QLp0ZNp-Ed-ak6NoX_4Aeg_-940984241")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public ExchangeRateType1Code? RateType { get; init; }

    /// <inheritdoc cref="IExchangeRateInformation1.ContractIdentification"/>
    [IsoId("_QLp0Zdp-Ed-ak6NoX_4Aeg_-941904256")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ContractIdentification { get; init; }
}
