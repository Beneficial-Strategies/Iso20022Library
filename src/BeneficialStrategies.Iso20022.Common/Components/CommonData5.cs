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
[IsoId("_REJZUY3JEeWjkqXgn_0Imw")]
[DisplayName("Common Data")]
public record CommonData5
{
    /// <summary>
    /// Data related to the environment of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_RPBzoY3JEeWjkqXgn_0Imw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment51? Environment { get; init; }

    /// <summary>
    /// Data related to the context of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_RPBzo43JEeWjkqXgn_0Imw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext18? Context { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service, common to a set of transaction.
    /// </summary>
    [IsoId("_RPBzpY3JEeWjkqXgn_0Imw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType5Code? TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_RPBzp43JEeWjkqXgn_0Imw")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType9Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_RPBzqY3JEeWjkqXgn_0Imw")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_RPBzq43JEeWjkqXgn_0Imw")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_RPBzrY3JEeWjkqXgn_0Imw")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }

    /// <summary>
    /// Currency associated with the set of transaction.
    /// </summary>
    [IsoId("_RPBzr43JEeWjkqXgn_0Imw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }
}
