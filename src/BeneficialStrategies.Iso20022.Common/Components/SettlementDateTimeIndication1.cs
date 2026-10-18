// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementDateTimeIndication1"/>
[IsoId("_QIYeB9p-Ed-ak6NoX_4Aeg_-498720410")]
[DisplayName("Settlement Date Time Indication")]
public partial record SettlementDateTimeIndication1
{
    /// <inheritdoc cref="ISettlementDateTimeIndication1.DebitDateTime"/>
    [IsoId("_QIhn4Np-Ed-ak6NoX_4Aeg_-425762310")]
    [DisplayName("Debit Date Time")]
    [IsoXmlTag("DbtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DebitDateTime { get; init; }

    /// <inheritdoc cref="ISettlementDateTimeIndication1.CreditDateTime"/>
    [IsoId("_QIhn4dp-Ed-ak6NoX_4Aeg_-356497199")]
    [DisplayName("Credit Date Time")]
    [IsoXmlTag("CdtDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CreditDateTime { get; init; }
}
