// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of a transfer and of a transfer cancellation.
/// </summary>
[IsoId("_YPWs8XhFEeij0vbhRaNJcw")]
[DisplayName("Transfer Reference")]
public partial record TransferReference14
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the portfolio transfer instruction, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Yhzu4XhFEeij0vbhRaNJcw")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the portfolio transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_Yhzu43hFEeij0vbhRaNJcw")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the portfolio transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_Yhzu5XhFEeij0vbhRaNJcw")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the portfolio transfer execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("_Yhzu53hFEeij0vbhRaNJcw")]
    [DisplayName("Transfer Confirmation Reference")]
    [IsoXmlTag("TrfConfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransferConfirmationReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the portfolio transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Yhzu6XhFEeij0vbhRaNJcw")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    [IsoId("_Yhzu63hFEeij0vbhRaNJcw")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReason { get; init; } 
    
    
    #nullable disable
    
}
