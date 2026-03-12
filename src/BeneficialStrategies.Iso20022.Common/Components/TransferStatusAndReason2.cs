// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_SwUJhNp-Ed-ak6NoX_4Aeg_-313438480")]
[DisplayName("Transfer Status And Reason")]
public partial record TransferStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_SwUJhdp-Ed-ak6NoX_4Aeg_-310282796")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of a transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SwUJhtp-Ed-ak6NoX_4Aeg_-313438462")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_SwUJh9p-Ed-ak6NoX_4Aeg_-294579471")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SwUJiNp-Ed-ak6NoX_4Aeg_-276111982")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Status of the transfer is accepted, sent to next party, matched, already executed, or settled.
    /// </summary>
    [IsoId("_Swd6gNp-Ed-ak6NoX_4Aeg_-313438202")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferInstructionStatus2 Status { get; init; } 
    
    /// <summary>
    /// Status of the transfer is pending settlement.
    /// </summary>
    [IsoId("_Swd6gdp-Ed-ak6NoX_4Aeg_-313438125")]
    [DisplayName("Pending Settlement")]
    [IsoXmlTag("PdgSttlm")]
    public required PendingSettlementStatus2 PendingSettlement { get; init; } 
    
    /// <summary>
    /// Status of the transfer is unmatched.
    /// </summary>
    [IsoId("_Swd6gtp-Ed-ak6NoX_4Aeg_-312518058")]
    [DisplayName("Unmatched")]
    [IsoXmlTag("Umtchd")]
    public required TransferUnmatchedStatus2 Unmatched { get; init; } 
    
    /// <summary>
    /// Status of the transfer is in repair.
    /// </summary>
    [IsoId("_Swd6g9p-Ed-ak6NoX_4Aeg_-313438167")]
    [DisplayName("In Repair")]
    [IsoXmlTag("InRpr")]
    public required InRepairStatus3 InRepair { get; init; } 
    
    /// <summary>
    /// Status of the transfer is rejected.
    /// </summary>
    [IsoId("_Swd6hNp-Ed-ak6NoX_4Aeg_-312518093")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus8Choice_ Rejected { get; init; } 
    
    /// <summary>
    /// Status of the transfer is failed settlement, ie, settlement in the International Central Securities Depository (ICSD) or Central Securities Depository (CSD) failed.
    /// </summary>
    [IsoId("_Swd6hdp-Ed-ak6NoX_4Aeg_1947826371")]
    [DisplayName("Failed Settlement")]
    [IsoXmlTag("FaildSttlm")]
    public required FailedSettlementStatus1 FailedSettlement { get; init; } 
    
    /// <summary>
    /// Status of the transfer is cancelled.
    /// </summary>
    [IsoId("_Swd6htp-Ed-ak6NoX_4Aeg_-1230094976")]
    [DisplayName("Cancelled")]
    [IsoXmlTag("Canc")]
    public required CancelledStatus3 Cancelled { get; init; } 
    
    /// <summary>
    /// Status of the transfer is reversed.
    /// </summary>
    [IsoId("_Swd6h9p-Ed-ak6NoX_4Aeg_-1520918098")]
    [DisplayName("Reversed")]
    [IsoXmlTag("Rvsd")]
    public required ReversedStatus1 Reversed { get; init; } 
    
    /// <summary>
    /// Status of the transfer is cancellation pending.
    /// </summary>
    [IsoId("_SwnEcNp-Ed-ak6NoX_4Aeg_1051364497")]
    [DisplayName("Cancellation Pending")]
    [IsoXmlTag("CxlPdg")]
    public required CancellationPendingStatus1 CancellationPending { get; init; } 
    
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_SwnEcdp-Ed-ak6NoX_4Aeg_272070826")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; } 
    
    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_SwnEctp-Ed-ak6NoX_4Aeg_1132792510")]
    [DisplayName("Send Out Date")]
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SendOutDate { get; init; } 
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_SwnEc9p-Ed-ak6NoX_4Aeg_-312518023")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    
    
    #nullable disable
    
}
