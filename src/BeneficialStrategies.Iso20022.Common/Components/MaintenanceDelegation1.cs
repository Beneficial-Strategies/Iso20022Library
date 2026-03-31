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
[IsoId("_Kw_ykGp5EeSojYXQbRlLzA")]
[DisplayName("Maintenance Delegation")]
public record MaintenanceDelegation1
{
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    [IsoId("_lFEjUGp5EeSojYXQbRlLzA")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory6Code> MaintenanceService { get; init; } = [];

    // ID for the above is _lFEjUGp5EeSojYXQbRlLzA

    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    [IsoId("_NHM4IGp9EeSojYXQbRlLzA")]
    [DisplayName("Partial Delegation")]
    [IsoXmlTag("PrtlDlgtn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialDelegation { get; init; }

    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    [IsoId("_XrpHQGp9EeSojYXQbRlLzA")]
    [DisplayName("POI Subset")]
    [IsoXmlTag("POISubset")]
    public SimpleValueList<IsoMax35Text> POISubset { get; init; } = [];

    /// <summary>
    /// Information for the MTM to build or include delegated actions in the management plan of the POI.
    /// </summary>
    [IsoId("_gycTsGp9EeSojYXQbRlLzA")]
    [DisplayName("Delegated Action")]
    [IsoXmlTag("DlgtdActn")]
    public MaintenanceDelegateAction1? DelegatedAction { get; init; }

    /// <summary>
    /// Identification of the parameters subset assigned by the MTM.
    /// </summary>
    [IsoId("_FI1hIGqCEeSojYXQbRlLzA")]
    [DisplayName("Parameters Subset Identification")]
    [IsoXmlTag("ParamsSubsetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ParametersSubsetIdentification { get; init; }

    /// <summary>
    /// Definition of the subset of application parameters, for instance the range of application profiles, the RID (registered application provider identification).
    /// </summary>
    [IsoId("_MoXNwGqCEeSojYXQbRlLzA")]
    [DisplayName("Parameters Subset Definition")]
    [IsoXmlTag("ParamsSubsetDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? ParametersSubsetDefinition { get; init; }

    /// <summary>
    /// Certificate path of the terminal manager.
    /// </summary>
    [IsoId("_XiCtEGqCEeSojYXQbRlLzA")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax5000Binary> Certificate { get; init; } = [];

    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    [IsoId("_dIVnMGqCEeSojYXQbRlLzA")]
    [DisplayName("POI Identification Association")]
    [IsoXmlTag("POIIdAssoctn")]
    public ValueList<MaintenanceIdentificationAssociation1> POIIdentificationAssociation { get; init; } =
        [];

    /// <summary>
    /// Identification of the key to manage or to download.
    /// </summary>
    [IsoId("_KQjzcGqDEeSojYXQbRlLzA")]
    [DisplayName("Symmetric Key")]
    [IsoXmlTag("SmmtrcKey")]
    public ValueList<KEKIdentifier2> SymmetricKey { get; init; } = [];

    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    [IsoId("_T8tIoGqDEeSojYXQbRlLzA")]
    [DisplayName("Parameter Data Set")]
    [IsoXmlTag("ParamDataSet")]
    public TerminalManagementDataSet14? ParameterDataSet { get; init; }
}
