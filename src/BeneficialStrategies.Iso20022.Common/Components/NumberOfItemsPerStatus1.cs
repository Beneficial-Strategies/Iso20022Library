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
/// Provides detailed information on the number of reported items with their respective acceptance status.
/// </summary>
[IsoId("_UtSF10ipEeSlHoYg_EudVQ")]
[DisplayName("Number Of Items Per Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberOfItemsPerStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberOfItemsPerStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberOfItemsPerStatus1( ReportItemStatus1Code reqStatus,System.String reqNumberOfItems )
    {
        Status = reqStatus;
        NumberOfItems = reqNumberOfItems;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common status of the report items for which the number of report items is specified in NumberOfItems.
    /// </summary>
    [IsoId("_U4cM9UipEeSlHoYg_EudVQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReportItemStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReportItemStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReportItemStatus1Code Status { get; init; } 
    #else
    public ReportItemStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Number of items for the status.
    /// </summary>
    [IsoId("_U4cM80ipEeSlHoYg_EudVQ")]
    [DisplayName("Number Of Items")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfItms")]
    #endif
    [IsoXmlTag("NbOfItms")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText NumberOfItems { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfItems { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfItems { get; init; } 
    #else
    public System.String NumberOfItems { get; set; } 
    #endif
    
    
    #nullable disable
    
}
