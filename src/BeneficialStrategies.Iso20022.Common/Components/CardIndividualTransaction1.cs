// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Individual card transaction entry details.
/// </summary>
[IsoId("_t58awlkyEeGeoaLUQk__nA_-58511897")]
[DisplayName("Card Individual Transaction")]
public record CardIndividualTransaction1
{
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_t58aw1kyEeGeoaLUQk__nA_-877465578")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType2Code? AdditionalService { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_t58axFkyEeGeoaLUQk__nA_95506098")]
    [DisplayName("Transaction Category")]
    [IsoXmlTag("TxCtgy")]
    public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; }

    /// <summary>
    /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_t6FksFkyEeGeoaLUQk__nA_1800136738")]
    [DisplayName("Sale Reconciliation Identification")]
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReconciliationIdentification { get; init; }

    /// <summary>
    /// Unique reference of the sales as provided by the merchant.
    /// </summary>
    [IsoId("_t6FksVkyEeGeoaLUQk__nA_882698409")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceNumber { get; init; }

    /// <summary>
    /// Sequential number of the card transaction, as assigned by the POI (Point of Interaction). |Usage: The sequential number is increased incrementally for each transaction.
    /// </summary>
    [IsoId("_t6FkslkyEeGeoaLUQk__nA_1131399274")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SequenceNumber { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_t6Fks1kyEeGeoaLUQk__nA_588414190")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifier1? TransactionIdentification { get; init; }

    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_t6FktFkyEeGeoaLUQk__nA_-807094894")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public Product2? Product { get; init; }

    /// <summary>
    /// Date when the deposit was validated by the financial institution that collected the cash.
    /// </summary>
    [IsoId("_t6PVsFkyEeGeoaLUQk__nA_1719363359")]
    [DisplayName("Validation Date")]
    [IsoXmlTag("VldtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidationDate { get; init; }

    /// <summary>
    /// Sequential number of the validation of the cash deposit.
    /// Usage: The sequential number is increased incrementally for each transaction.
    /// </summary>
    [IsoId("_t6PVsVkyEeGeoaLUQk__nA_-667251474")]
    [DisplayName("Validation Sequence Number")]
    [IsoXmlTag("VldtnSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ValidationSequenceNumber { get; init; }
}
