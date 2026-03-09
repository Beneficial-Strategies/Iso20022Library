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
/// Specifies the central counterparty clearing time.
/// </summary>
[IsoId("_jg-jkZQPEeiok48Eh9lW9Q")]
[DisplayName("Clearing Party And Time")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingPartyAndTime8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// In the case of a contract that has been cleared, the unique code for the CCP that has cleared the contract.
    /// </summary>
    [IsoId("_jtjnA5QPEeiok48Eh9lW9Q")]
    [DisplayName("CCP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCP")]
    #endif
    [IsoXmlTag("CCP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? CCP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? CCP { get; init; } 
    #else
    public OrganisationIdentification9Choice_? CCP { get; set; } 
    #endif
    
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    [IsoId("_jtjnBZQPEeiok48Eh9lW9Q")]
    [DisplayName("Clearing Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtTm")]
    #endif
    [IsoXmlTag("ClrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ClearingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ClearingDateTime { get; init; } 
    #else
    public System.DateTime? ClearingDateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
