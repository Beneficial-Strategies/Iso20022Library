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
/// Rules governing an undertaking such as a guarantee or standby letter of credit.
/// </summary>
[IsoId("_94TXpnltEeG7BsjMvd1mEw_101008065")]
[DisplayName("Governance Rules")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GovernanceRules1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GovernanceRules1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GovernanceRules1( GovernanceIdentification1Choice_ reqRuleIdentification )
    {
        RuleIdentification = reqRuleIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the governance rules.
    /// </summary>
    [IsoId("_94TXp3ltEeG7BsjMvd1mEw_-150505630")]
    [DisplayName("Rule Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RuleId")]
    #endif
    [IsoXmlTag("RuleId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GovernanceIdentification1Choice_ RuleIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GovernanceIdentification1Choice_ RuleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GovernanceIdentification1Choice_ RuleIdentification { get; init; } 
    #else
    public GovernanceIdentification1Choice_ RuleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Law applicable to the undertaking.
    /// </summary>
    [IsoId("_94TXqHltEeG7BsjMvd1mEw_-1056936320")]
    [DisplayName("Applicable Law")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblLaw")]
    #endif
    [IsoXmlTag("AplblLaw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Location1? ApplicableLaw { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Location1? ApplicableLaw { get; init; } 
    #else
    public Location1? ApplicableLaw { get; set; } 
    #endif
    
    /// <summary>
    /// Place at or system under which any dispute related to the undertaking is to be resolved, such as court or arbitration. This is also known as &apos;forum&apos;.
    /// </summary>
    [IsoId("_94TXqXltEeG7BsjMvd1mEw_1402302275")]
    [DisplayName("Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Jursdctn")]
    #endif
    [IsoXmlTag("Jursdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Location1? Jurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Location1? Jurisdiction { get; init; } 
    #else
    public Location1? Jurisdiction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
