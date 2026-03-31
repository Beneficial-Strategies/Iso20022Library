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
[IsoId("_A3gsQNokEeC60axPepSq7g_556617430")]
[DisplayName("Clearing")]
public record Clearing3
{
    /// <summary>
    /// Provides details about the clearing member identification and account.
    /// </summary>
    [IsoId("_A3qdQNokEeC60axPepSq7g_428053950")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public ValueList<PartyIdentificationAndAccount78> ClearingMember { get; init; } = [];

    // ID for the above is _A3qdQNokEeC60axPepSq7g_428053950

    /// <summary>
    /// Clearing organisation that will clear the trade.
    /// Note: This field allows Clearing Member Firm to segregate flows coming from clearing counterparty&apos;s clearing system. Indeed, Clearing Member Firms receive messages from the same system (same sender) and this field allows them to know if the message is related to equities or derivatives.
    /// </summary>
    [IsoId("_A3qdQdokEeC60axPepSq7g_1991091600")]
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification35Choice_? ClearingSegment { get; init; }
}
