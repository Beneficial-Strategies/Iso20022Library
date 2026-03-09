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
/// Identification of a person, or a non-financial institution.
/// </summary>
[IsoId("_Pb-D5Np-Ed-ak6NoX_4Aeg_196982310")]
[DisplayName("Party Identification And Contact Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndContactInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationAndContactInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationAndContactInformation1( PartyIdentification8 reqPartyIdentification )
    {
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Pb-D5dp-Ed-ak6NoX_4Aeg_-41534987")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification8 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification8 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8 PartyIdentification { get; init; } 
    #else
    public PartyIdentification8 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information needed to contact a physical person related to the party, such as name, phone number, email address.
    /// </summary>
    [IsoId("_Pb-D5tp-Ed-ak6NoX_4Aeg_975951300")]
    [DisplayName("Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctInf")]
    #endif
    [IsoXmlTag("CtctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactIdentification1? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification1? ContactInformation { get; init; } 
    #else
    public ContactIdentification1? ContactInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
