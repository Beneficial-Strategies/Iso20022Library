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
/// Provide information about the type of request or instruction which triggered this confirmation.
/// </summary>
[IsoId("_RESFhNp-Ed-ak6NoX_4Aeg_190539014")]
[DisplayName("Account Management Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementConfirmation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountManagementConfirmation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementConfirmation1( AccountManagementType2Code reqConfirmationType )
    {
        ConfirmationType = reqConfirmationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies if the confirmation message applies to an account opening, an account modification request or to a get account details.
    /// </summary>
    [IsoId("_RESFhdp-Ed-ak6NoX_4Aeg_190539050")]
    [DisplayName("Confirmation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfTp")]
    #endif
    [IsoXmlTag("ConfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountManagementType2Code ConfirmationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountManagementType2Code ConfirmationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountManagementType2Code ConfirmationType { get; init; } 
    #else
    public AccountManagementType2Code ConfirmationType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_REb2gNp-Ed-ak6NoX_4Aeg_190539109")]
    [DisplayName("Account Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctApplId")]
    #endif
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountApplicationIdentification { get; init; } 
    #else
    public System.String? AccountApplicationIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
