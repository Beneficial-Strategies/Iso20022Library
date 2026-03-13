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
[IsoId("_JpuL0Q00EeqUVL7sB4m7NA")]
[DisplayName("Maintenance Delegation")]
public partial record MaintenanceDelegation9
{
    #nullable enable
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_J1SioQ00EeqUVL7sB4m7NA")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory11Code> MaintenanceService { get; init; } = [];
    // ID for the above is _J1SioQ00EeqUVL7sB4m7NA
    
    /// <summary>
    /// Response of the MTM to the delegation of the maintenance service.
    /// </summary>
    [IsoId("_J1Siow00EeqUVL7sB4m7NA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response2Code Response { get; init; } 
    
    /// <summary>
    /// Reason of the response of the MTM.
    /// </summary>
    [IsoId("_J1SipQ00EeqUVL7sB4m7NA")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; } 
    
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_J1Sipw00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Type")]
    [IsoXmlTag("DlgtnTp")]
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_J1SiqQ00EeqUVL7sB4m7NA")]
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POISubset { get; init; } 
    
    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_J1Siqw00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_J1SirQ00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    
    /// <summary>
    /// This element contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_J1Sirw00EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; } 
    
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_J1SisQ00EeqUVL7sB4m7NA")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType23? ProtectedDelegationProof { get; init; } 
    
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_J1Sisw00EeqUVL7sB4m7NA")]
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    
    
    #nullable disable
    
}
