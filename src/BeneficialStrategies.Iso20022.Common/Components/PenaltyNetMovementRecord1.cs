// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes when the penalty applies to a net settlement movement.
/// </summary>
[IsoId("_Mq3zFQAXEeqIo7-k3pky8Q")]
[DisplayName("Penalty Net Movement Record1")]
public record PenaltyNetMovementRecord1
{
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_diecZACmEeqhTpEB02BA8A")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Total quantity of securities which failed to settle.
    /// </summary>
    [IsoId("_OHxcpQAcEeqxkL65N306OA")]
    [DisplayName("Securities Shortfall")]
    [IsoXmlTag("SctiesShrtfll")]
    public FinancialInstrumentQuantity1Choice? SecuritiesShortfall { get; init; }

    /// <summary>
    /// Valuation of securities which failed to settle.
    /// </summary>
    [IsoId("_OHxcpgAcEeqxkL65N306OA")]
    [DisplayName("Shortfall Valuation")]
    [IsoXmlTag("ShrtfllValtn")]
    public AmountAndDirection5? ShortfallValuation { get; init; }

    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_OHxcpAAcEeqxkL65N306OA")]
    [DisplayName("Trade Transaction Condition")]
    [IsoXmlTag("TradTxCond")]
    public ValueList<TradeTransactionCondition5Choice> TradeTransactionCondition { get; init; } = [];

    /// <summary>
    /// Number of entries related to the net position.
    /// </summary>
    [IsoId("_OHxcpwAcEeqxkL65N306OA")]
    [DisplayName("Number Of Entries")]
    [IsoXmlTag("NbOfNtries")]
    public IsoNumber? NumberOfEntries { get; init; }
}
