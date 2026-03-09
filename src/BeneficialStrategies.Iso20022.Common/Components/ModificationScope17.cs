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
/// Specifies the type of modification to be applied on a data set.
/// </summary>
[IsoId("_1B0xARRXEeOKWo1NF21OVw")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope17( DataModification2Code reqModificationScopeIndication,GenericIdentification44 reqOtherIdentification )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        OtherIdentification = reqOtherIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_1Zo0ERRXEeOKWo1NF21OVw")]
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
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_kOYzkBRYEeOKWo1NF21OVw")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification44 OtherIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification44 OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification44 OtherIdentification { get; init; } 
    #else
    public GenericIdentification44 OtherIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
