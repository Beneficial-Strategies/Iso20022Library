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
/// Type of detailed aggregated position set report between a pair of counterparties.
/// </summary>
[IsoId("_0nw0hcKwEeuM4pgP8Vixbg")]
[DisplayName("Named Position")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NamedPosition3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NamedPosition3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NamedPosition3( System.DateOnly reqReferenceDate )
    {
        ReferenceDate = reqReferenceDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    [IsoId("_52PEgMKwEeuM4pgP8Vixbg")]
    [DisplayName("Reference Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefDt")]
    #endif
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReferenceDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReferenceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReferenceDate { get; init; } 
    #else
    public System.DateOnly ReferenceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Report containing aggregation of loan and collateral exposures between counterparties by Securities Financing Transaction type, for a limited number of fields.
    /// </summary>
    [IsoId("_0pQCQ8KwEeuM4pgP8Vixbg")]
    [DisplayName("General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlInf")]
    #endif
    [IsoXmlTag("GnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet16? GeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet16? GeneralInformation { get; init; } 
    #else
    public PositionSet16? GeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of data for all transactions pertaining to the loan side, by Securities Financing Transaction type.
    /// </summary>
    [IsoId("_0pQCRcKwEeuM4pgP8Vixbg")]
    [DisplayName("Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ln")]
    #endif
    [IsoXmlTag("Ln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet17? Loan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet17? Loan { get; init; } 
    #else
    public PositionSet17? Loan { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of data for all submissions pertaining to the collateral side, by Securities Financing Transaction type.
    /// </summary>
    [IsoId("_0pQCR8KwEeuM4pgP8Vixbg")]
    [DisplayName("Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Coll")]
    #endif
    [IsoXmlTag("Coll")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet18? Collateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet18? Collateral { get; init; } 
    #else
    public PositionSet18? Collateral { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of data related to margin reported for cleared Securities Financing Transactions at the level of each pair of entities and portfolio code.
    /// </summary>
    [IsoId("_0pQCScKwEeuM4pgP8Vixbg")]
    [DisplayName("Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mrgn")]
    #endif
    [IsoXmlTag("Mrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet20? Margin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet20? Margin { get; init; } 
    #else
    public PositionSet20? Margin { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregation of data on collateral reuse transactions, at entity level.
    /// </summary>
    [IsoId("_0pQCS8KwEeuM4pgP8Vixbg")]
    [DisplayName("Reuse")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Reuse")]
    #endif
    [IsoXmlTag("Reuse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSet19? Reuse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSet19? Reuse { get; init; } 
    #else
    public PositionSet19? Reuse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
