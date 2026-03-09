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
/// Further information on the reversal reason of the transaction.
/// </summary>
[IsoId("_TPKBodp-Ed-ak6NoX_4Aeg_157540470")]
[DisplayName("Reversal Reason Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalReasonInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party issuing the reversal.
    /// </summary>
    [IsoId("_TPKBotp-Ed-ak6NoX_4Aeg_157540608")]
    [DisplayName("Reversal Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslOrgtr")]
    #endif
    [IsoXmlTag("RvslOrgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? ReversalOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? ReversalOriginator { get; init; } 
    #else
    public PartyIdentification8? ReversalOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_TPKBo9p-Ed-ak6NoX_4Aeg_157540556")]
    [DisplayName("Reversal Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRsn")]
    #endif
    [IsoXmlTag("RvslRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalReason1Choice_? ReversalReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalReason1Choice_? ReversalReason { get; init; } 
    #else
    public ReversalReason1Choice_? ReversalReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the reversal reason.
    /// </summary>
    [IsoId("_TPKBpNp-Ed-ak6NoX_4Aeg_157540512")]
    [DisplayName("Additional Reversal Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRvslRsnInf")]
    #endif
    [IsoXmlTag("AddtlRvslRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalReversalReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalReversalReasonInformation { get; init; } 
    #else
    public System.String? AdditionalReversalReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
