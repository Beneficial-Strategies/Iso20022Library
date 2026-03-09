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
/// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
/// </summary>
[IsoId("_Q65gBdp-Ed-ak6NoX_4Aeg_-21330104")]
[DisplayName("Pagination")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Pagination
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Pagination instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Pagination( System.String reqPageNumber,System.String reqLastPageIndicator )
    {
        PageNumber = reqPageNumber;
        LastPageIndicator = reqLastPageIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number.
    /// </summary>
    [IsoId("_Q65gBtp-Ed-ak6NoX_4Aeg_653765264")]
    [DisplayName("Page Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PgNb")]
    #endif
    [IsoXmlTag("PgNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax5NumericText PageNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PageNumber { get; init; } 
    #else
    public System.String PageNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the last page.
    /// </summary>
    [IsoId("_Q65gB9p-Ed-ak6NoX_4Aeg_811686458")]
    [DisplayName("Last Page Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastPgInd")]
    #endif
    [IsoXmlTag("LastPgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator LastPageIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String LastPageIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String LastPageIndicator { get; init; } 
    #else
    public System.String LastPageIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
