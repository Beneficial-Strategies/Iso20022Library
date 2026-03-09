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
/// Provides further details on the reason of the cheque presentment cancellation request.
/// </summary>
[IsoId("_kwwc97tvEeq_cfXrH83Rcw")]
[DisplayName("Cheque Cancellation Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ChequeCancellationReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ChequeCancellationReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ChequeCancellationReason1( ChequeCancellationReason1Choice_ reqReason )
    {
        Reason = reqReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_kwwc-btvEeq_cfXrH83Rcw")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChequePartyRole1Code? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChequePartyRole1Code? Originator { get; init; } 
    #else
    public ChequePartyRole1Code? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_kwwc-LtvEeq_cfXrH83Rcw")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChequeCancellationReason1Choice_ Reason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChequeCancellationReason1Choice_ Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChequeCancellationReason1Choice_ Reason { get; init; } 
    #else
    public ChequeCancellationReason1Choice_ Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_kwwc-rtvEeq_cfXrH83Rcw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
