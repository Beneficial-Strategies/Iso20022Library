// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the delegation of a maintenance action or maintenance function.
/// </summary>
[IsoId("_2EYgQdp2EeearpaEPXv9UA")]
[DisplayName("Maintenance Delegation")]
public record MaintenanceDelegation6
{
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_2ND7Idp2EeearpaEPXv9UA")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory11Code> MaintenanceService { get; init; } = [];

    // ID for the above is _2ND7Idp2EeearpaEPXv9UA

    /// <summary>
    /// Response of the MTM to the delegation of the maintenance service.
    /// </summary>
    [IsoId("_2ND7I9p2EeearpaEPXv9UA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response2Code Response { get; init; }

    /// <summary>
    /// Reason of the response of the MTM.
    /// </summary>
    [IsoId("_2ND7Jdp2EeearpaEPXv9UA")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; }

    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_2ND7J9p2EeearpaEPXv9UA")]
    [DisplayName("Delegation Type")]
    [IsoXmlTag("DlgtnTp")]
    public required TerminalManagementAction3Code DelegationType { get; init; }

    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_2ND7Kdp2EeearpaEPXv9UA")]
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POISubset { get; init; }

    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_2ND7K9p2EeearpaEPXv9UA")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; }

    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_2ND7Ldp2EeearpaEPXv9UA")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; }

    /// <summary>
    /// This element contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_2ND7L9p2EeearpaEPXv9UA")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_2ND7Mdp2EeearpaEPXv9UA")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType19? ProtectedDelegationProof { get; init; }

    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_2ND7M9p2EeearpaEPXv9UA")]
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; }
}
