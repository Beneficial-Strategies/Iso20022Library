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
[IsoId("_k0GOXfY0Eemf4dJxCjghNw")]
[DisplayName("Tracker Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerPaymentTransaction4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerPaymentTransaction4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerPaymentTransaction4( PaymentIdentification11 reqPaymentIdentification )
    {
        PaymentIdentification = reqPaymentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original tracked message that contained the transaction.
    /// </summary>
    [IsoId("_k0GOX_Y0Eemf4dJxCjghNw")]
    [DisplayName("Tracked Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckdMsgId")]
    #endif
    [IsoXmlTag("TrckdMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; init; } 
    #else
    public OriginalBusinessInstruction2? TrackedMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that provides information on the alert status and related details.
    /// </summary>
    [IsoId("_k0GOYfY0Eemf4dJxCjghNw")]
    [DisplayName("Tracker Informing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmgPty")]
    #endif
    [IsoXmlTag("TrckrInfrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerPartyIdentification1? TrackerInformingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification1? TrackerInformingParty { get; init; } 
    #else
    public TrackerPartyIdentification1? TrackerInformingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    [IsoId("_k0GOZfY0Eemf4dJxCjghNw")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification11 PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification11 PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification11 PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification11 PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement under which or rules under which the payment transaction should be processed.
    /// </summary>
    [IsoId("_k0GOZ_Y0Eemf4dJxCjghNw")]
    [DisplayName("Service Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvl")]
    #endif
    [IsoXmlTag("SvcLvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionServiceLevel1? ServiceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionServiceLevel1? ServiceLevel { get; init; } 
    #else
    public TransactionServiceLevel1? ServiceLevel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
