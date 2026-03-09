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
/// Unique identifier for a list as assigned by institution, used to associate multiple individual orders. Uniqueness must be guaranteed within a single trading day. Institutions which generate multi-day orders should consider embedding a date to assure uniqueness across days.
/// </summary>
[IsoId("_SzmHBtp-Ed-ak6NoX_4Aeg_1241706785")]
[DisplayName("List Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ListIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ListIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ListIdentification1( System.String reqListIdentification )
    {
        ListIdentification = reqListIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_SzmHB9p-Ed-ak6NoX_4Aeg_1303584173")]
    [DisplayName("List Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListId")]
    #endif
    [IsoXmlTag("ListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ListIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ListIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ListIdentification { get; init; } 
    #else
    public System.String ListIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
