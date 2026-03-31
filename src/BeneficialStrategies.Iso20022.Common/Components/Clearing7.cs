// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing7.
/// </summary>
[IsoId("_eNi0RZIOEe-HRNGM304Vlw")]
[DisplayName("Clearing7")]
public record Clearing7
{
    /// <summary>
    /// Clearing Segment.
    /// </summary>
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification253Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Guaranteed Trade.
    /// </summary>
    [DisplayName("Guaranteed Trade")]
    [IsoXmlTag("GrntedTrad")]
    public IsoYesNoIndicator? GuaranteedTrade { get; init; }

    /// <summary>
    /// Non Guaranteed Trade.
    /// </summary>
    [DisplayName("Non Guaranteed Trade")]
    [IsoXmlTag("NonGrntedTrad")]
    public NonGuaranteedTrade4? NonGuaranteedTrade { get; init; }

    /// <summary>
    /// Settlement Netting Eligible Code.
    /// </summary>
    [DisplayName("Settlement Netting Eligible Code")]
    [IsoXmlTag("SttlmNetgElgblCd")]
    public required NettingEligible1Code SettlementNettingEligibleCode { get; init; }
}
