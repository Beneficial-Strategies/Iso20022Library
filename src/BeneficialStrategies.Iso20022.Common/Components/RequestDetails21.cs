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
[IsoId("_D9PU7ffXEeiNZp_PtLohLw")]
[DisplayName("Request Details")]
public partial record RequestDetails21
{
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_D9PU9ffXEeiNZp_PtLohLw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required References24 Reference { get; init; } 
    
    /// <summary>
    /// Restriction references applied on the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_D9PU-ffXEeiNZp_PtLohLw")]
    [DisplayName("Restriction Reference")]
    [IsoXmlTag("RstrctnRef")]
    public RestrictionIdentification2? RestrictionReference { get; init; } 
    
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [IsoId("_D9PU-_fXEeiNZp_PtLohLw")]
    [DisplayName("Automatic Borrowing")]
    [IsoXmlTag("AutomtcBrrwg")]
    public AutomaticBorrowing11Choice_? AutomaticBorrowing { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction due to expire is confirmed for settlement.
    /// </summary>
    [IsoId("_D9PU__fXEeiNZp_PtLohLw")]
    [DisplayName("Retain Indicator")]
    [IsoXmlTag("RtnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetainIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the type of linkage requested.
    /// </summary>
    [IsoId("_D9PVA_fXEeiNZp_PtLohLw")]
    [DisplayName("Linkage")]
    [IsoXmlTag("Lkg")]
    public LinkageType4Choice_? Linkage { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [IsoId("_D9PVB_fXEeiNZp_PtLohLw")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public PriorityNumeric5Choice_? Priority { get; init; } 
    
    /// <summary>
    /// Specifies another type of processing change request.
    /// </summary>
    [IsoId("_D9PVC_fXEeiNZp_PtLohLw")]
    [DisplayName("Other Processing")]
    [IsoXmlTag("OthrPrcg")]
    public GenericIdentification47? OtherProcessing { get; init; } 
    
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [IsoId("_D9PVD_fXEeiNZp_PtLohLw")]
    [DisplayName("Partial Settlement Indicator")]
    [IsoXmlTag("PrtlSttlmInd")]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_D9PVE_fXEeiNZp_PtLohLw")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [IsoId("_D9PVF_fXEeiNZp_PtLohLw")]
    [DisplayName("Hold Indicator")]
    [IsoXmlTag("HldInd")]
    public HoldIndicator7? HoldIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the matching processing change requested.
    /// </summary>
    [IsoId("_D9PVG_fXEeiNZp_PtLohLw")]
    [DisplayName("Matching Denial")]
    [IsoXmlTag("MtchgDnl")]
    public MatchingDenied4Choice_? MatchingDenial { get; init; } 
    
    /// <summary>
    /// Specifies that the transaction is requested to be unilaterally split.
    /// </summary>
    [IsoId("_D9PVH_fXEeiNZp_PtLohLw")]
    [DisplayName("Unilateral Split")]
    [IsoXmlTag("UnltrlSplt")]
    public UnilateralSplit4Choice_? UnilateralSplit { get; init; } 
    
    /// <summary>
    /// Information regarding the linkage requested.
    /// </summary>
    [IsoId("_D9PVI_fXEeiNZp_PtLohLw")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public Linkages56? Linkages { get; init; } 
    
    
    #nullable disable
    
}
