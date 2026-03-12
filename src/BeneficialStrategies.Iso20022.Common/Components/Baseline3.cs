// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the commercial details of the underlying transaction.
/// </summary>
[IsoId("_Sq9IZdp-Ed-ak6NoX_4Aeg_-88106768")]
[DisplayName("Baseline")]
public partial record Baseline3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the baseline provided by the submitter.
    /// </summary>
    [IsoId("_Sq9IZtp-Ed-ak6NoX_4Aeg_-88106412")]
    [DisplayName("Submitter Baseline Identification")]
    [IsoXmlTag("SubmitrBaselnId")]
    public required DocumentIdentification1 SubmitterBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the service requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_Sq9IZ9p-Ed-ak6NoX_4Aeg_-88106766")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    public required TradeFinanceService2Code ServiceCode { get; init; } 
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_Sq9IaNp-Ed-ak6NoX_4Aeg_-88106437")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_SrGSUNp-Ed-ak6NoX_4Aeg_-88105957")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_SrGSUdp-Ed-ak6NoX_4Aeg_-88105879")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// Financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_SrGSUtp-Ed-ak6NoX_4Aeg_-88106342")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; } 
    
    /// <summary>
    /// Financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_SrGSU9p-Ed-ak6NoX_4Aeg_-88105802")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; } 
    
    /// <summary>
    /// Financial institution on the buyer&apos;s side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [IsoId("_SrGSVNp-Ed-ak6NoX_4Aeg_-909961174")]
    [DisplayName("Buyer Side Submitting Bank")]
    [IsoXmlTag("BuyrSdSubmitgBk")]
    public BICIdentification1? BuyerSideSubmittingBank { get; init; } 
    
    /// <summary>
    /// Financial institution on the seller&apos;s side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [IsoId("_SrGSVdp-Ed-ak6NoX_4Aeg_-481446980")]
    [DisplayName("Seller Side Submitting Bank")]
    [IsoXmlTag("SellrSdSubmitgBk")]
    public BICIdentification1? SellerSideSubmittingBank { get; init; } 
    
    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [IsoId("_SrGSVtp-Ed-ak6NoX_4Aeg_-88105914")]
    [DisplayName("Bill To")]
    [IsoXmlTag("BllTo")]
    public PartyIdentification26? BillTo { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_SrGSV9p-Ed-ak6NoX_4Aeg_-88105837")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public PartyIdentification26? ShipTo { get; init; } 
    
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [IsoId("_SrGSWNp-Ed-ak6NoX_4Aeg_-88106009")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public PartyIdentification26? Consignee { get; init; } 
    
    /// <summary>
    /// Goods or services that are part of a commercial trade agreement.
    /// </summary>
    [IsoId("_SrGSWdp-Ed-ak6NoX_4Aeg_-88106721")]
    [DisplayName("Goods")]
    [IsoXmlTag("Goods")]
    public required LineItem7 Goods { get; init; } 
    
    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [IsoId("_SrQDUNp-Ed-ak6NoX_4Aeg_-88106377")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public ValueList<PaymentTerms1> PaymentTerms { get; init; } = new ValueList<PaymentTerms1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _SrQDUNp-Ed-ak6NoX_4Aeg_-88106377
    
    /// <summary>
    /// Specifies how the underlying transaction should be settled.
    /// </summary>
    [IsoId("_SrQDUdp-Ed-ak6NoX_4Aeg_-88106689")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public SettlementTerms2? SettlementTerms { get; init; } 
    
    /// <summary>
    /// Specifies the details of the payment obligation between financial institutions in this transaction.
    /// </summary>
    [IsoId("_SrQDUtp-Ed-ak6NoX_4Aeg_491944940")]
    [DisplayName("Payment Obligation")]
    [IsoXmlTag("PmtOblgtn")]
    public PaymentObligation1? PaymentObligation { get; init; } 
    
    /// <summary>
    /// Specifies the latest date on which a data set must be matched with a baseline.
    /// </summary>
    [IsoId("_SrQDU9p-Ed-ak6NoX_4Aeg_879823932")]
    [DisplayName("Latest Match Date")]
    [IsoXmlTag("LatstMtchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LatestMatchDate { get; init; } 
    
    /// <summary>
    /// Specifies that a commercial data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDVNp-Ed-ak6NoX_4Aeg_1421007322")]
    [DisplayName("Commercial Data Set Required")]
    [IsoXmlTag("ComrclDataSetReqrd")]
    public required RequiredSubmission2 CommercialDataSetRequired { get; init; } 
    
    /// <summary>
    /// Specifies that a transport data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDVdp-Ed-ak6NoX_4Aeg_1841207283")]
    [DisplayName("Transport Data Set Required")]
    [IsoXmlTag("TrnsprtDataSetReqrd")]
    public RequiredSubmission2? TransportDataSetRequired { get; init; } 
    
    /// <summary>
    /// Specifies that an insurance data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDVtp-Ed-ak6NoX_4Aeg_1927097202")]
    [DisplayName("Insurance Data Set Required")]
    [IsoXmlTag("InsrncDataSetReqrd")]
    public RequiredSubmission3? InsuranceDataSetRequired { get; init; } 
    
    /// <summary>
    /// Specifies that a certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrQDV9p-Ed-ak6NoX_4Aeg_-1995693519")]
    [DisplayName("Certificate Data Set Required")]
    [IsoXmlTag("CertDataSetReqrd")]
    public RequiredSubmission4? CertificateDataSetRequired { get; init; } 
    
    /// <summary>
    /// Specifies that another type of certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_SrZNQNp-Ed-ak6NoX_4Aeg_-2130617300")]
    [DisplayName("Other Certificate Data Set Required")]
    [IsoXmlTag("OthrCertDataSetReqrd")]
    public RequiredSubmission5? OtherCertificateDataSetRequired { get; init; } 
    
    /// <summary>
    /// Specifies that IntentToPayNotice message(s) are expected as part of this transaction.
    /// </summary>
    [IsoId("_SrZNQdp-Ed-ak6NoX_4Aeg_2027510023")]
    [DisplayName("Intent To Pay Expected")]
    [IsoXmlTag("InttToPayXpctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator IntentToPayExpected { get; init; } 
    
    
    #nullable disable
    
}
