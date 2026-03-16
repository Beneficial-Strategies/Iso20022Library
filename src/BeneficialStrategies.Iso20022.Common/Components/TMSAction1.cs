// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[IsoId("_KsN70X1DEeCF8NjrBemJWQ_-405240554")]
[DisplayName("TMS Action")]
public record TMSAction1
{
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_KsN70n1DEeCF8NjrBemJWQ_-1093789784")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction1Code Type { get; init; }

    /// <summary>
    /// Communication parameters of the terminal management system to contact.
    /// </summary>
    [IsoId("_KsN7031DEeCF8NjrBemJWQ_39936123")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters1? Address { get; init; }

    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_KsN71H1DEeCF8NjrBemJWQ_1755305315")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification2? DataSetIdentification { get; init; }

    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_KsN71X1DEeCF8NjrBemJWQ_-687090561")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; }

    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_KsN71n1DEeCF8NjrBemJWQ_1036887615")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; }

    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_KsN7131DEeCF8NjrBemJWQ_-291991175")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming1? TimeCondition { get; init; }

    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_KsN72H1DEeCF8NjrBemJWQ_1120775201")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ErrorAction1? ErrorAction { get; init; }
}
