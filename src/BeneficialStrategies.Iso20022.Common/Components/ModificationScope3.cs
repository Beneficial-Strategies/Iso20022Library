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
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_RElAdNp-Ed-ak6NoX_4Aeg_-218769686")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope3( DataModification2Code reqModificationScopeIndication,CitizenshipInformation reqCitizenship )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        Citizenship = reqCitizenship;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RElAddp-Ed-ak6NoX_4Aeg_-218769643")]
    [DisplayName("Modification Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModScpIndctn")]
    #endif
    [IsoXmlTag("ModScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification2Code ModificationScopeIndication { get; init; } 
    #else
    public DataModification2Code ModificationScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the nationality and the legal status (minor or major) of a person.
    /// </summary>
    [IsoId("_RElAdtp-Ed-ak6NoX_4Aeg_-1223828075")]
    [DisplayName("Citizenship")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctznsh")]
    #endif
    [IsoXmlTag("Ctznsh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CitizenshipInformation Citizenship { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CitizenshipInformation Citizenship { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CitizenshipInformation Citizenship { get; init; } 
    #else
    public CitizenshipInformation Citizenship { get; set; } 
    #endif
    
    
    #nullable disable
    
}
