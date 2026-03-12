// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of the individual orders confirmation that was previously received.
/// </summary>
[IsoId("_RMoJOdp-Ed-ak6NoX_4Aeg_-1768968908")]
[DisplayName("Individual Order Confirmation Status And Reason")]
public partial record IndividualOrderConfirmationStatusAndReason1
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_RMoJOtp-Ed-ak6NoX_4Aeg_-1768968890")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_RMx6MNp-Ed-ak6NoX_4Aeg_-1768968873")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_RMx6Mdp-Ed-ak6NoX_4Aeg_-1768968856")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_RMx6Mtp-Ed-ak6NoX_4Aeg_-1768968838")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DealReference { get; init; } 
    
    /// <summary>
    /// Status of the order confirmation is rejected.
    /// </summary>
    [IsoId("_RMx6M9p-Ed-ak6NoX_4Aeg_-1768968423")]
    [DisplayName("Confirmation Rejected")]
    [IsoXmlTag("ConfRjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<ConfirmationRejectedStatus1> ConfirmationRejected { get; init; } = new ValueList<ConfirmationRejectedStatus1>(){};
    
    /// <summary>
    /// Status of the order confirmation amendment is rejected.
    /// </summary>
    [IsoId("_RMx6NNp-Ed-ak6NoX_4Aeg_1434728868")]
    [DisplayName("Amendment Rejected")]
    [IsoXmlTag("AmdmntRjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<ConfirmationRejectedStatus1> AmendmentRejected { get; init; } = new ValueList<ConfirmationRejectedStatus1>(){};
    
    /// <summary>
    /// Status of the order confirmation is accepted or received or sent to next party or there is a communication problem with next party. There is no reason attached.
    /// </summary>
    [IsoId("_RMx6Ndp-Ed-ak6NoX_4Aeg_-1768968796")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required OrderConfirmationStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Party that initiates the status of the order confirmation.
    /// </summary>
    [IsoId("_RMx6Ntp-Ed-ak6NoX_4Aeg_-1768968036")]
    [DisplayName("Status Initiator")]
    [IsoXmlTag("StsInitr")]
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    
    /// <summary>
    /// Account information of the individual order confirmation for which the status is given.
    /// </summary>
    [IsoId("_RMx6N9p-Ed-ak6NoX_4Aeg_-1101819003")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Financial instrument information of the individual order confirmation for which the status is given.
    /// </summary>
    [IsoId("_RMx6ONp-Ed-ak6NoX_4Aeg_-1088890047")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    
    
    #nullable disable
    
}
