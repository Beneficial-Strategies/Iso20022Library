// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the events that occurred for one transaction.
/// </summary>
[IsoId("_i1YO8efGEeKNfc-Rw_dPYg")]
[DisplayName("Activity Report Items")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActivityReportItems3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActivityReportItems3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActivityReportItems3( System.String reqTransactionIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_jT0ecefGEeKNfc-Rw_dPYg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_jT0ec-fGEeKNfc-Rw_dPYg")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Entity for which the activity is reported.
    /// </summary>
    [IsoId("_jT0edefGEeKNfc-Rw_dPYg")]
    [DisplayName("Reported Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdNtty")]
    #endif
    [IsoXmlTag("RptdNtty")]
    public ValueList<BICIdentification1> ReportedEntity { get; init; } = new ValueList<BICIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _jT0edefGEeKNfc-Rw_dPYg
    
    /// <summary>
    /// Describes an activity that took place during a period.
    /// </summary>
    [IsoId("_jT1FgefGEeKNfc-Rw_dPYg")]
    [DisplayName("Reported Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptdItm")]
    #endif
    [IsoXmlTag("RptdItm")]
    public ValueList<ActivityDetails1> ReportedItem { get; init; } = new ValueList<ActivityDetails1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _jT1FgefGEeKNfc-Rw_dPYg
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_jT1Fg-fGEeKNfc-Rw_dPYg")]
    [DisplayName("Pending Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgReqForActn")]
    #endif
    [IsoXmlTag("PdgReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? PendingRequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? PendingRequestForAction { get; init; } 
    #else
    public PendingActivity2? PendingRequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
