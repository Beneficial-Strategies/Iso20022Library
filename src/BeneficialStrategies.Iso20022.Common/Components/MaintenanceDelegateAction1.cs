// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the MTM to build or include delegated actions in the management plan of the POI.
/// </summary>
[IsoId("_sdSxQGp9EeSojYXQbRlLzA")]
[DisplayName("Maintenance Delegate Action")]
public record MaintenanceDelegateAction1
{
    /// <summary>
    /// Flag to indicate that the delegated actions have to be included in a periodic sequence of actions.
    /// </summary>
    [IsoId("_1XV7IGp9EeSojYXQbRlLzA")]
    [DisplayName("Periodic Action")]
    [IsoXmlTag("PrdcActn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PeriodicAction { get; init; }

    /// <summary>
    /// Network address and parameters of the terminal manager host which will performs the delegated actions.
    /// </summary>
    [IsoId("_AXufYGp-EeSojYXQbRlLzA")]
    [DisplayName("TM Remote Access")]
    [IsoXmlTag("TMRmotAccs")]
    public NetworkParameters3? TMRemoteAccess { get; init; }

    /// <summary>
    /// TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_bAjisGp_EeSojYXQbRlLzA")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_EhUDkGqBEeSojYXQbRlLzA")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    /// <summary>
    /// Data set on which the delegated action has to be performed.
    /// </summary>
    [IsoId("_LYeIoGqBEeSojYXQbRlLzA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification4? DataSetIdentification { get; init; }

    /// <summary>
    /// Definition of retry process when activation of the action fails.
    /// </summary>
    [IsoId("_Q2sE0GqBEeSojYXQbRlLzA")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Additional information to include in the maintenance action.
    /// </summary>
    [IsoId("_ZlExQGqBEeSojYXQbRlLzA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? AdditionalInformation { get; init; }

    /// <summary>
    /// Sequence of action to include in the next MTM management plan.
    /// </summary>
    [IsoId("_keP6QGqBEeSojYXQbRlLzA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public TMSAction4? Action { get; init; }
}
