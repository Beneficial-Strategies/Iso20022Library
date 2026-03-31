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
[IsoId("_APfkAY4DEeWrZqsymMFdfg")]
[DisplayName("Maintenance Delegation")]
public record MaintenanceDelegation3
{
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    [IsoId("_JQ56II4DEeWrZqsymMFdfg")]
    [DisplayName("Delegation Type")]
    [IsoXmlTag("DlgtnTp")]
    public required TerminalManagementAction3Code DelegationType { get; init; }

    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_AahvUY4DEeWrZqsymMFdfg")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory11Code> MaintenanceService { get; init; } = [];

    // ID for the above is _AahvUY4DEeWrZqsymMFdfg

    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    [IsoId("_AahvU44DEeWrZqsymMFdfg")]
    [DisplayName("Partial Delegation")]
    [IsoXmlTag("PrtlDlgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialDelegation { get; init; }

    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_AahvVY4DEeWrZqsymMFdfg")]
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    public SimpleValueList<IsoMax35Text> POISubset { get; init; } = [];

    /// <summary>
    /// Information for the MTM to build or include delegated actions in the management plan of the POI.
    /// </summary>
    [IsoId("_AahvV44DEeWrZqsymMFdfg")]
    [DisplayName("Delegated Action")]
    [IsoXmlTag("DlgtdActn")]
    public MaintenanceDelegateAction2? DelegatedAction { get; init; }

    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_AahvWY4DEeWrZqsymMFdfg")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; }

    /// <summary>
    /// Definition of the delegation scope, for instance inside the payment application parameters the range of application profiles, the RID (registered application provider identification).
    /// </summary>
    [IsoId("_AahvW44DEeWrZqsymMFdfg")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; }

    /// <summary>
    /// Certificate path of the terminal manager.
    /// </summary>
    [IsoId("_AahvXY4DEeWrZqsymMFdfg")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax10KBinary> Certificate { get; init; } = [];

    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_AahvX44DEeWrZqsymMFdfg")]
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public ValueList<MaintenanceIdentificationAssociation1> POIIdentificationAssociation { get; init; } =
        [];

    /// <summary>
    /// Identification of the key to manage or to download.
    /// </summary>
    [IsoId("_AahvYY4DEeWrZqsymMFdfg")]
    [DisplayName("Symmetric Key")]
    [IsoXmlTag("SmmtrcKey")]
    public ValueList<KEKIdentifier5> SymmetricKey { get; init; } = [];

    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    [IsoId("_AahvY44DEeWrZqsymMFdfg")]
    [DisplayName("Parameter Data Set")]
    [IsoXmlTag("ParamDataSet")]
    public TerminalManagementDataSet19? ParameterDataSet { get; init; }
}
