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
[IsoId("_RRPjftp-Ed-ak6NoX_4Aeg_-1307334017")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope9( DataModification1Code reqModificationScopeIndication,NewIssueAllocation1 reqIssueAllocation )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        IssueAllocation = reqIssueAllocation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_RRZUcNp-Ed-ak6NoX_4Aeg_-1307333774")]
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
    /// Information about the investment account ownership with respect to new issue allocation for a hedge fund.
    /// </summary>
    [IsoId("_RRZUcdp-Ed-ak6NoX_4Aeg_-1190045534")]
    [DisplayName("Issue Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseAllcn")]
    #endif
    [IsoXmlTag("IsseAllcn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NewIssueAllocation1 IssueAllocation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NewIssueAllocation1 IssueAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NewIssueAllocation1 IssueAllocation { get; init; } 
    #else
    public NewIssueAllocation1 IssueAllocation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
