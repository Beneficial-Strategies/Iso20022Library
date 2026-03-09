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
/// Result of the verifications performed by the issuer to deliver or decline the authorisation.
/// </summary>
[IsoId("_8MCksR2xEeKyZ4l838zwaQ")]
[DisplayName("Transaction Verification Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionVerificationResult2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Result of an e-commerce authentication process.
    /// </summary>
    [IsoId("_8YFcoR2xEeKyZ4l838zwaQ")]
    [DisplayName("Electronic Commerce Authentication Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncComrcAuthntcnRslt")]
    #endif
    [IsoXmlTag("ElctrncComrcAuthntcnRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? ElectronicCommerceAuthenticationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ElectronicCommerceAuthenticationResult { get; init; } 
    #else
    public System.String? ElectronicCommerceAuthenticationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the printed card security code (CSC) validation.
    /// </summary>
    [IsoId("_8YFcpR2xEeKyZ4l838zwaQ")]
    [DisplayName("CSC Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSCRslt")]
    #endif
    [IsoXmlTag("CSCRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CSCResult1Code? CSCResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CSCResult1Code? CSCResult { get; init; } 
    #else
    public CSCResult1Code? CSCResult { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the cardholder verification address checks on the street number and the postal code.
    /// </summary>
    [IsoId("_8YFcqR2xEeKyZ4l838zwaQ")]
    [DisplayName("Cardholder Address Verification Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrAdrVrfctnRslt")]
    #endif
    [IsoXmlTag("CrdhldrAdrVrfctnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderAddressVerificationResult1Code? CardholderAddressVerificationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderAddressVerificationResult1Code? CardholderAddressVerificationResult { get; init; } 
    #else
    public CardholderAddressVerificationResult1Code? CardholderAddressVerificationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Product code for which the authorisation was declined.
    /// </summary>
    [IsoId("_8YFcrR2xEeKyZ4l838zwaQ")]
    [DisplayName("Declined Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclndPdctCd")]
    #endif
    [IsoXmlTag("DclndPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? DeclinedProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclinedProductCode { get; init; } 
    #else
    public System.String? DeclinedProductCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
