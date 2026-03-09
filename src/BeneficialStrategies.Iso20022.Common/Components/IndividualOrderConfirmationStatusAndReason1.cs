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
/// Status report of the individual orders confirmation that was previously received.
/// </summary>
[IsoId("_RMoJOdp-Ed-ak6NoX_4Aeg_-1768968908")]
[DisplayName("Individual Order Confirmation Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualOrderConfirmationStatusAndReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualOrderConfirmationStatusAndReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualOrderConfirmationStatusAndReason1( System.String reqOrderReference,OrderConfirmationStatus1Code reqStatus )
    {
        OrderReference = reqOrderReference;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_RMoJOtp-Ed-ak6NoX_4Aeg_-1768968890")]
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
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_RMx6MNp-Ed-ak6NoX_4Aeg_-1768968873")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OrderReference { get; init; } 
    #else
    public System.String OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_RMx6Mdp-Ed-ak6NoX_4Aeg_-1768968856")]
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
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_RMx6Mtp-Ed-ak6NoX_4Aeg_-1768968838")]
    [DisplayName("Deal Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealRef")]
    #endif
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DealReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DealReference { get; init; } 
    #else
    public System.String? DealReference { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the order confirmation is rejected.
    /// </summary>
    [IsoId("_RMx6M9p-Ed-ak6NoX_4Aeg_-1768968423")]
    [DisplayName("Confirmation Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfRjctd")]
    #endif
    [IsoXmlTag("ConfRjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<ConfirmationRejectedStatus1> ConfirmationRejected { get; init; } = new ValueList<ConfirmationRejectedStatus1>(){};
    
    /// <summary>
    /// Status of the order confirmation amendment is rejected.
    /// </summary>
    [IsoId("_RMx6NNp-Ed-ak6NoX_4Aeg_1434728868")]
    [DisplayName("Amendment Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntRjctd")]
    #endif
    [IsoXmlTag("AmdmntRjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<ConfirmationRejectedStatus1> AmendmentRejected { get; init; } = new ValueList<ConfirmationRejectedStatus1>(){};
    
    /// <summary>
    /// Status of the order confirmation is accepted or received or sent to next party or there is a communication problem with next party. There is no reason attached.
    /// </summary>
    [IsoId("_RMx6Ndp-Ed-ak6NoX_4Aeg_-1768968796")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderConfirmationStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderConfirmationStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderConfirmationStatus1Code Status { get; init; } 
    #else
    public OrderConfirmationStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the order confirmation.
    /// </summary>
    [IsoId("_RMx6Ntp-Ed-ak6NoX_4Aeg_-1768968036")]
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
    
    /// <summary>
    /// Account information of the individual order confirmation for which the status is given.
    /// </summary>
    [IsoId("_RMx6N9p-Ed-ak6NoX_4Aeg_-1101819003")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument information of the individual order confirmation for which the status is given.
    /// </summary>
    [IsoId("_RMx6ONp-Ed-ak6NoX_4Aeg_-1088890047")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument10? FinancialInstrumentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
