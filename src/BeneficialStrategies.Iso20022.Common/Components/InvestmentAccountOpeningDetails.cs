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
/// Provide information about the type of opening instruction and identification of the application request.
/// </summary>
[IsoId("_REb2hNp-Ed-ak6NoX_4Aeg_443591120")]
[DisplayName("Investment Account Opening Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentAccountOpeningDetails
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentAccountOpeningDetails instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentAccountOpeningDetails( AccountOpeningType1Code reqOpeningType )
    {
        OpeningType = reqOpeningType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies if the account opening instruction is about a newly created account or a supplementary account.
    /// </summary>
    [IsoId("_REb2hdp-Ed-ak6NoX_4Aeg_-389691273")]
    [DisplayName("Opening Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngTp")]
    #endif
    [IsoXmlTag("OpngTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountOpeningType1Code OpeningType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountOpeningType1Code OpeningType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountOpeningType1Code OpeningType { get; init; } 
    #else
    public AccountOpeningType1Code OpeningType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening request at application level.
    /// </summary>
    [IsoId("_REb2htp-Ed-ak6NoX_4Aeg_-389690342")]
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
