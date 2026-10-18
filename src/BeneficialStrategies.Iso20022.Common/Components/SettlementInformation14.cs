// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInformation14"/>
[IsoId("_QJIE0Np-Ed-ak6NoX_4Aeg_-1401894087")]
[DisplayName("Settlement Information")]
public partial record SettlementInformation14
{
    /// <inheritdoc cref="ISettlementInformation14.SettlementMethod"/>
    [IsoId("_QJIE0dp-Ed-ak6NoX_4Aeg_-1401894056")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod2Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInformation14.SettlementAccount"/>
    [IsoId("_QJIE0tp-Ed-ak6NoX_4Aeg_-1401893993")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount16? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInformation14.ClearingSystem"/>
    [IsoId("_QJIE09p-Ed-ak6NoX_4Aeg_-1401893685")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }
}
