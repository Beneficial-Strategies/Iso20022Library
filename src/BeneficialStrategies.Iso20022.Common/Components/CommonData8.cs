// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data common to all transactions of a data set.
/// </summary>
[IsoId("_aMV5sfSqEeidY7TA5tbHZg")]
[DisplayName("Common Data")]
public record CommonData8
{
    /// <summary>
    /// Data related to the environment of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_aWoeIfSqEeidY7TA5tbHZg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment70? Environment { get; init; }

    /// <summary>
    /// Data related to the context of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_aWoeI_SqEeidY7TA5tbHZg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext27? Context { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service, common to a set of transaction.
    /// </summary>
    [IsoId("_aWoeJfSqEeidY7TA5tbHZg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType12Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_aWoeJ_SqEeidY7TA5tbHZg")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_aWoeKfSqEeidY7TA5tbHZg")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_aWoeK_SqEeidY7TA5tbHZg")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_aWoeLfSqEeidY7TA5tbHZg")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Currency associated with the set of transaction.
    /// </summary>
    [IsoId("_aWoeL_SqEeidY7TA5tbHZg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }
}
