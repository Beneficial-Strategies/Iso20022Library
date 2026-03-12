// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data about participant migration to new payment system process.
/// </summary>
[IsoId("_g8InkCG3EeaZx5-Tw7BKeQ")]
[DisplayName("System Migration")]
public partial record SystemMigration1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the participant is a member of a new payment system.
    /// </summary>
    [IsoId("_TqHo0CHAEeaZx5-Tw7BKeQ")]
    [DisplayName("NPS Participant Indicator")]
    [IsoXmlTag("NPSPtcptInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NPSParticipantIndicator { get; init; } 
    
    /// <summary>
    /// Planned migration date.
    /// </summary>
    [IsoId("_Z_SbICHAEeaZx5-Tw7BKeQ")]
    [DisplayName("Planned Migration Date")]
    [IsoXmlTag("PlandMgrtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? PlannedMigrationDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the balance was received.
    /// </summary>
    [IsoId("_WYk3UCG5EeaZx5-Tw7BKeQ")]
    [DisplayName("Balance Received Indicator")]
    [IsoXmlTag("BalRcvdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BalanceReceivedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the participant was migrated.
    /// </summary>
    [IsoId("_ruxDsCG3EeaZx5-Tw7BKeQ")]
    [DisplayName("Migrated")]
    [IsoXmlTag("Mgrtd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Migrated { get; init; } 
    
    /// <summary>
    /// Date of the latest RABIS service.
    /// </summary>
    [IsoId("_ze70YCG3EeaZx5-Tw7BKeQ")]
    [DisplayName("Last Date")]
    [IsoXmlTag("LastDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? LastDate { get; init; } 
    
    
    #nullable disable
    
}
