// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides supplementary indicator information for a corporate action.
/// </summary>
[IsoId("_xmB4cbliEfC9BsKnzSuyPg")]
[DisplayName("Corporate Action Supplementary Indicators2")]
public record CorporateActionSupplementaryIndicators2
{
    /// <summary>
    /// Indicates whether conditional payment is applicable.
    /// </summary>
    [IsoId("_xmB4dbliEfC9BsKnzSuyPg")]
    [DisplayName("Conditional Payment Applicable Indicator")]
    [IsoXmlTag("CondlPmtAplblInd")]
    public IsoYesNoIndicator? ConditionalPaymentApplicableIndicator { get; init; }

    /// <summary>
    /// Indicates whether a solicitation dealer fee applies.
    /// </summary>
    [IsoId("_xmB4ebliEfC9BsKnzSuyPg")]
    [DisplayName("Solicitation Dealer Fee Indicator")]
    [IsoXmlTag("SlctnDealrFeeInd")]
    public IsoYesNoIndicator? SolicitationDealerFeeIndicator { get; init; }

    /// <summary>
    /// Indicates whether shares must be surrendered to the agent.
    /// </summary>
    [IsoId("_xmB4fbliEfC9BsKnzSuyPg")]
    [DisplayName("Surrender Shares To Agent Indicator")]
    [IsoXmlTag("SrrndrShrsToAgtInd")]
    public IsoYesNoIndicator? SurrenderSharesToAgentIndicator { get; init; }

    /// <summary>
    /// Indicates whether step-up privilege applies.
    /// </summary>
    [IsoId("_xmB4gbliEfC9BsKnzSuyPg")]
    [DisplayName("Step Up Privilege Indicator")]
    [IsoXmlTag("StepUpPrvlgInd")]
    public IsoYesNoIndicator? StepUpPrivilegeIndicator { get; init; }

    /// <summary>
    /// Indicates whether rights oversubscription applies.
    /// </summary>
    [IsoId("_xmB4hbliEfC9BsKnzSuyPg")]
    [DisplayName("Rights Oversubscription Indicator")]
    [IsoXmlTag("RghtsOvrsbcptInd")]
    public IsoYesNoIndicator? RightsOversubscriptionIndicator { get; init; }

    /// <summary>
    /// Indicates whether rights round-up privilege applies.
    /// </summary>
    [IsoId("_xmB4ibliEfC9BsKnzSuyPg")]
    [DisplayName("Rights Round Up Privilege Indicator")]
    [IsoXmlTag("RghtsRndUpPrvlgInd")]
    public IsoYesNoIndicator? RightsRoundUpPrivilegeIndicator { get; init; }

    /// <summary>
    /// Indicates whether rights are transferable.
    /// </summary>
    [IsoId("_xmB4jbliEfC9BsKnzSuyPg")]
    [DisplayName("Rights Transferable Indicator")]
    [IsoXmlTag("RghtsTrfblInd")]
    public IsoYesNoIndicator? RightsTransferableIndicator { get; init; }

    /// <summary>
    /// Indicates whether escrow-to-maturity applies.
    /// </summary>
    [IsoId("_xmB4kbliEfC9BsKnzSuyPg")]
    [DisplayName("Escrow To Maturity Indicator")]
    [IsoXmlTag("EscrwToMtrtyInd")]
    public IsoYesNoIndicator? EscrowToMaturityIndicator { get; init; }

    /// <summary>
    /// Indicates whether a concurrent call applies.
    /// </summary>
    [IsoId("_xmB4lbliEfC9BsKnzSuyPg")]
    [DisplayName("Concurrent Call Indicator")]
    [IsoXmlTag("CncrrntCallInd")]
    public IsoYesNoIndicator? ConcurrentCallIndicator { get; init; }
}
