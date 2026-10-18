// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICashAccount24"/>
[IsoId("_scgzcFkyEeGeoaLUQk__nA_1552685101")]
[DisplayName("Cash Account")]
public partial record CashAccount24
{
    /// <inheritdoc cref="ICashAccount24.Identification"/>
    [IsoId("_scgzcVkyEeGeoaLUQk__nA_-1452983416")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required AccountIdentification4Choice_ Identification { get; init; }

    /// <inheritdoc cref="ICashAccount24.Type"/>
    [IsoId("_scp9YFkyEeGeoaLUQk__nA_1872061317")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }

    /// <inheritdoc cref="ICashAccount24.Currency"/>
    [IsoId("_scp9YVkyEeGeoaLUQk__nA_-1542574396")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <inheritdoc cref="ICashAccount24.Name"/>
    [IsoId("_scp9YlkyEeGeoaLUQk__nA_1328383068")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; }
}
