// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acknowledgement information relative to corporate action reorganisation instructions.
/// </summary>
[IsoId("_uuvg0MVsEeeprYdSN88o0Q")]
[DisplayName("Corporate Action Acknowledgement SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionAcknowledgementSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the participant agrees to all terms of the event.
    /// Yes: the participant agrees.
    /// No: the participant does not agree.
    /// </summary>
    [IsoId("_ab-VwMVtEeeprYdSN88o0Q")]
    [DisplayName("Terms Acknowledgement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermsAckInd")]
    #endif
    [IsoXmlTag("TermsAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TermsAcknowledgementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TermsAcknowledgementIndicator { get; init; } 
    #else
    public System.String? TermsAcknowledgementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether condition 1 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_G6TQcMVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 1 Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond1Ind")]
    #endif
    [IsoXmlTag("Cond1Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Condition1Indicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Condition1Indicator { get; init; } 
    #else
    public System.String? Condition1Indicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether condition 2 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_PH6yIcVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 2 Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond2Ind")]
    #endif
    [IsoXmlTag("Cond2Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Condition2Indicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Condition2Indicator { get; init; } 
    #else
    public System.String? Condition2Indicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether condition 3 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_SIuQscVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 3 Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond3Ind")]
    #endif
    [IsoXmlTag("Cond3Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Condition3Indicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Condition3Indicator { get; init; } 
    #else
    public System.String? Condition3Indicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether condition 4 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_UbasEcVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 4 Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond4Ind")]
    #endif
    [IsoXmlTag("Cond4Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Condition4Indicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Condition4Indicator { get; init; } 
    #else
    public System.String? Condition4Indicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether condition 5 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_WQNDccVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 5 Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond5Ind")]
    #endif
    [IsoXmlTag("Cond5Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Condition5Indicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Condition5Indicator { get; init; } 
    #else
    public System.String? Condition5Indicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether condition 6 of this tender offer is being accepted.
    /// Yes: accept.
    /// No: decline.
    /// </summary>
    [IsoId("_XQeNocVuEeeprYdSN88o0Q")]
    [DisplayName("Condition 6 Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cond6Ind")]
    #endif
    [IsoXmlTag("Cond6Ind")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Condition6Indicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Condition6Indicator { get; init; } 
    #else
    public System.String? Condition6Indicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that the beneficial owner has been deemed incompetent. Acknowledgement is related to CD early redemption instructions.
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_5Jm10MVvEeeprYdSN88o0Q")]
    [DisplayName("Adjudication Of Incompetency Acknowledgement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjdctnOfIncmptncyAckInd")]
    #endif
    [IsoXmlTag("AdjdctnOfIncmptncyAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AdjudicationOfIncompetencyAcknowledgementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdjudicationOfIncompetencyAcknowledgementIndicator { get; init; } 
    #else
    public System.String? AdjudicationOfIncompetencyAcknowledgementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that this CD Early Redemption request is an exempt request, that the identification of the beneficial owner and required legal documentation is correct and that you agree to maintain such documentation for at least 30 months following payment of the request and will make it available to the CD Issuer upon request. 
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_jiDgUMX4EeexPc-mfUU5zQ")]
    [DisplayName("Legal Documentation Thirty Months Retention Acknowledgement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglDcmnttnThrtyMnthsRtntnAckInd")]
    #endif
    [IsoXmlTag("LglDcmnttnThrtyMnthsRtntnAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicator { get; init; } 
    #else
    public System.String? LegalDocumentationThirtyMonthsRetentionAcknowledgementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that this CD Early Redemption instruction will automatically be deleted by the close of the fifth business day subsequent to submission if the appropriate legal documents, for example, death certificate, affidavit of domicile, are not received by DTC at that time. 
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_TBjtAMX5EeexPc-mfUU5zQ")]
    [DisplayName("Instruction Deletion Acknowledgement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrDeltnAckInd")]
    #endif
    [IsoXmlTag("InstrDeltnAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InstructionDeletionAcknowledgementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionDeletionAcknowledgementIndicator { get; init; } 
    #else
    public System.String? InstructionDeletionAcknowledgementIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is an acknowledgement that the warrant or conversion instruction being sent could lead to a potential loss due to pricing factors.
    /// Yes: acknowledged.
    /// No: not acknowledged.
    /// </summary>
    [IsoId("_uFPVwMX5EeexPc-mfUU5zQ")]
    [DisplayName("Potential Loss Acknowledgement Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PotntlLossAckInd")]
    #endif
    [IsoXmlTag("PotntlLossAckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PotentialLossAcknowledgementIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PotentialLossAcknowledgementIndicator { get; init; } 
    #else
    public System.String? PotentialLossAcknowledgementIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
