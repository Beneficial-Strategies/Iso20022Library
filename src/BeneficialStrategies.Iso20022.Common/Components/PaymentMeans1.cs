// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Means by which a payment will be or has been made for settlement purposes.
/// </summary>
[IsoId("_TCRjCAEcEeCQm6a_G2yO_w_-1888332883")]
[DisplayName("Payment Means")]
public partial record PaymentMeans1
{
    #nullable enable
    
    /// <summary>
    /// Type, or nature, of the payment, eg, express payment.
    /// </summary>
    [IsoId("_TCRjCQEcEeCQm6a_G2yO_w_-1949458724")]
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public required PaymentTypeInformation19 PaymentType { get; init; } 
    
    /// <summary>
    /// Transfer method to be used for the transfer.
    /// </summary>
    [IsoId("_TCRjCgEcEeCQm6a_G2yO_w_-563553250")]
    [DisplayName("Payment Method Code")]
    [IsoXmlTag("PmtMtdCd")]
    public required PaymentMethod4Code PaymentMethodCode { get; init; } 
    
    /// <summary>
    /// Creditor financial account of the payee party for this payment means.
    /// </summary>
    [IsoId("_TCRjCwEcEeCQm6a_G2yO_w_319981111")]
    [DisplayName("Payee Creditor Account")]
    [IsoXmlTag("PyeeCdtrAcct")]
    public required CashAccount16 PayeeCreditorAccount { get; init; } 
    
    /// <summary>
    /// Creditor financial institution of the payee party specified for this payment means.
    /// </summary>
    [IsoId("_TCRjDAEcEeCQm6a_G2yO_w_-1893685339")]
    [DisplayName("Payee Financial Institution")]
    [IsoXmlTag("PyeeFI")]
    public required BranchAndFinancialInstitutionIdentification4 PayeeFinancialInstitution { get; init; } 
    
    /// <summary>
    /// Debtor financial account of the payer party for this payment means.
    /// </summary>
    [IsoId("_TCRjDQEcEeCQm6a_G2yO_w_-535212270")]
    [DisplayName("Payer Debtor Account")]
    [IsoXmlTag("PyerDbtrAcct")]
    public CashAccount16? PayerDebtorAccount { get; init; } 
    
    /// <summary>
    /// Debtor financial institution of the payer party specified for this payment means.
    /// </summary>
    [IsoId("_TCRjDgEcEeCQm6a_G2yO_w_1731818407")]
    [DisplayName("Payer Financial Institution")]
    [IsoXmlTag("PyerFI")]
    public BranchAndFinancialInstitutionIdentification4? PayerFinancialInstitution { get; init; } 
    
    
    #nullable disable
    
}
