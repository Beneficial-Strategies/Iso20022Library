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
[IsoId("_N5t8EZS8EemqYPWMBuVawg")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope41
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope41 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope41( DataModification1Code reqModificationScopeIndication,InvestmentPlan16 reqInvestmentPlan )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        InvestmentPlan = reqInvestmentPlan;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    [IsoId("_ONWpw5S8EemqYPWMBuVawg")]
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
    /// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
    /// </summary>
    [IsoId("_ONWpxZS8EemqYPWMBuVawg")]
    [DisplayName("Investment Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtPlan")]
    #endif
    [IsoXmlTag("InvstmtPlan")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentPlan16 InvestmentPlan { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentPlan16 InvestmentPlan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentPlan16 InvestmentPlan { get; init; } 
    #else
    public InvestmentPlan16 InvestmentPlan { get; set; } 
    #endif
    
    
    #nullable disable
    
}
