// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Supplementary Indicators1.
/// </summary>
[IsoId("_w5PS8EnDEe-NocYul3BKXQ")]
[DisplayName("Corporate Action Supplementary Indicators1")]
public record CorporateActionSupplementaryIndicators1
{
    /// <summary>
    /// Conditional Payment Applicable Indicator.
    /// </summary>
    [DisplayName("Conditional Payment Applicable Indicator")]
    [IsoXmlTag("CondlPmtAplblInd")]
    public IsoYesNoIndicator? ConditionalPaymentApplicableIndicator { get; init; }

    /// <summary>
    /// Escrow To Maturity Indicator.
    /// </summary>
    [DisplayName("Escrow To Maturity Indicator")]
    [IsoXmlTag("EscrwToMtrtyInd")]
    public IsoYesNoIndicator? EscrowToMaturityIndicator { get; init; }

    /// <summary>
    /// Rights Oversubscription Indicator.
    /// </summary>
    [DisplayName("Rights Oversubscription Indicator")]
    [IsoXmlTag("RghtsOvrsbcptInd")]
    public IsoYesNoIndicator? RightsOversubscriptionIndicator { get; init; }

    /// <summary>
    /// Rights Round Up Privilege Indicator.
    /// </summary>
    [DisplayName("Rights Round Up Privilege Indicator")]
    [IsoXmlTag("RghtsRndUpPrvlgInd")]
    public IsoYesNoIndicator? RightsRoundUpPrivilegeIndicator { get; init; }

    /// <summary>
    /// Rights Transferable Indicator.
    /// </summary>
    [DisplayName("Rights Transferable Indicator")]
    [IsoXmlTag("RghtsTrfblInd")]
    public IsoYesNoIndicator? RightsTransferableIndicator { get; init; }

    /// <summary>
    /// Solicitation Dealer Fee Indicator.
    /// </summary>
    [DisplayName("Solicitation Dealer Fee Indicator")]
    [IsoXmlTag("SlctnDealrFeeInd")]
    public IsoYesNoIndicator? SolicitationDealerFeeIndicator { get; init; }

    /// <summary>
    /// Step Up Privilege Indicator.
    /// </summary>
    [DisplayName("Step Up Privilege Indicator")]
    [IsoXmlTag("StepUpPrvlgInd")]
    public IsoYesNoIndicator? StepUpPrivilegeIndicator { get; init; }

    /// <summary>
    /// Surrender Shares To Agent Indicator.
    /// </summary>
    [DisplayName("Surrender Shares To Agent Indicator")]
    [IsoXmlTag("SrrndrShrsToAgtInd")]
    public IsoYesNoIndicator? SurrenderSharesToAgentIndicator { get; init; }
}
