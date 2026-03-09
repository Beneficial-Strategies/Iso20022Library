// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Means by which a payment will be or has been made for settlement purposes.
/// </summary>
[IsoId("_TCRjCAEcEeCQm6a_G2yO_w_-1888332883")]
[DisplayName("Payment Means")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentMeans1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentMeans1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentMeans1( PaymentTypeInformation19 reqPaymentType,PaymentMethod4Code reqPaymentMethodCode,CashAccount16 reqPayeeCreditorAccount,BranchAndFinancialInstitutionIdentification4 reqPayeeFinancialInstitution )
    {
        PaymentType = reqPaymentType;
        PaymentMethodCode = reqPaymentMethodCode;
        PayeeCreditorAccount = reqPayeeCreditorAccount;
        PayeeFinancialInstitution = reqPayeeFinancialInstitution;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type, or nature, of the payment, eg, express payment.
    /// </summary>
    [IsoId("_TCRjCQEcEeCQm6a_G2yO_w_-1949458724")]
    [DisplayName("Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTp")]
    #endif
    [IsoXmlTag("PmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentTypeInformation19 PaymentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentTypeInformation19 PaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation19 PaymentType { get; init; } 
    #else
    public PaymentTypeInformation19 PaymentType { get; set; } 
    #endif
    
    /// <summary>
    /// Transfer method to be used for the transfer.
    /// </summary>
    [IsoId("_TCRjCgEcEeCQm6a_G2yO_w_-563553250")]
    [DisplayName("Payment Method Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtdCd")]
    #endif
    [IsoXmlTag("PmtMtdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentMethod4Code PaymentMethodCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentMethod4Code PaymentMethodCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMethod4Code PaymentMethodCode { get; init; } 
    #else
    public PaymentMethod4Code PaymentMethodCode { get; set; } 
    #endif
    
    /// <summary>
    /// Creditor financial account of the payee party for this payment means.
    /// </summary>
    [IsoId("_TCRjCwEcEeCQm6a_G2yO_w_319981111")]
    [DisplayName("Payee Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyeeCdtrAcct")]
    #endif
    [IsoXmlTag("PyeeCdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount16 PayeeCreditorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount16 PayeeCreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16 PayeeCreditorAccount { get; init; } 
    #else
    public CashAccount16 PayeeCreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Creditor financial institution of the payee party specified for this payment means.
    /// </summary>
    [IsoId("_TCRjDAEcEeCQm6a_G2yO_w_-1893685339")]
    [DisplayName("Payee Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyeeFI")]
    #endif
    [IsoXmlTag("PyeeFI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification4 PayeeFinancialInstitution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification4 PayeeFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4 PayeeFinancialInstitution { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4 PayeeFinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Debtor financial account of the payer party for this payment means.
    /// </summary>
    [IsoId("_TCRjDQEcEeCQm6a_G2yO_w_-535212270")]
    [DisplayName("Payer Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyerDbtrAcct")]
    #endif
    [IsoXmlTag("PyerDbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? PayerDebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? PayerDebtorAccount { get; init; } 
    #else
    public CashAccount16? PayerDebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Debtor financial institution of the payer party specified for this payment means.
    /// </summary>
    [IsoId("_TCRjDgEcEeCQm6a_G2yO_w_1731818407")]
    [DisplayName("Payer Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyerFI")]
    #endif
    [IsoXmlTag("PyerFI")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? PayerFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? PayerFinancialInstitution { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? PayerFinancialInstitution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
