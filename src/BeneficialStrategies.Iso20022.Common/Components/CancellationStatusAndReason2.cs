// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a transfer cancellation instruction and the reason for the status.
/// </summary>
[IsoId("_SxzXTNp-Ed-ak6NoX_4Aeg_195934515")]
[DisplayName("Cancellation Status And Reason")]
public partial record CancellationStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_SxzXTdp-Ed-ak6NoX_4Aeg_272585936")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of a transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SxzXTtp-Ed-ak6NoX_4Aeg_272585953")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_SxzXT9p-Ed-ak6NoX_4Aeg_272585988")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Sx9IQNp-Ed-ak6NoX_4Aeg_272586223")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    [IsoId("_Sx9IQdp-Ed-ak6NoX_4Aeg_197781106")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required TransferCancellationStatus2 Status { get; init; } 
    
    /// <summary>
    /// Status of the transfer cancellation is rejected.
    /// </summary>
    [IsoId("_Sx9IQtp-Ed-ak6NoX_4Aeg_195934569")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required TransferCancellationRejectedStatus1 Rejected { get; init; } 
    
    /// <summary>
    /// Status of the transfer cancellation is complete. The cancellation instruction has been accepted and processed, the cancellation is complete.
    /// </summary>
    [IsoId("_Sx9IQ9p-Ed-ak6NoX_4Aeg_195934611")]
    [DisplayName("Complete")]
    [IsoXmlTag("Cmplt")]
    public required TransferCancellationCompleteStatusAndReason1 Complete { get; init; } 
    
    /// <summary>
    /// Status of the transfer cancellation is pending.
    /// </summary>
    [IsoId("_Sx9IRNp-Ed-ak6NoX_4Aeg_-95318640")]
    [DisplayName("Pending")]
    [IsoXmlTag("Pdg")]
    public required TransferCancellationPendingStatus1 Pending { get; init; } 
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_Sx9IRdp-Ed-ak6NoX_4Aeg_195934518")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    
    
    #nullable disable
    
}
