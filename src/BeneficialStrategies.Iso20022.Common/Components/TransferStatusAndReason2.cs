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
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_SwUJhNp-Ed-ak6NoX_4Aeg_-313438480")]
[DisplayName("Transfer Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferStatusAndReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferStatusAndReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferStatusAndReason2( System.String reqTransferReference,TransferInstructionStatus2 reqStatus,PendingSettlementStatus2 reqPendingSettlement,TransferUnmatchedStatus2 reqUnmatched,InRepairStatus3 reqInRepair,RejectedStatus8Choice_ reqRejected,FailedSettlementStatus1 reqFailedSettlement,CancelledStatus3 reqCancelled,ReversedStatus1 reqReversed,CancellationPendingStatus1 reqCancellationPending )
    {
        TransferReference = reqTransferReference;
        Status = reqStatus;
        PendingSettlement = reqPendingSettlement;
        Unmatched = reqUnmatched;
        InRepair = reqInRepair;
        Rejected = reqRejected;
        FailedSettlement = reqFailedSettlement;
        Cancelled = reqCancelled;
        Reversed = reqReversed;
        CancellationPending = reqCancellationPending;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_SwUJhdp-Ed-ak6NoX_4Aeg_-310282796")]
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
    [IsoId("_SwUJhtp-Ed-ak6NoX_4Aeg_-313438462")]
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
    [IsoId("_SwUJh9p-Ed-ak6NoX_4Aeg_-294579471")]
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
    [IsoId("_SwUJiNp-Ed-ak6NoX_4Aeg_-276111982")]
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
    /// Status of the transfer is accepted, sent to next party, matched, already executed, or settled.
    /// </summary>
    [IsoId("_Swd6gNp-Ed-ak6NoX_4Aeg_-313438202")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferInstructionStatus2 Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferInstructionStatus2 Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferInstructionStatus2 Status { get; init; } 
    #else
    public TransferInstructionStatus2 Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_Swd6gdp-Ed-ak6NoX_4Aeg_-313438125")]
    [DisplayName("Pending Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgSttlm")]
    #endif
    [IsoXmlTag("PdgSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PendingSettlementStatus2 PendingSettlement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PendingSettlementStatus2 PendingSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingSettlementStatus2 PendingSettlement { get; init; } 
    #else
    public PendingSettlementStatus2 PendingSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is unmatched.
    /// </summary>
    [IsoId("_Swd6gtp-Ed-ak6NoX_4Aeg_-312518058")]
    [DisplayName("Unmatched")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Umtchd")]
    #endif
    [IsoXmlTag("Umtchd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferUnmatchedStatus2 Unmatched { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferUnmatchedStatus2 Unmatched { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferUnmatchedStatus2 Unmatched { get; init; } 
    #else
    public TransferUnmatchedStatus2 Unmatched { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is in repair.
    /// </summary>
    [IsoId("_Swd6g9p-Ed-ak6NoX_4Aeg_-313438167")]
    [DisplayName("In Repair")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InRpr")]
    #endif
    [IsoXmlTag("InRpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InRepairStatus3 InRepair { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InRepairStatus3 InRepair { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InRepairStatus3 InRepair { get; init; } 
    #else
    public InRepairStatus3 InRepair { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is rejected.
    /// </summary>
    [IsoId("_Swd6hNp-Ed-ak6NoX_4Aeg_-312518093")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatus8Choice_ Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatus8Choice_ Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatus8Choice_ Rejected { get; init; } 
    #else
    public RejectedStatus8Choice_ Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is failed settlement, ie, settlement in the International Central Securities Depository (ICSD) or Central Securities Depository (CSD) failed.
    /// </summary>
    [IsoId("_Swd6hdp-Ed-ak6NoX_4Aeg_1947826371")]
    [DisplayName("Failed Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaildSttlm")]
    #endif
    [IsoXmlTag("FaildSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FailedSettlementStatus1 FailedSettlement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FailedSettlementStatus1 FailedSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FailedSettlementStatus1 FailedSettlement { get; init; } 
    #else
    public FailedSettlementStatus1 FailedSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is cancelled.
    /// </summary>
    [IsoId("_Swd6htp-Ed-ak6NoX_4Aeg_-1230094976")]
    [DisplayName("Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Canc")]
    #endif
    [IsoXmlTag("Canc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatus3 Cancelled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatus3 Cancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatus3 Cancelled { get; init; } 
    #else
    public CancelledStatus3 Cancelled { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is reversed.
    /// </summary>
    [IsoId("_Swd6h9p-Ed-ak6NoX_4Aeg_-1520918098")]
    [DisplayName("Reversed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvsd")]
    #endif
    [IsoXmlTag("Rvsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReversedStatus1 Reversed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReversedStatus1 Reversed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversedStatus1 Reversed { get; init; } 
    #else
    public ReversedStatus1 Reversed { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer is cancellation pending.
    /// </summary>
    [IsoId("_SwnEcNp-Ed-ak6NoX_4Aeg_1051364497")]
    [DisplayName("Cancellation Pending")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlPdg")]
    #endif
    [IsoXmlTag("CxlPdg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationPendingStatus1 CancellationPending { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationPendingStatus1 CancellationPending { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationPendingStatus1 CancellationPending { get; init; } 
    #else
    public CancellationPendingStatus1 CancellationPending { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_SwnEcdp-Ed-ak6NoX_4Aeg_272070826")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeDate { get; init; } 
    #else
    public System.DateOnly? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_SwnEctp-Ed-ak6NoX_4Aeg_1132792510")]
    [DisplayName("Send Out Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndOutDt")]
    #endif
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SendOutDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SendOutDate { get; init; } 
    #else
    public System.DateOnly? SendOutDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_SwnEc9p-Ed-ak6NoX_4Aeg_-312518023")]
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
