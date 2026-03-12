// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the settlement condition modification request.
/// </summary>
[IsoId("_dfPzkeGFEeWCAvUNsZ5u6g")]
[DisplayName("Request Details")]
public partial record RequestDetails18
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_dqZ6ueGFEeWCAvUNsZ5u6g")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References18 Reference { get; init; } 
    
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_dqZ6weGFEeWCAvUNsZ5u6g")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing7Choice_? AutomaticBorrowing { get; init; } 
    
    /// <summary>
    /// Specifies whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("_dqZ6yeGFEeWCAvUNsZ5u6g")]
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetainIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_dqZ60eGFEeWCAvUNsZ5u6g")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType3Choice_? Linkage { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_dqZ62eGFEeWCAvUNsZ5u6g")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric4Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_dqZ64eGFEeWCAvUNsZ5u6g")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public GenericIdentification30? OtherProcessing { get; init; } 
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_dqZ66eGFEeWCAvUNsZ5u6g")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_dqZ68eGFEeWCAvUNsZ5u6g")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_dqZ6-eGFEeWCAvUNsZ5u6g")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator6? HoldIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("_dqZ7AeGFEeWCAvUNsZ5u6g")]
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied3Choice_? MatchingDenial { get; init; } 
    
    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("_dqZ7CeGFEeWCAvUNsZ5u6g")]
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit3Choice_? UnilateralSplit { get; init; } 
    
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_dqZ7EeGFEeWCAvUNsZ5u6g")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages51? Linkages { get; init; } 
    
    
    #nullable disable
    
}
