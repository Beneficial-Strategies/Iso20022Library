// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about hold back and gating.
/// </summary>
[IsoId("300b027f-8d8f-4e9b-890c-df0f8075e604")]
[DisplayName("Hold Back Information4")]
public record HoldBackInformation4
{
    /// <summary>
    /// Type of gating or a hold back.
    /// </summary>
    [IsoId("2cc22d42-abb8-4443-86ba-91d77ea3819d")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GateHoldBack1Code Type { get; init; }

    /// <summary>
    /// Value of the redemption amount subject to gating or a hold back.
    /// </summary>
    [IsoId("821e93a5-73e3-49ae-861b-cae7a57106ad")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Date on which the gated amount or hold back amount is expected to be released.
    /// </summary>
    [IsoId("bc11e968-6de7-49f1-9a1c-3bf1b43c85dc")]
    [DisplayName("Expected Release Date")]
    [IsoXmlTag("XpctdRlsDt")]
    public IsoISODate? ExpectedReleaseDate { get; init; }

    /// <summary>
    /// New identification of the security.
    /// </summary>
    [IsoId("0558bb8d-80fc-4a96-a7af-061af2070255")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification46Choice? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// New name of the security.
    /// </summary>
    [IsoId("19120879-4a44-4dc8-8bfb-06fc81f8c64d")]
    [DisplayName("Financial Instrument Name")]
    [IsoXmlTag("FinInstrmNm")]
    public IsoMax350Text? FinancialInstrumentName { get; init; }

    /// <summary>
    /// Specifies whether or not additional redemption order instructions are required in order for the redemption to be completed.
    /// </summary>
    [IsoId("c827bf34-8c8d-4676-9f10-84d9fc3dba21")]
    [DisplayName("Redemption Completion")]
    [IsoXmlTag("RedCmpltn")]
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; }
}
