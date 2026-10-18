// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICashAccount38"/>
[IsoId("_TnJx8Xh1EeidzqjNEfehPg")]
[DisplayName("Cash Account")]
public partial record CashAccount38
{
    /// <inheritdoc cref="ICashAccount38.Identification"/>
    [IsoId("_T4SlQ3h1EeidzqjNEfehPg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification4Choice_ Identification { get; init; }

    /// <inheritdoc cref="ICashAccount38.Type"/>
    [IsoId("_T4SlRXh1EeidzqjNEfehPg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }

    /// <inheritdoc cref="ICashAccount38.Currency"/>
    [IsoId("_T4SlR3h1EeidzqjNEfehPg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <inheritdoc cref="ICashAccount38.Name"/>
    [IsoId("_T4SlSXh1EeidzqjNEfehPg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }

    /// <inheritdoc cref="ICashAccount38.Proxy"/>
    [IsoId("_dOFYgXiMEeidzqjNEfehPg")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public ProxyAccountIdentification1? Proxy { get; init; }
}
