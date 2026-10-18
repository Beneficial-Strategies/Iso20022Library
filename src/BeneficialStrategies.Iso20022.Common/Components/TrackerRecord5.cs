// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITrackerRecord5"/>
[IsoId("_1bDllzEyEe6g-ffJsqGiSA")]
[Description(@"Specifies the agent specific tracking system information of a payment transaction.")]
[DisplayName("Tracker Record5")]
public partial record TrackerRecord5
{
    /// <inheritdoc cref="ITrackerRecord5.Agent"/>
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification8 Agent { get; init; }

    /// <inheritdoc cref="ITrackerRecord5.ChargeBearer"/>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ITrackerRecord5.ChargesAmount"/>
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <inheritdoc cref="ITrackerRecord5.ExchangeRateData"/>
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    public CurrencyExchange13? ExchangeRateData { get; init; }
}
