// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the clearing details.
/// </summary>
[IsoId("_j1HYEZBeEeakHoV5BVecAQ")]
[DisplayName("Clearing")]
public record Clearing5
{
    /// <summary>
    /// Provides details about the clearing member identification and account.
    /// </summary>
    [IsoId("_kEl-gZBeEeakHoV5BVecAQ")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public ValueList<PartyIdentificationAndAccount149> ClearingMember { get; init; } = [];

    // ID for the above is _kEl-gZBeEeakHoV5BVecAQ

    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_kEl-g5BeEeakHoV5BVecAQ")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification127Choice_? ClearingSegment { get; init; }
}
