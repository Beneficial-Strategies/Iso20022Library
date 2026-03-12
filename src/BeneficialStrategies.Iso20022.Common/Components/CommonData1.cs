// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data common to all transactions of a data set.
/// </summary>
[IsoId("_TDd13wEcEeCQm6a_G2yO_w_766572248")]
[DisplayName("Common Data")]
public partial record CommonData1
{
    #nullable enable
    
    /// <summary>
    /// Data related to the environment of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_TDm_wAEcEeCQm6a_G2yO_w_1158156455")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public CardPaymentEnvironment5? Environment { get; init; } 
    
    /// <summary>
    /// Data related to the context of the transaction, common to a set of transaction.
    /// </summary>
    [IsoId("_TDm_wQEcEeCQm6a_G2yO_w_1107485762")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public CardPaymentContext3? Context { get; init; } 
    
    /// <summary>
    /// Type of transaction being undertaken for the main service, common to a set of transaction.
    /// </summary>
    [IsoId("_TDm_wgEcEeCQm6a_G2yO_w_1822402550")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public CardPaymentServiceType1Code? TransactionType { get; init; } 
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_TDm_wwEcEeCQm6a_G2yO_w_1186746515")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_TDm_xAEcEeCQm6a_G2yO_w_503290248")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_TDm_xQEcEeCQm6a_G2yO_w_-1530428566")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
    /// </summary>
    [IsoId("_TDm_xgEcEeCQm6a_G2yO_w_201590017")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Currency associated with the set of transaction.
    /// </summary>
    [IsoId("_TDm_xwEcEeCQm6a_G2yO_w_743483095")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; } 
    
    
    #nullable disable
    
}
