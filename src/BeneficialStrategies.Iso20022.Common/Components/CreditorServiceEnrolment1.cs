// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the service details for the creditor enrolment.
/// </summary>
[IsoId("_BcQ8kEWOEempSe_3C1a9EQ")]
[DisplayName("Creditor Service Enrolment")]
public partial record CreditorServiceEnrolment1
{
    #nullable enable
    
    /// <summary>
    /// Start date when the creditor enrolment becomes effective.
    /// </summary>
    [IsoId("_OU4_YEWPEempSe_3C1a9EQ")]
    [DisplayName("Enrolment Start Date")]
    [IsoXmlTag("EnrlmntStartDt")]
    public DateAndDateTime2Choice_? EnrolmentStartDate { get; init; } 
    
    /// <summary>
    /// End date when the creditor enrolment becomes effective.
    /// </summary>
    [IsoId("_OBkcwXFrEemaN4ndAVY1ZQ")]
    [DisplayName("Enrolment End Date")]
    [IsoXmlTag("EnrlmntEndDt")]
    public DateAndDateTime2Choice_? EnrolmentEndDate { get; init; } 
    
    /// <summary>
    /// Provides the details of the visibility of the creditor enrolment as shown to the debtors.
    /// </summary>
    [IsoId("_tZRS4EWOEempSe_3C1a9EQ")]
    [DisplayName("Visibility")]
    [IsoXmlTag("Vsblty")]
    public Visibilty1? Visibility { get; init; } 
    
    /// <summary>
    /// Define the acceptance of activation requests through the scheme. 
    /// Usage: 
    /// When true, it is possible for the debtor to send activation requests through its payment service provider.
    /// When false, it is not possible for the debtor to send activation request through servicing messages. The creditor only accepts activation through another way(s).
    /// </summary>
    [IsoId("_JMynsEWQEempSe_3C1a9EQ")]
    [DisplayName("Service Activation Allowed")]
    [IsoXmlTag("SvcActvtnAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ServiceActivationAllowed { get; init; } 
    
    /// <summary>
    /// Information web page, as provided by the creditor, to which the debtor can be linked for further information (Universal Resource Locator - URL).
    /// </summary>
    [IsoId("_aDISsUWQEempSe_3C1a9EQ")]
    [DisplayName("Service Description Link")]
    [IsoXmlTag("SvcDescLk")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? ServiceDescriptionLink { get; init; } 
    
    /// <summary>
    /// Web page link provided by the Creditor, intended to the Debtors, to proceed to activation when  servicing messages can not be used.
    /// </summary>
    [IsoId("__L-0oUWQEempSe_3C1a9EQ")]
    [DisplayName("Creditor Service Activation Link")]
    [IsoXmlTag("CdtrSvcActvtnLk")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    public IsoMax2048Text? CreditorServiceActivationLink { get; init; } 
    
    
    #nullable disable
    
}
