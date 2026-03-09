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
/// Provides the data for the pending intra-balance movements.
/// </summary>
[IsoId("_Ys-BmzneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Pending")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraBalancePending5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_Y3sq0zneEem7JZMuWtwtsg")]
    [DisplayName("Status And Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsAndRsn")]
    #endif
    [IsoXmlTag("StsAndRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingStatusAndReason2? StatusAndReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingStatusAndReason2? StatusAndReason { get; init; } 
    #else
    public PendingStatusAndReason2? StatusAndReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the individual intrabalance movement transaction.
    /// </summary>
    [IsoId("_Y3sq1TneEem7JZMuWtwtsg")]
    [DisplayName("Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mvmnt")]
    #endif
    [IsoXmlTag("Mvmnt")]
    public ValueList<IntraBalancePending6> Movement { get; init; } = new ValueList<IntraBalancePending6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Y3sq1TneEem7JZMuWtwtsg
    
    
    #nullable disable
    
}
