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
[IsoId("_i4Ff4TwvEeaFzejt0Yw_3A")]
[DisplayName("Hold Back Information")]
public record HoldBackInformation2
{
    /// <summary>
    /// Type of gating or a hold back.
    /// </summary>
    [IsoId("_wtS8MDwvEeaFzejt0Yw_3A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GateHoldBack1Code Type { get; init; }

    /// <summary>
    /// Value of the redemption amount subject to gating or a hold back.
    /// </summary>
    [IsoId("_jQ7dsTwvEeaFzejt0Yw_3A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Date on which the gated amount or hold back amount is expected to be released.
    /// </summary>
    [IsoId("_jQ7dszwvEeaFzejt0Yw_3A")]
    [DisplayName("Expected Release Date")]
    [IsoXmlTag("XpctdRlsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpectedReleaseDate { get; init; }

    /// <summary>
    /// New identification of the security.
    /// </summary>
    [IsoId("_cbKDQTwwEeaFzejt0Yw_3A")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification25Choice_? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// New name of the security.
    /// </summary>
    [IsoId("_nRyOlDwwEeaFzejt0Yw_3A")]
    [DisplayName("Financial Instrument Name")]
    [IsoXmlTag("FinInstrmNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FinancialInstrumentName { get; init; }

    /// <summary>
    /// Specifies whether or not additional redemption order instructions are required in order for the redemption to be completed.
    /// </summary>
    [IsoId("_vdxYkDwwEeaFzejt0Yw_3A")]
    [DisplayName("Redemption Completion")]
    [IsoXmlTag("RedCmpltn")]
    public RedemptionCompletion1Code? RedemptionCompletion { get; init; }

    /// <summary>
    /// Indicates whether or not this is the final redemption confirmation in the execution of a gated redemption.
    /// </summary>
    [IsoId("_PE9owDwxEeaFzejt0Yw_3A")]
    [DisplayName("Final Confirmation")]
    [IsoXmlTag("FnlConf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? FinalConfirmation { get; init; }
}
