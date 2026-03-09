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
/// Status of a transfer cancellation instruction and the reason for the status.
/// </summary>
[IsoId("_Uww-Vtp-Ed-ak6NoX_4Aeg_-973620019")]
[DisplayName("Cancellation Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancellationStatusAndReason
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancellationStatusAndReason instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancellationStatusAndReason( TransferCancellationStatus reqStatus,TransferCancellationRejectedStatus1Choice_ reqRejected,TransferCancellationCompleteStatusChoice_ reqComplete )
    {
        Status = reqStatus;
        Rejected = reqRejected;
        Complete = reqComplete;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the transfer cancellation instruction.
    /// </summary>
    [IsoId("_Uww-V9p-Ed-ak6NoX_4Aeg_698798027")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferCancellationStatus Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferCancellationStatus Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferCancellationStatus Status { get; init; } 
    #else
    public TransferCancellationStatus Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of transfer cancellation is rejected.
    /// </summary>
    [IsoId("_Uww-WNp-Ed-ak6NoX_4Aeg_409661495")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferCancellationRejectedStatus1Choice_ Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferCancellationRejectedStatus1Choice_ Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferCancellationRejectedStatus1Choice_ Rejected { get; init; } 
    #else
    public TransferCancellationRejectedStatus1Choice_ Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer cancellation is complete. The cancellation instruction has been accepted and processed, the cancellation is complete.
    /// </summary>
    [IsoId("_Uww-Wdp-Ed-ak6NoX_4Aeg_-1596403694")]
    [DisplayName("Complete")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmplt")]
    #endif
    [IsoXmlTag("Cmplt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferCancellationCompleteStatusChoice_ Complete { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferCancellationCompleteStatusChoice_ Complete { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferCancellationCompleteStatusChoice_ Complete { get; init; } 
    #else
    public TransferCancellationCompleteStatusChoice_ Complete { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_Uww-Wtp-Ed-ak6NoX_4Aeg_1646242469")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1Choice_? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1Choice_? StatusInitiator { get; init; } 
    #else
    public PartyIdentification1Choice_? StatusInitiator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
