// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICashAccount40"/>
[IsoId("_avXPcdcZEeqRFcf2R4bPBw")]
[DisplayName("Cash Account")]
public partial record CashAccount40
{
    /// <inheritdoc cref="ICashAccount40.Identification"/>
    [IsoId("_awzZ49cZEeqRFcf2R4bPBw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public AccountIdentification4Choice_? Identification { get; init; }

    /// <inheritdoc cref="ICashAccount40.Type"/>
    [IsoId("_awzZ5dcZEeqRFcf2R4bPBw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }

    /// <inheritdoc cref="ICashAccount40.Currency"/>
    [IsoId("_awzZ59cZEeqRFcf2R4bPBw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <inheritdoc cref="ICashAccount40.Name"/>
    [IsoId("_awzZ6dcZEeqRFcf2R4bPBw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <inheritdoc cref="ICashAccount40.Proxy"/>
    [IsoId("_awzZ69cZEeqRFcf2R4bPBw")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAccountIdentification1? Proxy { get; init; }
}
