// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of an individual order of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("_RMeYPNp-Ed-ak6NoX_4Aeg_-887862240")]
[DisplayName("Individual Order Status And Reason")]
public partial record IndividualOrderStatusAndReason4
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_RMeYPdp-Ed-ak6NoX_4Aeg_1308741188")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_RMeYPtp-Ed-ak6NoX_4Aeg_-116720316")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_RMeYP9p-Ed-ak6NoX_4Aeg_-116720299")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_RMoJMNp-Ed-ak6NoX_4Aeg_816035445")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; } 
    
    /// <summary>
    /// Cancellation status of the order.
    /// </summary>
    [IsoId("_RMoJMdp-Ed-ak6NoX_4Aeg_-887862198")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderCancellationStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Status of the individual order cancellation request is rejected.
    /// </summary>
    [IsoId("_RMoJMtp-Ed-ak6NoX_4Aeg_1303154650")]
    [DisplayName("Rejected")]
    [IsoXmlTag("Rjctd")]
    public required RejectedStatus7 Rejected { get; init; } 
    
    /// <summary>
    /// Party that initiates the status of the individual order cancellation.
    /// </summary>
    [IsoId("_RMoJM9p-Ed-ak6NoX_4Aeg_95905389")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    
    /// <summary>
    /// Account information of the individual order cancellation for which the status is given.
    /// </summary>
    [IsoId("_RMoJNNp-Ed-ak6NoX_4Aeg_5464410")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Financial instrument information of the individual order cancellation for which the status is given.
    /// </summary>
    [IsoId("_RMoJNdp-Ed-ak6NoX_4Aeg_19318173")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    
    
    #nullable disable
    
}
