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
/// Provides details about the rejected collateral substitution.
/// </summary>
[IsoId("_FS7TSytJEeyOa655cLd-DQ")]
[DisplayName("Collateral Substitution Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralSubstitutionResponse3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralSubstitutionResponse3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralSubstitutionResponse3( System.String reqCollateralSubstitutionRequestIdentification,ActiveCurrencyAndAmount reqRejectedAmount,RejectionReason68Code reqRejectionReason )
    {
        CollateralSubstitutionRequestIdentification = reqCollateralSubstitutionRequestIdentification;
        RejectedAmount = reqRejectedAmount;
        RejectionReason = reqRejectionReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_FqxLgStJEeyOa655cLd-DQ")]
    [DisplayName("Collateral Substitution Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnReqId")]
    #endif
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralSubstitutionRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralSubstitutionRequestIdentification { get; init; } 
    #else
    public System.String CollateralSubstitutionRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the collateral substitution amount that is rejected.
    /// </summary>
    [IsoId("_FqxLgytJEeyOa655cLd-DQ")]
    [DisplayName("Rejected Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctdAmt")]
    #endif
    [IsoXmlTag("RjctdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount RejectedAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount RejectedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount RejectedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount RejectedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reasons why the collateral substitution is rejected.
    /// </summary>
    [IsoId("_FqxLhStJEeyOa655cLd-DQ")]
    [DisplayName("Rejection Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsn")]
    #endif
    [IsoXmlTag("RjctnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectionReason68Code RejectionReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectionReason68Code RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectionReason68Code RejectionReason { get; init; } 
    #else
    public RejectionReason68Code RejectionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the collateral substitution request rejection.
    /// </summary>
    [IsoId("_FqxLhytJEeyOa655cLd-DQ")]
    [DisplayName("Rejection Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctnRsnInf")]
    #endif
    [IsoXmlTag("RjctnRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? RejectionReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RejectionReasonInformation { get; init; } 
    #else
    public System.String? RejectionReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
