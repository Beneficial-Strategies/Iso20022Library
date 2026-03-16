// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance Delegation19.
/// </summary>
[IsoId("_ZmehEaE5Ee-MRKYsaX6JDg")]
[DisplayName("Maintenance Delegation19")]
public partial record MaintenanceDelegation19
{
    #nullable enable

    /// <summary>
    /// Certificate.
    /// </summary>
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public ValueList<IsoMax10KBinary> Certificate { get; init; } = [];

    /// <summary>
    /// Delegated Action.
    /// </summary>
    [DisplayName("Delegated Action")]
    [IsoXmlTag("DlgtdActn")]
    public MaintenanceDelegateAction10? DelegatedAction { get; init; } 

    /// <summary>
    /// Delegation Scope Definition.
    /// </summary>
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 

    /// <summary>
    /// Delegation Scope Identification.
    /// </summary>
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 

    /// <summary>
    /// Delegation Type.
    /// </summary>
    [DisplayName("Delegation Type")]
    [IsoXmlTag("DlgtnTp")]
    public required TerminalManagementAction3Code DelegationType { get; init; } 

    /// <summary>
    /// Maintenance Service.
    /// </summary>
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public ValueList<DataSetCategory19Code> MaintenanceService { get; init; } = [];

    /// <summary>
    /// Parameter Data Set.
    /// </summary>
    [DisplayName("Parameter Data Set")]
    [IsoXmlTag("ParamDataSet")]
    public AcceptorConfigurationDataSet6? ParameterDataSet { get; init; } 

    /// <summary>
    /// Partial Delegation.
    /// </summary>
    [DisplayName("Partial Delegation")]
    [IsoXmlTag("PrtlDlgtn")]
    public IsoTrueFalseIndicator? PartialDelegation { get; init; } 

    /// <summary>
    /// POI Identification Association.
    /// </summary>
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public ValueList<MaintenanceIdentificationAssociation1> POIIdentificationAssociation { get; init; } = [];

    /// <summary>
    /// POI Subset.
    /// </summary>
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    public ValueList<IsoMax35Text> POISubset { get; init; } = [];

    /// <summary>
    /// Symmetric Key.
    /// </summary>
    [DisplayName("Symmetric Key")]
    [IsoXmlTag("SmmtrcKey")]
    public ValueList<KEKIdentifier5> SymmetricKey { get; init; } = [];

    
    #nullable disable
    
}
