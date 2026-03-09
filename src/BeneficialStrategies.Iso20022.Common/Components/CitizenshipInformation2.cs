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
/// Information about an individual person.
/// </summary>
[IsoId("_PECrwa18EeaD5sjjwBUhkQ")]
[DisplayName("Citizenship Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CitizenshipInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CitizenshipInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CitizenshipInformation2( string reqNationality,System.String reqMinorIndicator )
    {
        Nationality = reqNationality;
        MinorIndicator = reqMinorIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country where a person was born or is legally accepted as belonging to the country.
    /// </summary>
    [IsoId("_PbGg4a18EeaD5sjjwBUhkQ")]
    [DisplayName("Nationality")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntlty")]
    #endif
    [IsoXmlTag("Ntlty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NationalityCode Nationality { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Nationality { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Nationality { get; init; } 
    #else
    public string Nationality { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the person is a legal minor. This may depend on the nationality, the domicile country or the transaction in which the person is involved.
    /// </summary>
    [IsoId("_PbGg4618EeaD5sjjwBUhkQ")]
    [DisplayName("Minor Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnrInd")]
    #endif
    [IsoXmlTag("MnrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MinorIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MinorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MinorIndicator { get; init; } 
    #else
    public System.String MinorIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
