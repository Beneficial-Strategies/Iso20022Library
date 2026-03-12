// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Participant profile participant information.
/// </summary>
[IsoId("_5On4EB9nEeapDZRA0Hb6ow")]
[DisplayName("Participant Information")]
public partial record ParticipantInformation1
{
    #nullable enable
    
    /// <summary>
    /// Date the profile was deleted.
    /// </summary>
    [IsoId("_Q1cYYB9oEeapDZRA0Hb6ow")]
    [DisplayName("Profile Deletion Date")]
    [IsoXmlTag("PrflDeltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ProfileDeletionDate { get; init; } 
    
    /// <summary>
    /// National BIC identifiers for authorised and central branches.
    /// </summary>
    [IsoId("_oJLIIB9pEeapDZRA0Hb6ow")]
    [DisplayName("Bank Branch")]
    [IsoXmlTag("BkBrnch")]
    public CentralisedAndAuthorisedBranchIdentification1Choice_? BankBranch { get; init; } 
    
    /// <summary>
    /// CBRF identification of the terminal.
    /// </summary>
    [IsoId("_Dx0NMB9sEeapDZRA0Hb6ow")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TerminalIdentification { get; init; } 
    
    /// <summary>
    /// Intraday restrictions details.
    /// </summary>
    [IsoId("_WauMkB9tEeapDZRA0Hb6ow")]
    [DisplayName("Restrictions")]
    [IsoXmlTag("Rstrctns")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Restrictions { get; init; } 
    
    /// <summary>
    /// External payment system details.
    /// </summary>
    [IsoId("_XFengB9yEeapDZRA0Hb6ow")]
    [DisplayName("External Payment System Information")]
    [IsoXmlTag("XtrnlPmtSysInf")]
    public ExternalPaymentSystemDetails1? ExternalPaymentSystemInformation { get; init; } 
    
    /// <summary>
    /// Information related for participant migration process.
    /// </summary>
    [IsoId("_gEt3YCG3EeaZx5-Tw7BKeQ")]
    [DisplayName("Migration")]
    [IsoXmlTag("Mgrtn")]
    public required SystemMigration1 Migration { get; init; } 
    
    
    #nullable disable
    
}
