// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details on the returns expected by the debtor side after cancellation or modification.
/// </summary>
[IsoId("_QIhn4tp-Ed-ak6NoX_4Aeg_554532550")]
[DisplayName("Return Information")]
public record ReturnInformation1
{
    /// <summary>
    /// Returned amount of money moved between the instructing agent and the instructed agent in the return transaction.
    /// </summary>
    [IsoId("_QIhn49p-Ed-ak6NoX_4Aeg_717071953")]
    [DisplayName("Returned Interbank Settlement Amount")]
    [IsoXmlTag("RtrdIntrBkSttlmAmt")]
    public CurrencyAndAmount? ReturnedInterbankSettlementAmount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_QIhn5Np-Ed-ak6NoX_4Aeg_1045842969")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Specifies the clearing channel to be used to process the payment instruction.
    /// </summary>
    [IsoId("_QIhn5dp-Ed-ak6NoX_4Aeg_-2104210068")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }
}
