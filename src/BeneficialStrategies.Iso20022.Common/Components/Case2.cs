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
/// Set of elements used to identify a case.
/// </summary>
[IsoId("_SpAnptp-Ed-ak6NoX_4Aeg_-1565053133")]
[DisplayName("Case")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Case2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Case2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Case2( System.String reqIdentification,Party7Choice_ reqCreator )
    {
        Identification = reqIdentification;
        Creator = reqCreator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_SpAnp9p-Ed-ak6NoX_4Aeg_-1565053102")]
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
    
    /// <summary>
    /// Party that created the investigation case.
    /// </summary>
    [IsoId("_SpAnqNp-Ed-ak6NoX_4Aeg_-1667764151")]
    [DisplayName("Creator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cretr")]
    #endif
    [IsoXmlTag("Cretr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party7Choice_ Creator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party7Choice_ Creator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party7Choice_ Creator { get; init; } 
    #else
    public Party7Choice_ Creator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the case was previously closed and is now re-opened.
    /// </summary>
    [IsoId("_SpAnqdp-Ed-ak6NoX_4Aeg_-1565052762")]
    [DisplayName("Reopen Case Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReopCaseIndctn")]
    #endif
    [IsoXmlTag("ReopCaseIndctn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReopenCaseIndication { get; init; } 
    #else
    public System.String? ReopenCaseIndication { get; set; } 
    #endif
    
    
    #nullable disable
    
}
