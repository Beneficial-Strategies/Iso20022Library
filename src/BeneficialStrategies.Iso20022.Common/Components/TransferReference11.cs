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
[IsoId("_L7y38YizEeefvMoXmllHqg")]
[DisplayName("Transfer Reference")]
public partial record TransferReference11
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer instruction for which the cancellation request is sent, as assigned by the instructing party.
    /// </summary>
    [IsoId("_MKcX84izEeefvMoXmllHqg")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_MKcX9YizEeefvMoXmllHqg")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference8? ClientReference { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_MKcX94izEeefvMoXmllHqg")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference8? CounterpartyReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_MKcX-YizEeefvMoXmllHqg")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    [IsoId("_WfYLcIizEeefvMoXmllHqg")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReason { get; init; } 
    
    
    #nullable disable
    
}
