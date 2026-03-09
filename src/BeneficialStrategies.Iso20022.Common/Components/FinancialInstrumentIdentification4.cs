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
/// Identification of a security.
/// </summary>
[IsoId("_AI9BAZy2Eem54rMzia0iag")]
[DisplayName("Financial Instrument Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentIdentification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentIdentification4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentIdentification4( SecurityIdentification25Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_Acb9s5y2Eem54rMzia0iag")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification25Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification25Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_Acb9tZy2Eem54rMzia0iag")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_Acb9t5y2Eem54rMzia0iag")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Type of security.
    /// </summary>
    [IsoId("_Acb9uZy2Eem54rMzia0iag")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType32Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType32Choice_? ClassificationType { get; init; } 
    #else
    public ClassificationType32Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of security offered in place of a restricted security, for example, common. 
    /// </summary>
    [IsoId("_Acb9vZy2Eem54rMzia0iag")]
    [DisplayName("Alternate Security Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnSctyTp")]
    #endif
    [IsoXmlTag("AltrnSctyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? AlternateSecurityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? AlternateSecurityType { get; init; } 
    #else
    public GenericIdentification1? AlternateSecurityType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
