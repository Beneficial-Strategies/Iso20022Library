// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the events that occurred for one transaction.
/// </summary>
[IsoId("_i1YO8efGEeKNfc-Rw_dPYg")]
[DisplayName("Activity Report Items")]
public partial record ActivityReportItems3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_jT0ecefGEeKNfc-Rw_dPYg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_jT0ec-fGEeKNfc-Rw_dPYg")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Entity for which the activity is reported.
    /// </summary>
    [IsoId("_jT0edefGEeKNfc-Rw_dPYg")]
    [DisplayName("Reported Entity")]
    [IsoXmlTag("RptdNtty")]
    public ValueList<BICIdentification1> ReportedEntity { get; init; } = new ValueList<BICIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _jT0edefGEeKNfc-Rw_dPYg
    
    /// <summary>
    /// Describes an activity that took place during a period.
    /// </summary>
    [IsoId("_jT1FgefGEeKNfc-Rw_dPYg")]
    [DisplayName("Reported Item")]
    [IsoXmlTag("RptdItm")]
    public ValueList<ActivityDetails1> ReportedItem { get; init; } = new ValueList<ActivityDetails1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _jT1FgefGEeKNfc-Rw_dPYg
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_jT1Fg-fGEeKNfc-Rw_dPYg")]
    [DisplayName("Pending Request For Action")]
    [IsoXmlTag("PdgReqForActn")]
    public PendingActivity2? PendingRequestForAction { get; init; } 
    
    
    #nullable disable
    
}
