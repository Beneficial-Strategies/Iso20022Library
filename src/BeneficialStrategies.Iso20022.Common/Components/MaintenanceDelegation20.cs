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
[IsoId("_s31yQbYFEfCUZfsQO4rYeA")]
[DisplayName("Maintenance Delegation20")]
public record MaintenanceDelegation20
{
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_s4131bYFEfCUZfsQO4rYeA")]
    [DisplayName("Delegation Type")]
    [IsoXmlTag("DlgtnTp")]
    public required TerminalManagementAction3Code DelegationType { get; init; }

    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_s41327YFEfCUZfsQO4rYeA")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    [MinLength(1)]
    public SimpleValueList<DataSetCategory19Code> MaintenanceService { get; init; } = [];

    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    [IsoId("_s4134bYFEfCUZfsQO4rYeA")]
    [DisplayName("Partial Delegation")]
    [IsoXmlTag("PrtlDlgtn")]
    public IsoTrueFalseIndicator? PartialDelegation { get; init; }

    /// <summary>
    /// Subset of the terminal estate for the delegated actions.
    /// </summary>
    [IsoId("_s41357YFEfCUZfsQO4rYeA")]
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    public SimpleValueList<IsoMax35Text> POISubset { get; init; } = [];

    /// <summary>
    /// Information for the MTM to build or include delegated actions in the management plan of the POI.
    /// </summary>
    [IsoId("_s4137bYFEfCUZfsQO4rYeA")]
    [DisplayName("Delegated Action")]
    [IsoXmlTag("DlgtdActn")]
    public MaintenanceDelegateAction11? DelegatedAction { get; init; }

    /// <summary>
    /// Identifies the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_s41387YFEfCUZfsQO4rYeA")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    public IsoMax35Text? DelegationScopeIdentification { get; init; }

    /// <summary>
    /// Contains all information relevant to the DelegationScopeIdentification.
    /// </summary>
    [IsoId("_s413-bYFEfCUZfsQO4rYeA")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; }

    /// <summary>
    /// Certificate path of the terminal manager.
    /// </summary>
    [IsoId("_s413_7YFEfCUZfsQO4rYeA")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax10KBinary> Certificate { get; init; } = [];

    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_s414BbYFEfCUZfsQO4rYeA")]
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public ValueList<MaintenanceIdentificationAssociation1> POIIdentificationAssociation { get; init; } = [];

    /// <summary>
    /// Identification of the key to manage or to download.
    /// </summary>
    [IsoId("_s414C7YFEfCUZfsQO4rYeA")]
    [DisplayName("Symmetric Key")]
    [IsoXmlTag("SmmtrcKey")]
    public ValueList<CryptographicKey19> SymmetricKey { get; init; } = [];

    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    [IsoId("_s414EbYFEfCUZfsQO4rYeA")]
    [DisplayName("Parameter Data Set")]
    [IsoXmlTag("ParamDataSet")]
    public AcceptorConfigurationDataSet7? ParameterDataSet { get; init; }
}
