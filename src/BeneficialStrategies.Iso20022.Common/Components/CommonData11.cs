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
[IsoId("_IdXiYU6dEeyGi9JAv6wq7Q")]
[DisplayName("Common Data")]
public record CommonData11
{
    /// <summary>
    /// Data related to the environment of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_IkYJUU6dEeyGi9JAv6wq7Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment78? Environment { get; init; }

    /// <summary>
    /// Data related to the context of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_IkYJU06dEeyGi9JAv6wq7Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext29? Context { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service, common to a set of transaction.
    /// </summary>
    [IsoId("_IkYJVU6dEeyGi9JAv6wq7Q")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType12Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_IkYJV06dEeyGi9JAv6wq7Q")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType9Code? AdditionalService { get; init; }

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_IkYJWU6dEeyGi9JAv6wq7Q")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_IkYJW06dEeyGi9JAv6wq7Q")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_IkYJXU6dEeyGi9JAv6wq7Q")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Currency associated with the set of transaction.
    /// </summary>
    [IsoId("_IkYJX06dEeyGi9JAv6wq7Q")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }
}
