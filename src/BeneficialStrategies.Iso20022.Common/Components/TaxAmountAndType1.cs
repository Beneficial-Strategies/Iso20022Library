// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxAmountAndType1"/>
[IsoId("_ts1L0VkyEeGeoaLUQk__nA_404730048")]
[DisplayName("Tax Amount And Type")]
public partial record TaxAmountAndType1
{
    /// <inheritdoc cref="ITaxAmountAndType1.Type"/>
    [IsoId("_ts1L0lkyEeGeoaLUQk__nA_1414965637")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TaxAmountType1Choice_? Type { get; init; }

    /// <inheritdoc cref="ITaxAmountAndType1.Amount"/>
    [IsoId("_ts1L01kyEeGeoaLUQk__nA_-2046327832")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
