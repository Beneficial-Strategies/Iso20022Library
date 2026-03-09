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
/// Full report data or reporting data of a single tranche of the full report.
/// </summary>
[IsoId("_UsI9Btp-Ed-ak6NoX_4Aeg_1382074733")]
[DisplayName("Proprietary Report Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProprietaryReportData
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProprietaryReportData instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProprietaryReportData( System.String reqData )
    {
        Data = reqData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// IMPLEMENTORS WARNING - This element is replaced by the ANY XML type in the schema. Therefore, the XML tag &lt;Data&gt; does not appear in an actual XML instance.
    /// </summary>
    [IsoId("_UsI9B9p-Ed-ak6NoX_4Aeg_1926953180")]
    [DisplayName("Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Data")]
    #endif
    [IsoXmlTag("Data")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Data { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Data { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Data { get; init; } 
    #else
    public System.String Data { get; set; } 
    #endif
    
    
    #nullable disable
    
}
