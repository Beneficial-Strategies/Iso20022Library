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
/// Specifies the opening and valuation conditions for the non deliverable forward.
/// </summary>
[IsoId("_lUCXwJR9Eeak6e8_Fc5fQg")]
[DisplayName("Non Deliverable Forward Conditions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonDeliverableForwardConditions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NonDeliverableForwardConditions1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NonDeliverableForwardConditions1( System.String reqOpeningIndicator,NDFOpeningFixing1Choice_ reqOpeningFixingConditions )
    {
        OpeningIndicator = reqOpeningIndicator;
        OpeningFixingConditions = reqOpeningFixingConditions;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the instruction is an NDF opening or fixing.
    /// </summary>
    [IsoId("_OiuGoJR-Eeak6e8_Fc5fQg")]
    [DisplayName("Opening Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngInd")]
    #endif
    [IsoXmlTag("OpngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator OpeningIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OpeningIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OpeningIndicator { get; init; } 
    #else
    public System.String OpeningIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies either the conditions for an NDF oepning or an NDF fixing confirmation.
    /// </summary>
    [IsoId("_MFrkkJUPEeak6e8_Fc5fQg")]
    [DisplayName("Opening Fixing Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngFxgConds")]
    #endif
    [IsoXmlTag("OpngFxgConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NDFOpeningFixing1Choice_ OpeningFixingConditions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NDFOpeningFixing1Choice_ OpeningFixingConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NDFOpeningFixing1Choice_ OpeningFixingConditions { get; init; } 
    #else
    public NDFOpeningFixing1Choice_ OpeningFixingConditions { get; set; } 
    #endif
    
    
    #nullable disable
    
}
