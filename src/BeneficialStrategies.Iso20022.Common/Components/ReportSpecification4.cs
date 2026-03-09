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
/// Specifies the parameters for which a transaction report must be generated.
/// </summary>
[IsoId("_PcRl4dp-Ed-ak6NoX_4Aeg_1375759875")]
[DisplayName("Report Specification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReportSpecification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to a transaction, for which the matching application must generate a report.
    /// </summary>
    [IsoId("_PcRl4tp-Ed-ak6NoX_4Aeg_1375759877")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentification { get; init; } 
    #else
    public System.String? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_PcRl49p-Ed-ak6NoX_4Aeg_-9261587")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionStatus4? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4? TransactionStatus { get; init; } 
    #else
    public TransactionStatus4? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the identification of a transaction of a user, for which the matching application must generate a report.
    /// </summary>
    [IsoId("_PcRl5Np-Ed-ak6NoX_4Aeg_1375760307")]
    [DisplayName("Submitter Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitrTxRef")]
    #endif
    [IsoXmlTag("SubmitrTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubmitterTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubmitterTransactionReference { get; init; } 
    #else
    public System.String? SubmitterTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a list of entities for which the matching application must generate a report.
    /// </summary>
    [IsoId("_PcRl5dp-Ed-ak6NoX_4Aeg_1383145049")]
    [DisplayName("Entities To Be Reported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NttiesToBeRptd")]
    #endif
    [IsoXmlTag("NttiesToBeRptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? EntitiesToBeReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? EntitiesToBeReported { get; init; } 
    #else
    public BICIdentification1? EntitiesToBeReported { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that is the counterparty to the trade transaction.
    /// </summary>
    [IsoId("_PcRl5tp-Ed-ak6NoX_4Aeg_1383144994")]
    [DisplayName("Correspondent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Crspdt")]
    #endif
    [IsoXmlTag("Crspdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? Correspondent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? Correspondent { get; init; } 
    #else
    public BICIdentification1? Correspondent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that is a data set submitting bank to the transaction.
    /// </summary>
    [IsoId("_PcRl59p-Ed-ak6NoX_4Aeg_-1521300604")]
    [DisplayName("Submitting Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgBk")]
    #endif
    [IsoXmlTag("SubmitgBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? SubmittingBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? SubmittingBank { get; init; } 
    #else
    public BICIdentification1? SubmittingBank { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that is an obligor bank to the transaction.
    /// </summary>
    [IsoId("_PcRl6Np-Ed-ak6NoX_4Aeg_-1689381272")]
    [DisplayName("Obligor Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgrBk")]
    #endif
    [IsoXmlTag("OblgrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? ObligorBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? ObligorBank { get; init; } 
    #else
    public BICIdentification1? ObligorBank { get; set; } 
    #endif
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pcav0Np-Ed-ak6NoX_4Aeg_1383145194")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification28? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification28? Buyer { get; init; } 
    #else
    public PartyIdentification28? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pcav0dp-Ed-ak6NoX_4Aeg_1383145172")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification28? Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification28? Seller { get; init; } 
    #else
    public PartyIdentification28? Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the buyer.
    /// </summary>
    [IsoId("_Pcav0tp-Ed-ak6NoX_4Aeg_1375759937")]
    [DisplayName("Buyer Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrCtry")]
    #endif
    [IsoXmlTag("BuyrCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? BuyerCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BuyerCountry { get; init; } 
    #else
    public string? BuyerCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the seller.
    /// </summary>
    [IsoId("_Pcav09p-Ed-ak6NoX_4Aeg_1375759967")]
    [DisplayName("Seller Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrCtry")]
    #endif
    [IsoXmlTag("SellrCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? SellerCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SellerCountry { get; init; } 
    #else
    public string? SellerCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the financial institution which is the other party to the trade.
    /// </summary>
    [IsoId("_Pcav1Np-Ed-ak6NoX_4Aeg_1375760245")]
    [DisplayName("Correspondent Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrspdtCtry")]
    #endif
    [IsoXmlTag("CrspdtCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CorrespondentCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CorrespondentCountry { get; init; } 
    #else
    public string? CorrespondentCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a pending request for action for which the matching application must generate a report.
    /// </summary>
    [IsoId("_Pcav1dp-Ed-ak6NoX_4Aeg_1383145110")]
    [DisplayName("Pending Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgReqForActn")]
    #endif
    [IsoXmlTag("PdgReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity1? PendingRequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity1? PendingRequestForAction { get; init; } 
    #else
    public PendingActivity1? PendingRequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
