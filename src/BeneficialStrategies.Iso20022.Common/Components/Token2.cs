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
/// Unencrypted sensitive data of a token.
/// </summary>
[IsoId("_vbKOYZF8EeukDPgU2BMkjQ")]
[DisplayName("Token")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Token2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    [IsoId("_vhjxUZF8EeukDPgU2BMkjQ")]
    [DisplayName("Payment Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTkn")]
    #endif
    [IsoXmlTag("PmtTkn")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax19NumericText? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentToken { get; init; } 
    #else
    public System.String? PaymentToken { get; set; } 
    #endif
    
    /// <summary>
    /// Expiry date of the payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_vhjxU5F8EeukDPgU2BMkjQ")]
    [DisplayName("Token Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknXpryDt")]
    #endif
    [IsoXmlTag("TknXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? TokenExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? TokenExpiryDate { get; init; } 
    #else
    public System.UInt16? TokenExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a party requesting a token.
    /// </summary>
    [IsoId("_vhjxVZF8EeukDPgU2BMkjQ")]
    [DisplayName("Token Requestor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknRqstrId")]
    #endif
    [IsoXmlTag("TknRqstrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenRequestorIdentification { get; init; } 
    #else
    public System.String? TokenRequestorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Supporting information for the Token Assurance Method.
    /// </summary>
    [IsoId("_vhjxV5F8EeukDPgU2BMkjQ")]
    [DisplayName("Token Assurance Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncData")]
    #endif
    [IsoXmlTag("TknAssrncData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TokenAssuranceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenAssuranceData { get; init; } 
    #else
    public System.String? TokenAssuranceData { get; set; } 
    #endif
    
    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    [IsoId("_vhjxWZF8EeukDPgU2BMkjQ")]
    [DisplayName("Token Assurance Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncMtd")]
    #endif
    [IsoXmlTag("TknAssrncMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenAssuranceMethod { get; init; } 
    #else
    public System.String? TokenAssuranceMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Original transaction was initiated by Token.
    /// </summary>
    [IsoId("_vhjxW5F8EeukDPgU2BMkjQ")]
    [DisplayName("Token Initiated Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknInittdInd")]
    #endif
    [IsoXmlTag("TknInittdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TokenInitiatedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenInitiatedIndicator { get; init; } 
    #else
    public System.String? TokenInitiatedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Storage location of the token.
    /// </summary>
    [IsoId("_riI4cJx_EeuwYeL1lHu9zw")]
    [DisplayName("Storage Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StorgLctn")]
    #endif
    [IsoXmlTag("StorgLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StorageLocation1Code? StorageLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StorageLocation1Code? StorageLocation { get; init; } 
    #else
    public StorageLocation1Code? StorageLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Other private or national storage location code.
    /// </summary>
    [IsoId("_RjZpEJyAEeuo7tDc4CDHXg")]
    [DisplayName("Other Storage Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrStorgLctn")]
    #endif
    [IsoXmlTag("OthrStorgLctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherStorageLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherStorageLocation { get; init; } 
    #else
    public System.String? OtherStorageLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to protect the token.
    /// </summary>
    [IsoId("_iCA7IJyBEeuo7tDc4CDHXg")]
    [DisplayName("Protection Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtcnMtd")]
    #endif
    [IsoXmlTag("PrtcnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProtectionMethod1Code? ProtectionMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectionMethod1Code? ProtectionMethod { get; init; } 
    #else
    public ProtectionMethod1Code? ProtectionMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Other national or private protection method code.
    /// </summary>
    [IsoId("_oN2LQJyBEeuo7tDc4CDHXg")]
    [DisplayName("Other Protection Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPrtcnMtd")]
    #endif
    [IsoXmlTag("OthrPrtcnMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherProtectionMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherProtectionMethod { get; init; } 
    #else
    public System.String? OtherProtectionMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Additional token data.
    /// </summary>
    [IsoId("_uAZ_wJyBEeuo7tDc4CDHXg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
