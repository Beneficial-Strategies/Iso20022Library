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
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_zxUwC-H5Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditorEnrolmentAmendment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specific attributes of the creditor and service enrolment provided by the creditor for its enrolment.
    /// </summary>
    [IsoId("_zyspAeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Creditor Enrolment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrEnrlmnt")]
    #endif
    [IsoXmlTag("CdtrEnrlmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorEnrolment4? CreditorEnrolment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorEnrolment4? CreditorEnrolment { get; init; } 
    #else
    public CreditorEnrolment4? CreditorEnrolment { get; set; } 
    #endif
    
    /// <summary>
    /// Specific attributes requested from the debtor for its activation as specified by the creditor in the creditor enrolment request.
    /// </summary>
    [IsoId("_zyspA-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Activation Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtnData")]
    #endif
    [IsoXmlTag("ActvtnData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorInvoice4? ActivationData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorInvoice4? ActivationData { get; init; } 
    #else
    public CreditorInvoice4? ActivationData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
