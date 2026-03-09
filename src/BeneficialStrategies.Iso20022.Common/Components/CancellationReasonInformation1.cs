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
/// Further information on the cancellation reason of the transaction.
/// </summary>
[IsoId("_TO3Gttp-Ed-ak6NoX_4Aeg_-436227161")]
[DisplayName("Cancellation Reason Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancellationReasonInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Party issuing the cancellation request.
    /// </summary>
    [IsoId("_TO3Gt9p-Ed-ak6NoX_4Aeg_-436226813")]
    [DisplayName("Cancellation Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlOrgtr")]
    #endif
    [IsoXmlTag("CxlOrgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? CancellationOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? CancellationOriginator { get; init; } 
    #else
    public PartyIdentification8? CancellationOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_TPA3sNp-Ed-ak6NoX_4Aeg_-436226866")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationReason1Choice_? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationReason1Choice_? CancellationReason { get; init; } 
    #else
    public CancellationReason1Choice_? CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the cancellation request reason.||Usage: Additional cancellation reason information can be used to further detail the cancellation request reason.
    /// </summary>
    [IsoId("_TPA3sdp-Ed-ak6NoX_4Aeg_-436227125")]
    [DisplayName("Additional Cancellation Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCxlRsnInf")]
    #endif
    [IsoXmlTag("AddtlCxlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalCancellationReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalCancellationReasonInformation { get; init; } 
    #else
    public System.String? AdditionalCancellationReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
