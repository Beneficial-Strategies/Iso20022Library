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
/// Key elements used to identify the original transaction(s) that is being referred to.
/// </summary>
[IsoId("_n7bpJ2RPEeqImsG9JNoSQw")]
[DisplayName("Tracker Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerPaymentTransaction7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original tracked message that contained the transaction.
    /// </summary>
    [IsoId("_oC8mYWRPEeqImsG9JNoSQw")]
    [DisplayName("Tracked Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckdMsgId")]
    #endif
    [IsoXmlTag("TrckdMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; } 
    #else
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that provides information on the alert status and related details.
    /// </summary>
    [IsoId("_oC8mY2RPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmgPty")]
    #endif
    [IsoXmlTag("TrckrInfrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    #else
    public TrackerPartyIdentification2? TrackerInformingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is updated on the alert status and related details.
    /// </summary>
    [IsoId("_oC8mZWRPEeqImsG9JNoSQw")]
    [DisplayName("Tracker Informed Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmdPty")]
    #endif
    [IsoXmlTag("TrckrInfrmdPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    #else
    public TrackerPartyIdentification2? TrackerInformedParty { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_oC8mZ2RPEeqImsG9JNoSQw")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentIdentification10? PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification10? PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification10? PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the payment transaction should be processed.
    /// </summary>
    [IsoId("_oC8maWRPEeqImsG9JNoSQw")]
    [DisplayName("Service Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvl")]
    #endif
    [IsoXmlTag("SvcLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceLevel8Choice_? ServiceLevel { get; init; } 
    #else
    public ServiceLevel8Choice_? ServiceLevel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
