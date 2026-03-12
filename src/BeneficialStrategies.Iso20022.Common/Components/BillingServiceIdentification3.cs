// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the service to be billed.
/// </summary>
[IsoId("_bBKr1Tq2EeWZFYSPlduMhw")]
[DisplayName("Billing Service Identification")]
public partial record BillingServiceIdentification3
{
    #nullable enable
    
    /// <summary>
    /// Financial institution&apos;s own, internal service identification code, different from the common code.|Usage: The financial institution own code is used to uniquely identify the service within the financial institution.
    /// </summary>
    [IsoId("_bICI0Tq2EeWZFYSPlduMhw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Defines the financial institution sub-service identification if the financial institution service identification code is used for more than one service.
    /// </summary>
    [IsoId("_bICI0zq2EeWZFYSPlduMhw")]
    [DisplayName("Sub Service")]
    [IsoXmlTag("SubSvc")]
    public BillingSubServiceIdentification1? SubService { get; init; } 
    
    /// <summary>
    /// Specifies further details to describe the financial institution service description, which is not the standard description related to the common code.
    /// </summary>
    [IsoId("_bICI1Tq2EeWZFYSPlduMhw")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Description { get; init; } 
    
    /// <summary>
    /// Standard reference code used to uniquely identify this service across financial institutions. This is not the financial institution’s internal bank service identification.
    /// </summary>
    [IsoId("_bICI1zq2EeWZFYSPlduMhw")]
    [DisplayName("Common Code")]
    [IsoXmlTag("CmonCd")]
    public BillingServiceCommonIdentification1? CommonCode { get; init; } 
    
    /// <summary>
    /// Full identification of the type of underlying transaction resulting in an service billing.
    /// </summary>
    [IsoId("_if01wTq2EeWZFYSPlduMhw")]
    [DisplayName("Bank Transaction Code")]
    [IsoXmlTag("BkTxCd")]
    public BankTransactionCodeStructure4? BankTransactionCode { get; init; } 
    
    /// <summary>
    /// Type used to classify or organise different services by common characteristics.
    /// </summary>
    [IsoId("_bICI2Tq2EeWZFYSPlduMhw")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    [IsoSimpleType(IsoSimpleType.Max12Text)]
    [StringLength(maximumLength: 12 ,MinimumLength = 1)]
    public IsoMax12Text? ServiceType { get; init; } 
    
    
    #nullable disable
    
}
