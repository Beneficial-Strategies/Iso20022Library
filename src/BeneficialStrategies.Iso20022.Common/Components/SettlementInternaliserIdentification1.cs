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
/// Specifies the identification of the settlement internaliser.
/// </summary>
[IsoId("_8dG-QO3kEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInternaliserIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInternaliserIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInternaliserIdentification1( System.String reqLEI,ContactDetails4 reqResponsiblePerson,string reqCountry )
    {
        LEI = reqLEI;
        ResponsiblePerson = reqResponsiblePerson;
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification code of the settlement internaliser; Legal Entity Identifier (LEI) is a code allocated to a party as described in ISO 17442 &apos;Financial Services - Legal Entity Identifier (LEI)&apos;.
    /// </summary>
    [IsoId("_BYNmUO3lEeaWjpoyrnG6Rw")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoLEIIdentifier LEI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LEI { get; init; } 
    #else
    public System.String LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the liaison at the Settlement Internaliser.
    /// </summary>
    [IsoId("_C2FSgO3lEeaWjpoyrnG6Rw")]
    [DisplayName("Responsible Person")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPrsn")]
    #endif
    [IsoXmlTag("RspnsblPrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContactDetails4 ResponsiblePerson { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContactDetails4 ResponsiblePerson { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactDetails4 ResponsiblePerson { get; init; } 
    #else
    public ContactDetails4 ResponsiblePerson { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the country code of the place of establishment of the Settlement Internaliser (i.e. head-office), relating to the data that the report concerns, using ISO 3166 2-character code.
    /// </summary>
    [IsoId("_lbE-wImwEeeMqMRHD1a9dQ")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the code of the place of operation of the settlement internaliser (that is the branch), relating to the data that the report concerns.
    /// </summary>
    [IsoId("_wgfUUhJlEeiE15g1wPm3UA")]
    [DisplayName("Branch Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrnchId")]
    #endif
    [IsoXmlTag("BrnchId")]
    [IsoSimpleType(IsoSimpleType.Exact2UpperCaseAlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact2UpperCaseAlphaText? BranchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BranchIdentification { get; init; } 
    #else
    public System.String? BranchIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
