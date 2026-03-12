// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[IsoId("_Y2MKQR3ZEeKKrOIoqWglDw")]
[DisplayName("TMS Action")]
public partial record TMSAction2
{
    #nullable enable
    
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_ZCYzMR3ZEeKKrOIoqWglDw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction1Code Type { get; init; } 
    
    /// <summary>
    /// Communication parameters of the terminal management system to contact.
    /// </summary>
    [IsoId("_ZCYzNR3ZEeKKrOIoqWglDw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public NetworkParameters1? Address { get; init; } 
    
    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_ZCYzOR3ZEeKKrOIoqWglDw")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification3? DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_ZCYzPR3ZEeKKrOIoqWglDw")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; } 
    
    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_ZCYzQR3ZEeKKrOIoqWglDw")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public TerminalManagementAdditionalProcess1Code? AdditionalProcess { get; init; } 
    
    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_ZCYzRR3ZEeKKrOIoqWglDw")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming2? TimeCondition { get; init; } 
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_racKMCmuEeKIjpr--01h3Q")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; } 
    
    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_GhvusCmvEeKIjpr--01h3Q")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? KeyEnciphermentCertificate { get; init; } 
    
    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_ZCYzSR3ZEeKKrOIoqWglDw")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ErrorAction2? ErrorAction { get; init; } 
    
    
    #nullable disable
    
}
