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
/// Specifies details of a claim non receipt status advice.
/// </summary>
[IsoId("_xyjo8IjYEeeDW7_wB-eK_g")]
[DisplayName("Claim Non Receipt")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClaimNonReceipt1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClaimNonReceipt1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClaimNonReceipt1( System.DateOnly reqDateProcessed,BranchAndFinancialInstitutionIdentification5 reqOriginalNextAgent )
    {
        DateProcessed = reqDateProcessed;
        OriginalNextAgent = reqOriginalNextAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the date the original payment instruction was processed.
    /// </summary>
    [IsoId("_hPoCUItuEee-OJ-wXSj3YQ")]
    [DisplayName("Date Processed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtPrcd")]
    #endif
    [IsoXmlTag("DtPrcd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate DateProcessed { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly DateProcessed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly DateProcessed { get; init; } 
    #else
    public System.DateOnly DateProcessed { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the next party the original payment instruction was sent to.
    /// </summary>
    [IsoId("_jfyHEItuEee-OJ-wXSj3YQ")]
    [DisplayName("Original Next Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlNxtAgt")]
    #endif
    [IsoXmlTag("OrgnlNxtAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification5 OriginalNextAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
