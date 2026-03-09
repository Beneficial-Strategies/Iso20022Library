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
/// Parameters associated to a cryptographic algorithm.
/// </summary>
[IsoId("_Sw--tQEcEeCQm6a_G2yO_w_1068010819")]
[DisplayName("Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Parameter1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Initialisation vector of a cipher block chaining (CBC) mode encryption.
    /// </summary>
    [IsoId("_Sw--tgEcEeCQm6a_G2yO_w_498114806")]
    [DisplayName("Initialisation Vector")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlstnVctr")]
    #endif
    [IsoXmlTag("InitlstnVctr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Binary? InitialisationVector { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? InitialisationVector { get; init; } 
    #else
    public System.Byte[]? InitialisationVector { get; set; } 
    #endif
    
    
    #nullable disable
    
}
