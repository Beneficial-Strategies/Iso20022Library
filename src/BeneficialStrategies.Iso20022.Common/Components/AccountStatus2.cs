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
/// Status of an account.
/// </summary>
[IsoId("_N5eWMEy9EeafiMTDrtSnyw")]
[DisplayName("Account Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Account can be used for its intended purpose.
    /// </summary>
    [IsoId("_USUHkEy9EeafiMTDrtSnyw")]
    [DisplayName("Enabled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nbld")]
    #endif
    [IsoXmlTag("Nbld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnabledStatusReason1Choice_? Enabled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnabledStatusReason1Choice_? Enabled { get; init; } 
    #else
    public EnabledStatusReason1Choice_? Enabled { get; set; } 
    #endif
    
    /// <summary>
    /// Account cannot temporarily be used for its intended purpose.
    /// </summary>
    [IsoId("_We568Ey9EeafiMTDrtSnyw")]
    [DisplayName("Disabled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsbld")]
    #endif
    [IsoXmlTag("Dsbld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisabledStatusReason1Choice_? Disabled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisabledStatusReason1Choice_? Disabled { get; init; } 
    #else
    public DisabledStatusReason1Choice_? Disabled { get; set; } 
    #endif
    
    /// <summary>
    /// Account change is pending approval.
    /// </summary>
    [IsoId("_XztxwEy9EeafiMTDrtSnyw")]
    [DisplayName("Pending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdg")]
    #endif
    [IsoXmlTag("Pdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingStatusReason1Choice_? Pending { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingStatusReason1Choice_? Pending { get; init; } 
    #else
    public PendingStatusReason1Choice_? Pending { get; set; } 
    #endif
    
    /// <summary>
    /// Account opening is pending.
    /// </summary>
    [IsoId("_Z6oqEGCJEeabZtzjEVWYCQ")]
    [DisplayName("Pending Opening")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgOpng")]
    #endif
    [IsoXmlTag("PdgOpng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingOpeningStatusReason1Choice_? PendingOpening { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingOpeningStatusReason1Choice_? PendingOpening { get; init; } 
    #else
    public PendingOpeningStatusReason1Choice_? PendingOpening { get; set; } 
    #endif
    
    /// <summary>
    /// Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.
    /// </summary>
    [IsoId("_bdJWkEy9EeafiMTDrtSnyw")]
    [DisplayName("Proforma")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Profrm")]
    #endif
    [IsoXmlTag("Profrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProformaStatusReason1Choice_? Proforma { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProformaStatusReason1Choice_? Proforma { get; init; } 
    #else
    public ProformaStatusReason1Choice_? Proforma { get; set; } 
    #endif
    
    /// <summary>
    /// Account is closed.
    /// </summary>
    [IsoId("_dPQNYEy9EeafiMTDrtSnyw")]
    [DisplayName("Closed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clsd")]
    #endif
    [IsoXmlTag("Clsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosedStatusReason1Choice_? Closed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosedStatusReason1Choice_? Closed { get; init; } 
    #else
    public ClosedStatusReason1Choice_? Closed { get; set; } 
    #endif
    
    /// <summary>
    /// Account closure is pending.
    /// </summary>
    [IsoId("_O96L4GCLEeabZtzjEVWYCQ")]
    [DisplayName("Closure Pending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrPdg")]
    #endif
    [IsoXmlTag("ClsrPdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClosurePendingStatusReason1Choice_? ClosurePending { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosurePendingStatusReason1Choice_? ClosurePending { get; init; } 
    #else
    public ClosurePendingStatusReason1Choice_? ClosurePending { get; set; } 
    #endif
    
    /// <summary>
    /// Status is a bilaterally agreed status.
    /// </summary>
    [IsoId("_h6vsIEy9EeafiMTDrtSnyw")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAccountStatus1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAccountStatus1? Other { get; init; } 
    #else
    public OtherAccountStatus1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
