// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the commercial details of the underlying transaction.
/// </summary>
[IsoId("_Ym19EdM7EeK-v49t1oWkNA")]
[DisplayName("Baseline")]
public record Baseline4
{
    /// <summary>
    /// Identifies the baseline provided by the submitter.
    /// </summary>
    [IsoId("_ZDAUodM7EeK-v49t1oWkNA")]
    [DisplayName("Submitter Baseline Identification")]
    [IsoXmlTag("SubmitrBaselnId")]
    public required DocumentIdentification1 SubmitterBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the service requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_ZDAUo9M7EeK-v49t1oWkNA")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    public required TradeFinanceService2Code ServiceCode { get; init; }

    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_ZDAUpdM7EeK-v49t1oWkNA")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; }

    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_ZDAUp9M7EeK-v49t1oWkNA")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; }

    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_ZDAUqdM7EeK-v49t1oWkNA")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; }

    /// <summary>
    /// Financial institution of the buyer, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_ZDAUq9M7EeK-v49t1oWkNA")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; }

    /// <summary>
    /// Financial institution of the seller, uniquely identified by its BIC.
    /// </summary>
    [IsoId("_ZDAUrdM7EeK-v49t1oWkNA")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; }

    /// <summary>
    /// Financial institution on the buyer&apos;s side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [IsoId("_ZDAUr9M7EeK-v49t1oWkNA")]
    [DisplayName("Buyer Side Submitting Bank")]
    [IsoXmlTag("BuyrSdSubmitgBk")]
    public ValueList<BICIdentification1> BuyerSideSubmittingBank { get; init; } = [];

    /// <summary>
    /// Financial institution on the seller&apos;s side, uniquely identified by its BIC. As part of the transaction, it may submit data sets.
    /// </summary>
    [IsoId("_ZDAUsdM7EeK-v49t1oWkNA")]
    [DisplayName("Seller Side Submitting Bank")]
    [IsoXmlTag("SellrSdSubmitgBk")]
    public ValueList<BICIdentification1> SellerSideSubmittingBank { get; init; } = [];

    /// <summary>
    /// Party to be invoiced for the purchase.
    /// </summary>
    [IsoId("_ZDAUs9M7EeK-v49t1oWkNA")]
    [DisplayName("Bill To")]
    [IsoXmlTag("BllTo")]
    public PartyIdentification26? BillTo { get; init; }

    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_ZDAUtdM7EeK-v49t1oWkNA")]
    [DisplayName("Ship To")]
    [IsoXmlTag("ShipTo")]
    public PartyIdentification26? ShipTo { get; init; }

    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [IsoId("_ZDAUt9M7EeK-v49t1oWkNA")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public PartyIdentification26? Consignee { get; init; }

    /// <summary>
    /// Goods or services that are part of a commercial trade agreement.
    /// </summary>
    [IsoId("_ZDAUudM7EeK-v49t1oWkNA")]
    [DisplayName("Goods")]
    [IsoXmlTag("Goods")]
    public required LineItem11 Goods { get; init; }

    /// <summary>
    /// Specifies the payment terms by means of a code and a limit in time.
    /// </summary>
    [IsoId("_ZDAUu9M7EeK-v49t1oWkNA")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public ValueList<PaymentTerms5> PaymentTerms { get; init; } = [];

    // ID for the above is _ZDAUu9M7EeK-v49t1oWkNA

    /// <summary>
    /// Specifies how the underlying transaction should be settled.
    /// </summary>
    [IsoId("_ZDAUvdM7EeK-v49t1oWkNA")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public SettlementTerms3? SettlementTerms { get; init; }

    /// <summary>
    /// Specifies the details of the payment obligation between financial institutions in this transaction.
    /// </summary>
    [IsoId("_ZDAUv9M7EeK-v49t1oWkNA")]
    [DisplayName("Payment Obligation")]
    [IsoXmlTag("PmtOblgtn")]
    public ValueList<PaymentObligation2> PaymentObligation { get; init; } = [];

    /// <summary>
    /// Specifies the latest date on which a data set must be matched with a baseline.
    /// </summary>
    [IsoId("_ZDAUwdM7EeK-v49t1oWkNA")]
    [DisplayName("Latest Match Date")]
    [IsoXmlTag("LatstMtchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LatestMatchDate { get; init; }

    /// <summary>
    /// Specifies that a commercial data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_ZDAUw9M7EeK-v49t1oWkNA")]
    [DisplayName("Commercial Data Set Required")]
    [IsoXmlTag("ComrclDataSetReqrd")]
    public required RequiredSubmission2 CommercialDataSetRequired { get; init; }

    /// <summary>
    /// Specifies that a transport data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_ZDAUxdM7EeK-v49t1oWkNA")]
    [DisplayName("Transport Data Set Required")]
    [IsoXmlTag("TrnsprtDataSetReqrd")]
    public RequiredSubmission2? TransportDataSetRequired { get; init; }

    /// <summary>
    /// Specifies that an insurance data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_ZDAUx9M7EeK-v49t1oWkNA")]
    [DisplayName("Insurance Data Set Required")]
    [IsoXmlTag("InsrncDataSetReqrd")]
    public RequiredSubmission3? InsuranceDataSetRequired { get; init; }

    /// <summary>
    /// Specifies that a certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_ZDAUydM7EeK-v49t1oWkNA")]
    [DisplayName("Certificate Data Set Required")]
    [IsoXmlTag("CertDataSetReqrd")]
    public ValueList<RequiredSubmission4> CertificateDataSetRequired { get; init; } = [];

    /// <summary>
    /// Specifies that another type of certificate data set is required for each shipment part of the transaction.
    /// </summary>
    [IsoId("_ZDAUy9M7EeK-v49t1oWkNA")]
    [DisplayName("Other Certificate Data Set Required")]
    [IsoXmlTag("OthrCertDataSetReqrd")]
    public ValueList<RequiredSubmission5> OtherCertificateDataSetRequired { get; init; } = [];

    /// <summary>
    /// Specifies that IntentToPayNotice message(s) are expected as part of this transaction.
    /// </summary>
    [IsoId("_ZDAUzdM7EeK-v49t1oWkNA")]
    [DisplayName("Intent To Pay Expected")]
    [IsoXmlTag("InttToPayXpctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator IntentToPayExpected { get; init; }
}
