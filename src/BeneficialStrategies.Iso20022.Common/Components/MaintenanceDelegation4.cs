// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the delegation of a maintenance action or maintenance function.
/// </summary>
[IsoId("_Xx790Y4HEeWrZqsymMFdfg")]
[DisplayName("Maintenance Delegation")]
public partial record MaintenanceDelegation4
{
    #nullable enable
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_X8XsMY4HEeWrZqsymMFdfg")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory6Code> MaintenanceService { get; init; } = [];
    // ID for the above is _X8XsMY4HEeWrZqsymMFdfg
    
    /// <summary>
    /// Response of the MTM to the delegation of the maintenance service.
    /// </summary>
    [IsoId("_X8XsM44HEeWrZqsymMFdfg")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response2Code Response { get; init; } 
    
    /// <summary>
    /// Reason of the response of the MTM.
    /// </summary>
    [IsoId("_X8XsNY4HEeWrZqsymMFdfg")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; } 
    
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_hJKL4I4HEeWrZqsymMFdfg")]
    [DisplayName("Delegation Type")]
    [IsoXmlTag("DlgtnTp")]
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_X8XsN44HEeWrZqsymMFdfg")]
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POISubset { get; init; } 
    
    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_X8XsOY4HEeWrZqsymMFdfg")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    
    /// <summary>
    /// Definition of the delegation scope, for instance inside the payment application parameters the range of application profiles, the RID (registered application provider identification).
    /// </summary>
    [IsoId("_X8XsO44HEeWrZqsymMFdfg")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    
    /// <summary>
    /// Proof of delegation to be verified by the POI, when performing the delegated actions.
    /// </summary>
    [IsoId("_X8XsPY4HEeWrZqsymMFdfg")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; } 
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_X8XsP44HEeWrZqsymMFdfg")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType12? ProtectedDelegationProof { get; init; } 
    
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_X8XsQY4HEeWrZqsymMFdfg")]
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    
    
    #nullable disable
    
}
