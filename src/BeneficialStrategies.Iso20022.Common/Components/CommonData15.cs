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
[IsoId("_B9fCMbX5EfCUZfsQO4rYeA")]
[DisplayName("Common Data15")]
public record CommonData15
{
    /// <summary>
    /// Data related to the environment of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_B-a2VbX5EfCUZfsQO4rYeA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment82? Environment { get; init; }

    /// <summary>
    /// Data related to the context of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_B-a2W7X5EfCUZfsQO4rYeA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public PaymentContext30? Context { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service, common to a set of transaction.
    /// </summary>
    [IsoId("_B-a2YbX5EfCUZfsQO4rYeA")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType12Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_B-a2Z7X5EfCUZfsQO4rYeA")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_B-a2bbX5EfCUZfsQO4rYeA")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType15Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_B-a2c7X5EfCUZfsQO4rYeA")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_B-a2ebX5EfCUZfsQO4rYeA")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Currency associated with the set of transaction.
    /// </summary>
    [IsoId("_B-a2f7X5EfCUZfsQO4rYeA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }
}
