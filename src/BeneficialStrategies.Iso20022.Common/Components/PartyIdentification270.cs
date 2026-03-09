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
/// Set of elements used to identify a person or an organisation.
/// </summary>
[IsoId("_ArjoiTUDEe2tRf29bleifQ")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification270
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification270 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification270( PartyIdentification246Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_BDF-wzUDEe2tRf29bleifQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification246Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification246Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification246Choice_ Identification { get; init; } 
    #else
    public PartyIdentification246Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Ancillary identification information about the party.
    /// </summary>
    [IsoId("_BDF-xTUDEe2tRf29bleifQ")]
    [DisplayName("Additional Identification Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlIdInf")]
    #endif
    [IsoXmlTag("AddtlIdInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAdditionalIdentification2Choice_? AdditionalIdentificationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAdditionalIdentification2Choice_? AdditionalIdentificationInformation { get; init; } 
    #else
    public PartyAdditionalIdentification2Choice_? AdditionalIdentificationInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
