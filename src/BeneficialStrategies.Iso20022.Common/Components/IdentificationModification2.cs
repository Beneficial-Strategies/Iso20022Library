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
/// Provides the details of the identification data that is advised to be modified.
/// </summary>
[IsoId("_tpZdUlkyEeGeoaLUQk__nA_-1518673695")]
[DisplayName("Identification Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IdentificationModification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IdentificationModification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IdentificationModification2( System.String reqIdentification,IdentificationInformation2 reqUpdatedPartyAndAccountIdentification )
    {
        Identification = reqIdentification;
        UpdatedPartyAndAccountIdentification = reqUpdatedPartyAndAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the message.
    /// </summary>
    [IsoId("_tpZdU1kyEeGeoaLUQk__nA_1779221248")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_tpjOUFkyEeGeoaLUQk__nA_-393042130")]
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
    /// Provides updated party and/or account identification information.
    /// </summary>
    [IsoId("_tpjOUVkyEeGeoaLUQk__nA_-849780288")]
    [DisplayName("Updated Party And Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdtdPtyAndAcctId")]
    #endif
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationInformation2 UpdatedPartyAndAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationInformation2 UpdatedPartyAndAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationInformation2 UpdatedPartyAndAccountIdentification { get; init; } 
    #else
    public IdentificationInformation2 UpdatedPartyAndAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information, in free text form, to complement the modification information.
    /// </summary>
    [IsoId("_tpjOUlkyEeGeoaLUQk__nA_-452820477")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
