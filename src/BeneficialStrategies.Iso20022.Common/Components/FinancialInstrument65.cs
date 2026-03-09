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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_CXYYCYfuEeevKP8c-ilVhA")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument65
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument65 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument65( SecurityIdentification25Choice_ reqIdentification,TransferType1Code reqTransferType,Quantity43Choice_ reqQuantity )
    {
        Identification = reqIdentification;
        TransferType = reqTransferType;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_CoyRBYfuEeevKP8c-ilVhA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification25Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification25Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_CoyRB4fuEeevKP8c-ilVhA")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_CoyRCYfuEeevKP8c-ilVhA")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the financial instrument is transferred as an asset or as cash.
    /// </summary>
    [IsoId("_CoyRC4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfTp")]
    #endif
    [IsoXmlTag("TrfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferType1Code TransferType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferType1Code TransferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferType1Code TransferType { get; init; } 
    #else
    public TransferType1Code TransferType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_CoyRDYfuEeevKP8c-ilVhA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity43Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity43Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity43Choice_ Quantity { get; init; } 
    #else
    public Quantity43Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("_CoyRD4fuEeevKP8c-ilVhA")]
    [DisplayName("Average Acquisition Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgAcqstnPric")]
    #endif
    [IsoXmlTag("AvrgAcqstnPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    #else
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_CoyREYfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfCcy")]
    #endif
    [IsoXmlTag("TrfCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TransferCurrency { get; init; } 
    #else
    public string? TransferCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_CoyRE4fuEeevKP8c-ilVhA")]
    [DisplayName("Total Book Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlBookVal")]
    #endif
    [IsoXmlTag("TtlBookVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; set; } 
    #endif
    
    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_CoyRFYfuEeevKP8c-ilVhA")]
    [DisplayName("Transferee Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfeeAcct")]
    #endif
    [IsoXmlTag("TrfeeAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account24? TransfereeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account24? TransfereeAccount { get; init; } 
    #else
    public Account24? TransfereeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("_CoyRF4fuEeevKP8c-ilVhA")]
    [DisplayName("Sub Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcctDtls")]
    #endif
    [IsoXmlTag("SubAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SubAccount5? SubAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubAccount5? SubAccountDetails { get; init; } 
    #else
    public SubAccount5? SubAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_CoyRGYfuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Parties Receiving Side Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPtiesRcvgSdDtls")]
    #endif
    [IsoXmlTag("SttlmPtiesRcvgSdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceivingPartiesAndAccount18? SettlementPartiesReceivingSideDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceivingPartiesAndAccount18? SettlementPartiesReceivingSideDetails { get; init; } 
    #else
    public ReceivingPartiesAndAccount18? SettlementPartiesReceivingSideDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_CoyRG4fuEeevKP8c-ilVhA")]
    [DisplayName("Delivering Agent Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgAgtDtls")]
    #endif
    [IsoXmlTag("DlvrgAgtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount156? DeliveringAgentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount156? DeliveringAgentDetails { get; init; } 
    #else
    public PartyIdentificationAndAccount156? DeliveringAgentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_CoyRHYfuEeevKP8c-ilVhA")]
    [DisplayName("Requested Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdSttlmDt")]
    #endif
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RequestedSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RequestedSettlementDate { get; init; } 
    #else
    public System.DateOnly? RequestedSettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
