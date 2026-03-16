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
[IsoId("_tF4y4U6nEeyGi9JAv6wq7Q")]
[DisplayName("Maintenance Delegate Action")]
public record MaintenanceDelegateAction7
{
    /// <summary>
    /// Flag to indicate that the delegated actions have to be included in a periodic sequence of actions.
    /// </summary>
    [IsoId("_tMkpsU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Periodic Action")]
    [IsoXmlTag("PrdcActn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PeriodicAction { get; init; }

    /// <summary>
    /// Network address and parameters of the terminal manager host which will performs the delegated actions.
    /// </summary>
    [IsoId("_tMkps06nEeyGi9JAv6wq7Q")]
    [DisplayName("TM Remote Access")]
    [IsoXmlTag("TMRmotAccs")]
    public NetworkParameters7? TMRemoteAccess { get; init; }

    /// <summary>
    /// TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_tMkptU6nEeyGi9JAv6wq7Q")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_tMkpt06nEeyGi9JAv6wq7Q")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    /// <summary>
    /// Data set on which the delegated action has to be performed.
    /// </summary>
    [IsoId("_tMkpuU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification9? DataSetIdentification { get; init; }

    /// <summary>
    /// Definition of retry process when activation of the action fails.
    /// </summary>
    [IsoId("_tMkpu06nEeyGi9JAv6wq7Q")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry3? ReTry { get; init; }

    /// <summary>
    /// Additional information to include in the maintenance action.
    /// </summary>
    [IsoId("_tMkpvU6nEeyGi9JAv6wq7Q")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? AdditionalInformation { get; init; }

    /// <summary>
    /// Sequence of action to include in the next MTM management plan.
    /// </summary>
    [IsoId("_tMkpv06nEeyGi9JAv6wq7Q")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public TMSAction10? Action { get; init; }
}
