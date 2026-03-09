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
/// Provides the status details about the collateral substitution.
/// </summary>
[IsoId("_UnrTxNp-Ed-ak6NoX_4Aeg_-2119738374")]
[DisplayName("Collateral Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralConfirmation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralConfirmation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralConfirmation1( System.String reqCollateralSubstitutionRequestIdentification,CollateralSubstitutionConfirmation1Code reqConfirmationType )
    {
        CollateralSubstitutionRequestIdentification = reqCollateralSubstitutionRequestIdentification;
        ConfirmationType = reqConfirmationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the collateral substitution request identification.
    /// </summary>
    [IsoId("_UnrTxdp-Ed-ak6NoX_4Aeg_-2130532228")]
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
    /// Reference to the collateral substitution response identification.
    /// </summary>
    [IsoId("_UnrTxtp-Ed-ak6NoX_4Aeg_2051423832")]
    [DisplayName("Collateral Substitution Response Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnRspnId")]
    #endif
    [IsoXmlTag("CollSbstitnRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CollateralSubstitutionResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralSubstitutionResponseIdentification { get; init; } 
    #else
    public System.String? CollateralSubstitutionResponseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the status of the collateral substitution, either released or returned.
    /// </summary>
    [IsoId("_UnrTx9p-Ed-ak6NoX_4Aeg_-785691192")]
    [DisplayName("Confirmation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfTp")]
    #endif
    [IsoXmlTag("ConfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralSubstitutionConfirmation1Code ConfirmationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralSubstitutionConfirmation1Code ConfirmationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralSubstitutionConfirmation1Code ConfirmationType { get; init; } 
    #else
    public CollateralSubstitutionConfirmation1Code ConfirmationType { get; set; } 
    #endif
    
    /// <summary>
    /// Allows to provides additional comments on the collateral substitution status.
    /// </summary>
    [IsoId("_UnrTyNp-Ed-ak6NoX_4Aeg_1518492847")]
    [DisplayName("Comment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmnt")]
    #endif
    [IsoXmlTag("Cmnt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Comment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Comment { get; init; } 
    #else
    public System.String? Comment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
