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
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[IsoId("_43d7MWB0EeaHEJD5P6-ccw")]
[DisplayName("Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Account23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Account23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Account23( System.String reqAccountIdentification )
    {
        AccountIdentification = reqAccountIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_GbkZYWB1EeaHEJD5P6-ccw")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountIdentification { get; init; } 
    #else
    public System.String AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the account to which the existing account is to be linked.
    /// </summary>
    [IsoId("_UF7QkGB1EeaHEJD5P6-ccw")]
    [DisplayName("Related Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdAcctDtls")]
    #endif
    [IsoXmlTag("RltdAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? RelatedAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? RelatedAccountDetails { get; init; } 
    #else
    public GenericIdentification1? RelatedAccountDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
