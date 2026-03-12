// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the parameters for which a transaction report must be generated.
/// </summary>
[IsoId("_PcRl4dp-Ed-ak6NoX_4Aeg_1375759875")]
[DisplayName("Report Specification")]
public partial record ReportSpecification4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to a transaction, for which the matching application must generate a report.
    /// </summary>
    [IsoId("_PcRl4tp-Ed-ak6NoX_4Aeg_1375759877")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_PcRl49p-Ed-ak6NoX_4Aeg_-9261587")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionStatus4? TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the identification of a transaction of a user, for which the matching application must generate a report.
    /// </summary>
    [IsoId("_PcRl5Np-Ed-ak6NoX_4Aeg_1375760307")]
    [DisplayName("Submitter Transaction Reference")]
    [IsoXmlTag("SubmitrTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubmitterTransactionReference { get; init; } 
    
    /// <summary>
    /// Specifies a list of entities for which the matching application must generate a report.
    /// </summary>
    [IsoId("_PcRl5dp-Ed-ak6NoX_4Aeg_1383145049")]
    [DisplayName("Entities To Be Reported")]
    [IsoXmlTag("NttiesToBeRptd")]
    public BICIdentification1? EntitiesToBeReported { get; init; } 
    
    /// <summary>
    /// Financial institution that is the counterparty to the trade transaction.
    /// </summary>
    [IsoId("_PcRl5tp-Ed-ak6NoX_4Aeg_1383144994")]
    [DisplayName("Correspondent")]
    [IsoXmlTag("Crspdt")]
    public BICIdentification1? Correspondent { get; init; } 
    
    /// <summary>
    /// Financial institution that is a data set submitting bank to the transaction.
    /// </summary>
    [IsoId("_PcRl59p-Ed-ak6NoX_4Aeg_-1521300604")]
    [DisplayName("Submitting Bank")]
    [IsoXmlTag("SubmitgBk")]
    public BICIdentification1? SubmittingBank { get; init; } 
    
    /// <summary>
    /// Financial institution that is an obligor bank to the transaction.
    /// </summary>
    [IsoId("_PcRl6Np-Ed-ak6NoX_4Aeg_-1689381272")]
    [DisplayName("Obligor Bank")]
    [IsoXmlTag("OblgrBk")]
    public BICIdentification1? ObligorBank { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pcav0Np-Ed-ak6NoX_4Aeg_1383145194")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public PartyIdentification28? Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pcav0dp-Ed-ak6NoX_4Aeg_1383145172")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public PartyIdentification28? Seller { get; init; } 
    
    /// <summary>
    /// Country of the buyer.
    /// </summary>
    [IsoId("_Pcav0tp-Ed-ak6NoX_4Aeg_1375759937")]
    [DisplayName("Buyer Country")]
    [IsoXmlTag("BuyrCtry")]
    public CountryCode? BuyerCountry { get; init; } 
    
    /// <summary>
    /// Country of the seller.
    /// </summary>
    [IsoId("_Pcav09p-Ed-ak6NoX_4Aeg_1375759967")]
    [DisplayName("Seller Country")]
    [IsoXmlTag("SellrCtry")]
    public CountryCode? SellerCountry { get; init; } 
    
    /// <summary>
    /// Country of the financial institution which is the other party to the trade.
    /// </summary>
    [IsoId("_Pcav1Np-Ed-ak6NoX_4Aeg_1375760245")]
    [DisplayName("Correspondent Country")]
    [IsoXmlTag("CrspdtCtry")]
    public CountryCode? CorrespondentCountry { get; init; } 
    
    /// <summary>
    /// Specifies a pending request for action for which the matching application must generate a report.
    /// </summary>
    [IsoId("_Pcav1dp-Ed-ak6NoX_4Aeg_1383145110")]
    [DisplayName("Pending Request For Action")]
    [IsoXmlTag("PdgReqForActn")]
    public PendingActivity1? PendingRequestForAction { get; init; } 
    
    
    #nullable disable
    
}
