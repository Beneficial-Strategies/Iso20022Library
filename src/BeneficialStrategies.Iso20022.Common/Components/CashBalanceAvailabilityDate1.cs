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
/// Indicates when the amount of money will become available.
/// </summary>
[IsoId("_TU0kytp-Ed-ak6NoX_4Aeg_1268888405")]
[DisplayName("Cash Balance Availability Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashBalanceAvailabilityDate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashBalanceAvailabilityDate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashBalanceAvailabilityDate1( System.String reqNumberOfDays,System.DateOnly reqActualDate )
    {
        NumberOfDays = reqNumberOfDays;
        ActualDate = reqActualDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the number of float days attached to the balance.
    /// </summary>
    [IsoId("_TU0ky9p-Ed-ak6NoX_4Aeg_1379712355")]
    [DisplayName("Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDays")]
    #endif
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15PlusSignedNumericText NumberOfDays { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfDays { get; init; } 
    #else
    public System.String NumberOfDays { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the actual availability date.
    /// </summary>
    [IsoId("_TU0kzNp-Ed-ak6NoX_4Aeg_1424965762")]
    [DisplayName("Actual Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlDt")]
    #endif
    [IsoXmlTag("ActlDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ActualDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ActualDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ActualDate { get; init; } 
    #else
    public System.DateOnly ActualDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
