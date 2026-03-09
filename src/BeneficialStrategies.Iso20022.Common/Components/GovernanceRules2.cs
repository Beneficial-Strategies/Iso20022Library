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
/// Specifies rules governing an undertaking such as a guarantee or standby letter of credit.
/// </summary>
[IsoId("_OTgzMjIy-AOSNFX-8224493")]
[DisplayName("Governance Rules")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GovernanceRules2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GovernanceRules2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GovernanceRules2( System.String reqIdentification,GovernanceIdentification1Choice_ reqRuleIdentification )
    {
        Identification = reqIdentification;
        RuleIdentification = reqRuleIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Local identification to be used in IDREFs.
    /// </summary>
    [IsoId("_OTgzMjI5-AOSNFX-8224493")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ID)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoID Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the governance rules.
    /// </summary>
    [IsoId("_OTgzMjMw-AOSNFX-8224493")]
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
    [IsoId("_OTgzMjMx-AOSNFX-8224493")]
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
    [IsoId("_OTgzMjMy-AOSNFX-8224493")]
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
