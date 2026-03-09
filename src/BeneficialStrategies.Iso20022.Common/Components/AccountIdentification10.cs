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
/// Provides account identification information.
/// </summary>
[IsoId("_QSgqU9p-Ed-ak6NoX_4Aeg_-565848131")]
[DisplayName("Account Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountIdentification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountIdentification10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountIdentification10( SafekeepingAccountIdentification1Code reqIdentificationCode )
    {
        IdentificationCode = reqIdentificationCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
    /// </summary>
    [IsoId("_QSgqVNp-Ed-ak6NoX_4Aeg_-758816150")]
    [DisplayName("Identification Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdCd")]
    #endif
    [IsoXmlTag("IdCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
    #else
    public SafekeepingAccountIdentification1Code IdentificationCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
