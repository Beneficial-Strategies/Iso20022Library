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
/// Information about a database.
/// </summary>
[IsoId("_0wzDEQjWEeS5F6qHcKOrew")]
[DisplayName("Data Base Check")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DataBaseCheck1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DataBaseCheck1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DataBaseCheck1( System.String reqDatabaseCheck,System.String reqIdentification )
    {
        DatabaseCheck = reqDatabaseCheck;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the individual or organisation is listed in an on-line global Know Your Customer (KYC) database.
    /// </summary>
    [IsoId("_YoeRAAjXEeS5F6qHcKOrew")]
    [DisplayName("Database Check")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DBChck")]
    #endif
    [IsoXmlTag("DBChck")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator DatabaseCheck { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DatabaseCheck { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DatabaseCheck { get; init; } 
    #else
    public System.String DatabaseCheck { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the database.
    /// </summary>
    [IsoId("_eCrP4AjXEeS5F6qHcKOrew")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
