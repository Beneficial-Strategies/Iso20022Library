// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maintenance Delegation17.
/// </summary>
[IsoId("_62UBcZB2Ee6FLLjWp95ntQ")]
[DisplayName("Maintenance Delegation17")]
public partial record MaintenanceDelegation17
{
    #nullable enable

    /// <summary>
    /// Delegation Proof.
    /// </summary>
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    public IsoMax5000Binary? DelegationProof { get; init; } 

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
    /// Protected Delegation Proof.
    /// </summary>
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType39? ProtectedDelegationProof { get; init; } 

    /// <summary>
    /// Response.
    /// </summary>
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response2Code Response { get; init; } 

    /// <summary>
    /// Response Reason.
    /// </summary>
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public IsoMax35Text? ResponseReason { get; init; } 

    
    #nullable disable
    
}
