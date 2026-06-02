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
[IsoId("a8f6c80c-8497-4934-8e3d-7e5edc56e263")]
[DisplayName("Hold Back Information5")]
public record HoldBackInformation5
{
    /// <summary>
    /// Type of gating or a hold back.
    /// </summary>
    [IsoId("d1ed0543-9b1d-4c13-93bd-867ae4f4e7dd")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GateHoldBack1Code Type { get; init; }

    /// <summary>
    /// Value of the redemption amount subject to gating or a hold back.
    /// </summary>
    [IsoId("8669476a-90ae-483e-8778-5b7527d843bb")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Date on which the gated amount or hold back amount is expected to be released.
    /// </summary>
    [IsoId("f73682b2-34e0-4e68-815d-2030bf272168")]
    [DisplayName("Expected Release Date")]
    [IsoXmlTag("XpctdRlsDt")]
    public IsoISODate? ExpectedReleaseDate { get; init; }

    /// <summary>
    /// New identification of the security.
    /// </summary>
    [IsoId("3f1bba4d-b562-4609-9be1-689cab5a214c")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification46Choice? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// New name of the security.
    /// </summary>
    [IsoId("8419f918-448d-4c79-a025-6f5d73e0eaba")]
    [DisplayName("Financial Instrument Name")]
    [IsoXmlTag("FinInstrmNm")]
    public IsoMax350Text? FinancialInstrumentName { get; init; }

    /// <summary>
    /// Specifies whether or not additional redemption order instructions are required in order for the redemption to be completed.
    /// </summary>
    [IsoId("fd0c8b5a-461d-4d30-a61d-769e8ef3627d")]
    [DisplayName("Redemption Completion")]
    [IsoXmlTag("RedCmpltn")]
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; }

    /// <summary>
    /// Indicates whether or not this is the final redemption confirmation in the execution of a gated redemption.
    /// </summary>
    [IsoId("5c0820b1-6310-4bea-8149-e5ce3d6ed941")]
    [DisplayName("Final Confirmation")]
    [IsoXmlTag("FnlConf")]
    public IsoYesNoIndicator? FinalConfirmation { get; init; }
}
