// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITrackerRecord1"/>
[IsoId("_2db_MIW5EeiDBOVr6AJAFA")]
[DisplayName("Tracker Record")]
public partial record TrackerRecord1
{
    /// <inheritdoc cref="ITrackerRecord1.Agent"/>
    [IsoId("_9652UIW5EeiDBOVr6AJAFA")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; }

    /// <inheritdoc cref="ITrackerRecord1.ChargeBearer"/>
    [IsoId("_FxOSUIW6EeiDBOVr6AJAFA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ITrackerRecord1.ChargesAmount"/>
    [IsoId("_ZQS6IYW6EeiDBOVr6AJAFA")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <inheritdoc cref="ITrackerRecord1.ExchangeRateData"/>
    [IsoId("_m7PxwYW7EeiDBOVr6AJAFA")]
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    public CurrencyExchange13? ExchangeRateData { get; init; }
}
