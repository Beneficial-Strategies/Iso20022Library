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
/// Contains information about the contact responsible for the transaction identified in the message.
/// </summary>
[IsoId("_QDnStdp-Ed-ak6NoX_4Aeg_-2124213178")]
[DisplayName("Contact Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContactPerson1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContactPerson1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContactPerson1( ContactIdentification4 reqContactPerson )
    {
        ContactPerson = reqContactPerson;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides additional information regarding the party, eg, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_QDnSttp-Ed-ak6NoX_4Aeg_946468932")]
    [DisplayName("Contact Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctPrsn")]
    #endif
    [IsoXmlTag("CtctPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactIdentification4 ContactPerson { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContactIdentification4 ContactPerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactIdentification4 ContactPerson { get; init; } 
    #else
    public ContactIdentification4 ContactPerson { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the institution that the contact person represents.
    /// </summary>
    [IsoId("_QDnSt9p-Ed-ak6NoX_4Aeg_-2054025257")]
    [DisplayName("Institution Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstnId")]
    #endif
    [IsoXmlTag("InstnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? InstitutionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? InstitutionIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? InstitutionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
