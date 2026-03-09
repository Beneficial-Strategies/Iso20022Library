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
[IsoId("_RRZUeNp-Ed-ak6NoX_4Aeg_1545333466")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope11( DataModification2Code reqModificationScopeIndication,PartyProfileInformation1 reqInvestorProfileValidation )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        InvestorProfileValidation = reqInvestorProfileValidation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRjFcNp-Ed-ak6NoX_4Aeg_1545333484")]
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
    /// Detailed information about the party profile information.
    /// </summary>
    [IsoId("_RRjFcdp-Ed-ak6NoX_4Aeg_-1567528514")]
    [DisplayName("Investor Profile Validation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstrPrflVldtn")]
    #endif
    [IsoXmlTag("InvstrPrflVldtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyProfileInformation1 InvestorProfileValidation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyProfileInformation1 InvestorProfileValidation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyProfileInformation1 InvestorProfileValidation { get; init; } 
    #else
    public PartyProfileInformation1 InvestorProfileValidation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
