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
/// Content of the management plan.
/// </summary>
[IsoId("_K7wrYXJsEe299ZbWCkdR_w")]
[DisplayName("Management Plan Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ManagementPlanContent11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_LC_70XJsEe299ZbWCkdR_w")]
    [DisplayName("TM Challenge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMChllng")]
    #endif
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? TMChallenge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? TMChallenge { get; init; } 
    #else
    public System.Byte[]? TMChallenge { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate chain of an asymmetric encryption keys for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_LC_703JsEe299ZbWCkdR_w")]
    [DisplayName("Key Encipherment Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyNcphrmntCert")]
    #endif
    [IsoXmlTag("KeyNcphrmntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? KeyEnciphermentCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? KeyEnciphermentCertificate { get; init; } 
    #else
    public System.Byte[]? KeyEnciphermentCertificate { get; set; } 
    #endif
    
    /// <summary>
    /// Terminal management action to be performed by the point of interaction (POI).
    /// </summary>
    [IsoId("_LC_71XJsEe299ZbWCkdR_w")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    public ValueList<TMSAction11> Action { get; init; } = new ValueList<TMSAction11>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _LC_71XJsEe299ZbWCkdR_w
    
    
    #nullable disable
    
}
