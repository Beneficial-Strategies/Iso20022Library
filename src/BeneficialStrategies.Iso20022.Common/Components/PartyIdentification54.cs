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
/// Choice of identification of a party. The party can be identified by providing a BIC or a proprietary code.
/// Optionally, the client account number can also be provided.
/// </summary>
[IsoId("_AUCy0NokEeC60axPepSq7g_-1700467990")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification54
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification54 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification54( System.String reqBIC,GenericIdentification29 reqProprietaryIdentification )
    {
        BIC = reqBIC;
        ProprietaryIdentification = reqProprietaryIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_AUMj0NokEeC60axPepSq7g_-1814307056")]
    [DisplayName("BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BIC")]
    #endif
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier BIC { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BIC { get; init; } 
    #else
    public System.String BIC { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_AUMj0dokEeC60axPepSq7g_1597426953")]
    [DisplayName("Proprietary Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtryId")]
    #endif
    [IsoXmlTag("PrtryId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification29 ProprietaryIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification29 ProprietaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification29 ProprietaryIdentification { get; init; } 
    #else
    public GenericIdentification29 ProprietaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a party with its name and address in free text.
    /// </summary>
    [IsoId("_AUMj0tokEeC60axPepSq7g_1483587887")]
    [DisplayName("Name And Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndAdr")]
    #endif
    [IsoXmlTag("NmAndAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress13? NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress13? NameAndAddress { get; init; } 
    #else
    public NameAndAddress13? NameAndAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
