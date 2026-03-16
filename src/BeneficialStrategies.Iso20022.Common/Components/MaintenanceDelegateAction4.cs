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
[IsoId("_0Ri5kdqKEeearpaEPXv9UA")]
[DisplayName("Maintenance Delegate Action")]
public record MaintenanceDelegateAction4
{
    /// <summary>
    /// Flag to indicate that the delegated actions have to be included in a periodic sequence of actions.
    /// </summary>
    [IsoId("_0adlAdqKEeearpaEPXv9UA")]
    [DisplayName("Periodic Action")]
    [IsoXmlTag("PrdcActn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PeriodicAction { get; init; }

    /// <summary>
    /// Network address and parameters of the terminal manager host which will performs the delegated actions.
    /// </summary>
    [IsoId("_0adlA9qKEeearpaEPXv9UA")]
    [DisplayName("TM Remote Access")]
    [IsoXmlTag("TMRmotAccs")]
    public NetworkParameters5? TMRemoteAccess { get; init; }

    /// <summary>
    /// TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_0adlBdqKEeearpaEPXv9UA")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_0adlB9qKEeearpaEPXv9UA")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    /// <summary>
    /// Data set on which the delegated action has to be performed.
    /// </summary>
    [IsoId("_0adlCdqKEeearpaEPXv9UA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification7? DataSetIdentification { get; init; }

    /// <summary>
    /// Definition of retry process when activation of the action fails.
    /// </summary>
    [IsoId("_0adlC9qKEeearpaEPXv9UA")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Additional information to include in the maintenance action.
    /// </summary>
    [IsoId("_0adlDdqKEeearpaEPXv9UA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? AdditionalInformation { get; init; }

    /// <summary>
    /// Sequence of action to include in the next MTM management plan.
    /// </summary>
    [IsoId("_0adlD9qKEeearpaEPXv9UA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public TMSAction7? Action { get; init; }
}
