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
/// Defines the account to or from which a securities entry is made and the usage type.
/// </summary>
[IsoId("_mzWcD-FgEeWIA4E9cYSxxQ")]
[DisplayName("Issuance Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IssuanceAccount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IssuanceAccount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IssuanceAccount2( SecuritiesAccount19 reqIssuanceAccount,System.String reqPrimaryAccountIndicator )
    {
        IssuanceAccount = reqIssuanceAccount;
        PrimaryAccountIndicator = reqPrimaryAccountIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_m8H9geFgEeWIA4E9cYSxxQ")]
    [DisplayName("Issuance Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssncAcct")]
    #endif
    [IsoXmlTag("IssncAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 IssuanceAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount19 IssuanceAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 IssuanceAccount { get; init; } 
    #else
    public SecuritiesAccount19 IssuanceAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines if the related issuance account is the primary account or not.
    /// </summary>
    [IsoId("_m8H9g-FgEeWIA4E9cYSxxQ")]
    [DisplayName("Primary Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryAcctInd")]
    #endif
    [IsoXmlTag("PmryAcctInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PrimaryAccountIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PrimaryAccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PrimaryAccountIndicator { get; init; } 
    #else
    public System.String PrimaryAccountIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
