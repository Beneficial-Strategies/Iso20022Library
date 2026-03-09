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
/// Specifies the cash account elements of a parent cash account.
/// </summary>
[IsoId("_Gy28a24-EeiU9cctagi5ow")]
[DisplayName("Parent Cash Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ParentCashAccount3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ParentCashAccount3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ParentCashAccount3( CashAccount38 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Defines the parent account level within a hierarchy.
    /// </summary>
    [IsoId("_G-eWcW4-EeiU9cctagi5ow")]
    [DisplayName("Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lvl")]
    #endif
    [IsoXmlTag("Lvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountLevel1Code? Level { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountLevel1Code? Level { get; init; } 
    #else
    public AccountLevel1Code? Level { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification for the parent account between the parent account owner and the parent account servicer.
    /// </summary>
    [IsoId("_G-eWc24-EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount38 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount38 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38 Identification { get; init; } 
    #else
    public CashAccount38 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution in which the parent account resides.
    /// </summary>
    [IsoId("_G-eWdW4-EeiU9cctagi5ow")]
    [DisplayName("Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Svcr")]
    #endif
    [IsoXmlTag("Svcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
