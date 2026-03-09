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
[IsoId("_SxzXTNp-Ed-ak6NoX_4Aeg_195934515")]
[DisplayName("Cancellation Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancellationStatusAndReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancellationStatusAndReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancellationStatusAndReason2( System.String reqTransferReference,TransferCancellationStatus2 reqStatus,TransferCancellationRejectedStatus1 reqRejected,TransferCancellationCompleteStatusAndReason1 reqComplete,TransferCancellationPendingStatus1 reqPending )
    {
        TransferReference = reqTransferReference;
        Status = reqStatus;
        Rejected = reqRejected;
        Complete = reqComplete;
        Pending = reqPending;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_SxzXTdp-Ed-ak6NoX_4Aeg_272585936")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of a transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SxzXTtp-Ed-ak6NoX_4Aeg_272585953")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_SxzXT9p-Ed-ak6NoX_4Aeg_272585988")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientReference { get; init; } 
    #else
    public System.String? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Sx9IQNp-Ed-ak6NoX_4Aeg_272586223")]
    [DisplayName("Cancellation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRef")]
    #endif
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReference { get; init; } 
    #else
    public System.String? CancellationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    [IsoId("_Sx9IQdp-Ed-ak6NoX_4Aeg_197781106")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferCancellationStatus2 Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferCancellationStatus2 Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferCancellationStatus2 Status { get; init; } 
    #else
    public TransferCancellationStatus2 Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer cancellation is rejected.
    /// </summary>
    [IsoId("_Sx9IQtp-Ed-ak6NoX_4Aeg_195934569")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferCancellationRejectedStatus1 Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferCancellationRejectedStatus1 Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferCancellationRejectedStatus1 Rejected { get; init; } 
    #else
    public TransferCancellationRejectedStatus1 Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer cancellation is complete. The cancellation instruction has been accepted and processed, the cancellation is complete.
    /// </summary>
    [IsoId("_Sx9IQ9p-Ed-ak6NoX_4Aeg_195934611")]
    [DisplayName("Complete")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmplt")]
    #endif
    [IsoXmlTag("Cmplt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferCancellationCompleteStatusAndReason1 Complete { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferCancellationCompleteStatusAndReason1 Complete { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferCancellationCompleteStatusAndReason1 Complete { get; init; } 
    #else
    public TransferCancellationCompleteStatusAndReason1 Complete { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer cancellation is pending.
    /// </summary>
    [IsoId("_Sx9IRNp-Ed-ak6NoX_4Aeg_-95318640")]
    [DisplayName("Pending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdg")]
    #endif
    [IsoXmlTag("Pdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferCancellationPendingStatus1 Pending { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferCancellationPendingStatus1 Pending { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferCancellationPendingStatus1 Pending { get; init; } 
    #else
    public TransferCancellationPendingStatus1 Pending { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_Sx9IRdp-Ed-ak6NoX_4Aeg_195934518")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    #else
    public PartyIdentification2Choice_? StatusInitiator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
