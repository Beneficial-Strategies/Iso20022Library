// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement information relative to corporate action reorganisation instructions.
/// </summary>
[IsoId("_uuvg0MVsEeeprYdSN88o0Q")]
[DisplayName("Corporate Action Acknowledgement SD")]
public partial record CorporateActionAcknowledgementSD1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the participant agrees to all terms of the event.
    /// Yes: the participant agrees.
    /// No: the participant does not agree.
    /// </summary>
    [IsoId("_ab-VwMVtEeeprYdSN88o0Q")]
    [DisplayName("Terms Acknowledgement Indicator")]
    [IsoXmlTag("TermsAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TermsAcknowledgementIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether condition 1 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_G6TQcMVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 1 Indicator")]
    [IsoXmlTag("Cond1Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Condition1Indicator { get; init; } 
    
    /// <summary>
    /// Indicates whether condition 2 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_PH6yIcVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 2 Indicator")]
    [IsoXmlTag("Cond2Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Condition2Indicator { get; init; } 
    
    /// <summary>
    /// Indicates whether condition 3 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_SIuQscVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 3 Indicator")]
    [IsoXmlTag("Cond3Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Condition3Indicator { get; init; } 
    
    /// <summary>
    /// Indicates whether condition 4 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_UbasEcVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 4 Indicator")]
    [IsoXmlTag("Cond4Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Condition4Indicator { get; init; } 
    
    /// <summary>
    /// Indicates whether condition 5 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_WQNDccVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 5 Indicator")]
    [IsoXmlTag("Cond5Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Condition5Indicator { get; init; } 
    
    /// <summary>
    /// Indicates whether condition 6 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_XQeNocVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 6 Indicator")]
    [IsoXmlTag("Cond6Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Condition6Indicator { get; init; } 
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that the beneficial owner has been deemed incompetent. Acknowledgement is related to CD early redemption instructions.
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_5Jm10MVvEeeprYdSN88o0Q")]
    [DisplayName("Adjudication Of Incompetency Acknowledgement Indicator")]
    [IsoXmlTag("AdjdctnOfIncmptncyAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AdjudicationOfIncompetencyAcknowledgementIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that this CD Early Redemption request is an exempt request, that the identification of the beneficial owner and required legal documentation is correct and that you agree to maintain such documentation for at least 30 months following payment of the request and will make it available to the CD Issuer upon request. 
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_jiDgUMX4EeexPc-mfUU5zQ")]
    [DisplayName("Legal Documentation Thirty Months Retention Acknowledgement Indicator")]
    [IsoXmlTag("LglDcmnttnThrtyMnthsRtntnAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that this CD Early Redemption instruction will automatically be deleted by the close of the fifth business day subsequent to submission if the appropriate legal documents, for example, death certificate, affidavit of domicile, are not received by DTC at that time. 
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_TBjtAMX5EeexPc-mfUU5zQ")]
    [DisplayName("Instruction Deletion Acknowledgement Indicator")]
    [IsoXmlTag("InstrDeltnAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InstructionDeletionAcknowledgementIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that the warrant or conversion instruction being sent could lead to a potential loss due to pricing factors.
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_uFPVwMX5EeexPc-mfUU5zQ")]
    [DisplayName("Potential Loss Acknowledgement Indicator")]
    [IsoXmlTag("PotntlLossAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PotentialLossAcknowledgementIndicator { get; init; } 
    
    
    #nullable disable
    
}
