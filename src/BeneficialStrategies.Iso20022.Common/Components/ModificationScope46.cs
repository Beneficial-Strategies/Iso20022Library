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
[IsoId("_xm55Ee6UEemVDc1WJaqofw")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope46
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope46 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope46( DataModification1Code reqModificationScopeIndication,InvestorProfile2 reqInvestorProfile )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        InvestorProfile = reqInvestorProfile;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_x8B0ge6UEemVDc1WJaqofw")]
    [DisplayName("Modification Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModScpIndctn")]
    #endif
    [IsoXmlTag("ModScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification1Code ModificationScopeIndication { get; init; } 
    #else
    public DataModification1Code ModificationScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to determine fees and types of operations that can be carried out on the account.
    /// </summary>
    [IsoId("_x8B0g-6UEemVDc1WJaqofw")]
    [DisplayName("Investor Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrPrfl")]
    #endif
    [IsoXmlTag("InvstrPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestorProfile2 InvestorProfile { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestorProfile2 InvestorProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestorProfile2 InvestorProfile { get; init; } 
    #else
    public InvestorProfile2 InvestorProfile { get; set; } 
    #endif
    
    
    #nullable disable
    
}
