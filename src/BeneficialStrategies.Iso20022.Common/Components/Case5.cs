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
/// Provides further details to identify an investigation case.
/// </summary>
[IsoId("_8BF4W248EeiU9cctagi5ow")]
[DisplayName("Case")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Case5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Case5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Case5( System.String reqIdentification,Party40Choice_ reqCreator )
    {
        Identification = reqIdentification;
        Creator = reqCreator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_8KfE4W48EeiU9cctagi5ow")]
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
    [IsoId("_8KfE4248EeiU9cctagi5ow")]
    [DisplayName("Creator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cretr")]
    #endif
    [IsoXmlTag("Cretr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Party40Choice_ Creator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Party40Choice_ Creator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_ Creator { get; init; } 
    #else
    public Party40Choice_ Creator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the case was previously closed and is now re-opened.
    /// </summary>
    [IsoId("_8KfE5W48EeiU9cctagi5ow")]
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
