// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the agent specific tracking system information of a payment transaction.
/// </summary>
[IsoId("_2db_MIW5EeiDBOVr6AJAFA")]
public interface ITrackerRecord1 : IIsoComponent
{
    /// <summary>
    /// Identification of an agent in the tracker.
    /// </summary>
    [IsoId("_9652UIW5EeiDBOVr6AJAFA")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    IBranchAndFinancialInstitutionIdentification6 Agent { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_FxOSUIW6EeiDBOVr6AJAFA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_ZQS6IYW6EeiDBOVr6AJAFA")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    ActiveCurrencyAndAmount? ChargesAmount { get; }

    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    [IsoId("_m7PxwYW7EeiDBOVr6AJAFA")]
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    ICurrencyExchange13? ExchangeRateData { get; }
}
