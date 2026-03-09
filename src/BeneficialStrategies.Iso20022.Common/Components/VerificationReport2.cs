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
/// Provides the details of the verification of identification data for which verification was requested.
/// </summary>
[IsoId("_tp2JQVkyEeGeoaLUQk__nA_-1657016641")]
[DisplayName("Verification Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VerificationReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VerificationReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VerificationReport2( System.String reqOriginalIdentification,System.String reqVerification )
    {
        OriginalIdentification = reqOriginalIdentification;
        Verification = reqVerification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the original message.
    /// </summary>
    [IsoId("_tp2JQlkyEeGeoaLUQk__nA_1640878302")]
    [DisplayName("Original Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlId")]
    #endif
    [IsoXmlTag("OrgnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalIdentification { get; init; } 
    #else
    public System.String OriginalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the party and/or account information received is correct.
    /// </summary>
    [IsoId("_tp2JQ1kyEeGeoaLUQk__nA_529966883")]
    [DisplayName("Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrfctn")]
    #endif
    [IsoXmlTag("Vrfctn")]
    [IsoSimpleType(IsoSimpleType.IdentificationVerificationIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoIdentificationVerificationIndicator Verification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Verification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Verification { get; init; } 
    #else
    public System.String Verification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason why the verified identification information is incorrect.
    /// </summary>
    [IsoId("_tp_6QFkyEeGeoaLUQk__nA_-1642296495")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VerificationReason1Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationReason1Choice_? Reason { get; init; } 
    #else
    public VerificationReason1Choice_? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_tp_6QVkyEeGeoaLUQk__nA_1037398288")]
    [DisplayName("Original Party And Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPtyAndAcctId")]
    #endif
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IdentificationInformation2? OriginalPartyAndAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationInformation2? OriginalPartyAndAccountIdentification { get; init; } 
    #else
    public IdentificationInformation2? OriginalPartyAndAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides party and/or account identification information.
    /// </summary>
    [IsoId("_tp_6QlkyEeGeoaLUQk__nA_-1839979705")]
    [DisplayName("Updated Party And Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdtdPtyAndAcctId")]
    #endif
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IdentificationInformation2? UpdatedPartyAndAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationInformation2? UpdatedPartyAndAccountIdentification { get; init; } 
    #else
    public IdentificationInformation2? UpdatedPartyAndAccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
