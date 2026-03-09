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
/// General information about the reason of the rejection.
/// </summary>
[IsoId("_UsSuA9p-Ed-ak6NoX_4Aeg_-521235445")]
[DisplayName("Rejection Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RejectionReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RejectionReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RejectionReason2( System.String reqRejectingPartyReason )
    {
        RejectingPartyReason = reqRejectingPartyReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason of the rejection provided by the rejecting party.
    /// </summary>
    [IsoId("_UsSuBNp-Ed-ak6NoX_4Aeg_-153673413")]
    [DisplayName("Rejecting Party Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctgPtyRsn")]
    #endif
    [IsoXmlTag("RjctgPtyRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RejectingPartyReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RejectingPartyReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RejectingPartyReason { get; init; } 
    #else
    public System.String RejectingPartyReason { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the rejection was generated.
    /// </summary>
    [IsoId("_UsSuBdp-Ed-ak6NoX_4Aeg_-897575826")]
    [DisplayName("Rejection Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnDtTm")]
    #endif
    [IsoXmlTag("RjctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RejectionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RejectionDateTime { get; init; } 
    #else
    public System.DateTime? RejectionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the precise location of the potential error in a message.
    /// </summary>
    [IsoId("_UsSuBtp-Ed-ak6NoX_4Aeg_-147208766")]
    [DisplayName("Error Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrLctn")]
    #endif
    [IsoXmlTag("ErrLctn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ErrorLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ErrorLocation { get; init; } 
    #else
    public System.String? ErrorLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed description of the rejection reason.
    /// </summary>
    [IsoId("_UsSuB9p-Ed-ak6NoX_4Aeg_-90876576")]
    [DisplayName("Reason Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnDesc")]
    #endif
    [IsoXmlTag("RsnDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ReasonDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReasonDescription { get; init; } 
    #else
    public System.String? ReasonDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the rejection and meant to allow for the precise identification of the rejection reason. This could include a copy of the rejected message in part or in full.
    /// </summary>
    [IsoId("_UsSuCNp-Ed-ak6NoX_4Aeg_-53011612")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
