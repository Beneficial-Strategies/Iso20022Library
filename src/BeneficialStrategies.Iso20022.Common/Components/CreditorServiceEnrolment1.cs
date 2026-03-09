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
/// Specifies the service details for the creditor enrolment.
/// </summary>
[IsoId("_BcQ8kEWOEempSe_3C1a9EQ")]
[DisplayName("Creditor Service Enrolment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditorServiceEnrolment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditorServiceEnrolment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditorServiceEnrolment1( System.String reqServiceActivationAllowed )
    {
        ServiceActivationAllowed = reqServiceActivationAllowed;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Start date when the creditor enrolment becomes effective.
    /// </summary>
    [IsoId("_OU4_YEWPEempSe_3C1a9EQ")]
    [DisplayName("Enrolment Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EnrlmntStartDt")]
    #endif
    [IsoXmlTag("EnrlmntStartDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EnrolmentStartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EnrolmentStartDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EnrolmentStartDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date when the creditor enrolment becomes effective.
    /// </summary>
    [IsoId("_OBkcwXFrEemaN4ndAVY1ZQ")]
    [DisplayName("Enrolment End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EnrlmntEndDt")]
    #endif
    [IsoXmlTag("EnrlmntEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EnrolmentEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EnrolmentEndDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EnrolmentEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the visibility of the creditor enrolment as shown to the debtors.
    /// </summary>
    [IsoId("_tZRS4EWOEempSe_3C1a9EQ")]
    [DisplayName("Visibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vsblty")]
    #endif
    [IsoXmlTag("Vsblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Visibilty1? Visibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Visibilty1? Visibility { get; init; } 
    #else
    public Visibilty1? Visibility { get; set; } 
    #endif
    
    /// <summary>
    /// Define the acceptance of activation requests through the scheme. 
    /// Usage: 
    /// When true, it is possible for the debtor to send activation requests through its payment service provider.
    /// When false, it is not possible for the debtor to send activation request through servicing messages. The creditor only accepts activation through another way(s).
    /// </summary>
    [IsoId("_JMynsEWQEempSe_3C1a9EQ")]
    [DisplayName("Service Activation Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcActvtnAllwd")]
    #endif
    [IsoXmlTag("SvcActvtnAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator ServiceActivationAllowed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ServiceActivationAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ServiceActivationAllowed { get; init; } 
    #else
    public System.String ServiceActivationAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Information web page, as provided by the creditor, to which the debtor can be linked for further information (Universal Resource Locator - URL).
    /// </summary>
    [IsoId("_aDISsUWQEempSe_3C1a9EQ")]
    [DisplayName("Service Description Link")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcDescLk")]
    #endif
    [IsoXmlTag("SvcDescLk")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? ServiceDescriptionLink { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceDescriptionLink { get; init; } 
    #else
    public System.String? ServiceDescriptionLink { get; set; } 
    #endif
    
    /// <summary>
    /// Web page link provided by the Creditor, intended to the Debtors, to proceed to activation when  servicing messages can not be used.
    /// </summary>
    [IsoId("__L-0oUWQEempSe_3C1a9EQ")]
    [DisplayName("Creditor Service Activation Link")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrSvcActvtnLk")]
    #endif
    [IsoXmlTag("CdtrSvcActvtnLk")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? CreditorServiceActivationLink { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditorServiceActivationLink { get; init; } 
    #else
    public System.String? CreditorServiceActivationLink { get; set; } 
    #endif
    
    
    #nullable disable
    
}
