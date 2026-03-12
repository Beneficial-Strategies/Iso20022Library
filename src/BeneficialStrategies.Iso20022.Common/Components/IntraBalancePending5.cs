// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the data for the pending intra-balance movements.
/// </summary>
[IsoId("_Ys-BmzneEem7JZMuWtwtsg")]
[DisplayName("Intra Balance Pending")]
public partial record IntraBalancePending5
{
    #nullable enable
    
    /// <summary>
    /// Status and status reason of the transaction.
    /// </summary>
    [IsoId("_Y3sq0zneEem7JZMuWtwtsg")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public PendingStatusAndReason2? StatusAndReason { get; init; } 
    
    /// <summary>
    /// Further details on the individual intrabalance movement transaction.
    /// </summary>
    [IsoId("_Y3sq1TneEem7JZMuWtwtsg")]
    [DisplayName("Movement")]
    [IsoXmlTag("Mvmnt")]
    public ValueList<IntraBalancePending6> Movement { get; init; } = new ValueList<IntraBalancePending6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Y3sq1TneEem7JZMuWtwtsg
    
    
    #nullable disable
    
}
