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
[IsoId("_rCrVYXIoEe299ZbWCkdR_w")]
[DisplayName("Maintenance Delegation")]
public partial record MaintenanceDelegation15
{
    #nullable enable
    
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_rJ9CEXIoEe299ZbWCkdR_w")]
    [DisplayName("Delegation Type")]
    [IsoXmlTag("DlgtnTp")]
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_rJ9CE3IoEe299ZbWCkdR_w")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory16Code> MaintenanceService { get; init; } = [];
    // ID for the above is _rJ9CE3IoEe299ZbWCkdR_w
    
    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    [IsoId("_rJ9CFXIoEe299ZbWCkdR_w")]
    [DisplayName("Partial Delegation")]
    [IsoXmlTag("PrtlDlgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialDelegation { get; init; } 
    
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_rJ9CF3IoEe299ZbWCkdR_w")]
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POISubset { get; init; } 
    
    /// <summary>
    /// Information for the MTM to build or include delegated actions in the management plan of the POI.
    /// </summary>
    [IsoId("_rJ9CGXIoEe299ZbWCkdR_w")]
    [DisplayName("Delegated Action")]
    [IsoXmlTag("DlgtdActn")]
    public MaintenanceDelegateAction8? DelegatedAction { get; init; } 
    
    /// <summary>
    /// Identifies the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_rJ9CG3IoEe299ZbWCkdR_w")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_rJ9CHXIoEe299ZbWCkdR_w")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    
    /// <summary>
    /// Certificate path of the terminal manager.
    /// </summary>
    [IsoId("_rJ9CH3IoEe299ZbWCkdR_w")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? Certificate { get; init; } 
    
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_rJ9CIXIoEe299ZbWCkdR_w")]
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    
    /// <summary>
    /// Identification of the key to manage or to download.
    /// </summary>
    [IsoId("_rJ9CI3IoEe299ZbWCkdR_w")]
    [DisplayName("Symmetric Key")]
    [IsoXmlTag("SmmtrcKey")]
    public KEKIdentifier5? SymmetricKey { get; init; } 
    
    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    [IsoId("_rJ9CJXIoEe299ZbWCkdR_w")]
    [DisplayName("Parameter Data Set")]
    [IsoXmlTag("ParamDataSet")]
    public AcceptorConfigurationDataSet4? ParameterDataSet { get; init; } 
    
    
    #nullable disable
    
}
