// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the intra-balance movement status type.
/// </summary>
[IsoId("_S62MFeFWEeWIA4E9cYSxxQ")]
[DisplayName("Intra Balance Status Type")]
public record IntraBalanceStatusType2
{
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_TDntkeFWEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ValueList<ProcessingStatus68Choice_> ProcessingStatus { get; init; } = [];

    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_TDntk-FWEeWIA4E9cYSxxQ")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public ValueList<SettlementStatus26Choice_> SettlementStatus { get; init; } = [];

    /// <summary>
    /// Specifies the state or the condition.
    /// </summary>
    [IsoId("_TDntleFWEeWIA4E9cYSxxQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }
}
