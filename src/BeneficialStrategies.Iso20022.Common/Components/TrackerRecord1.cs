// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the agent specific tracking system information of a payment transaction.
/// </summary>
[IsoId("_2db_MIW5EeiDBOVr6AJAFA")]
[DisplayName("Tracker Record")]
public record TrackerRecord1
{
    /// <summary>
    /// Identification of an agent in the tracker.
    /// </summary>
    [IsoId("_9652UIW5EeiDBOVr6AJAFA")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification6 Agent { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_FxOSUIW6EeiDBOVr6AJAFA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_ZQS6IYW6EeiDBOVr6AJAFA")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    [IsoId("_m7PxwYW7EeiDBOVr6AJAFA")]
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    public CurrencyExchange13? ExchangeRateData { get; init; }
}
