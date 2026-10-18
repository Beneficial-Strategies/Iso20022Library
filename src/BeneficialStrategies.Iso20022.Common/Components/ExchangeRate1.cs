// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IExchangeRate1"/>
[IsoId("_t0booVkyEeGeoaLUQk__nA_667162887")]
[DisplayName("Exchange Rate")]
public partial record ExchangeRate1
{
    /// <inheritdoc cref="IExchangeRate1.UnitCurrency"/>
    [IsoId("_t0boolkyEeGeoaLUQk__nA_-816743916")]
    [DisplayName("Unit Currency")]
    [IsoXmlTag("UnitCcy")]
    public ActiveOrHistoricCurrencyCode? UnitCurrency { get; init; }

    /// <inheritdoc cref="IExchangeRate1.ExchangeRate"/>
    [IsoId("_t0boo1kyEeGeoaLUQk__nA_2015981061")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <inheritdoc cref="IExchangeRate1.RateType"/>
    [IsoId("_t0bopFkyEeGeoaLUQk__nA_1712924546")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public ExchangeRateType1Code? RateType { get; init; }

    /// <inheritdoc cref="IExchangeRate1.ContractIdentification"/>
    [IsoId("_t0bopVkyEeGeoaLUQk__nA_198863021")]
    [DisplayName("Contract Identification")]
    [IsoXmlTag("CtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ContractIdentification { get; init; }
}
