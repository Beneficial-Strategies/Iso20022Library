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
/// Unique and unambiguous way to identify a system party.
/// </summary>
[IsoId("_Tz7vAeE8EeWHlNkrP2xqHA")]
[DisplayName("System Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemPartyIdentification6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SystemPartyIdentification6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SystemPartyIdentification6( PartyIdentification91 reqRelatedPartyIdentification )
    {
        RelatedPartyIdentification = reqRelatedPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party referenced by a request.
    /// </summary>
    [IsoId("_T9AygeE8EeWHlNkrP2xqHA")]
    [DisplayName("Related Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPtyId")]
    #endif
    [IsoXmlTag("RltdPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification91 RelatedPartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification91 RelatedPartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification91 RelatedPartyIdentification { get; init; } 
    #else
    public PartyIdentification91 RelatedPartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    [IsoId("_T9Ayg-E8EeWHlNkrP2xqHA")]
    [DisplayName("Responsible Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPtyId")]
    #endif
    [IsoXmlTag("RspnsblPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstitutionIdentification12? ResponsiblePartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstitutionIdentification12? ResponsiblePartyIdentification { get; init; } 
    #else
    public FinancialInstitutionIdentification12? ResponsiblePartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
