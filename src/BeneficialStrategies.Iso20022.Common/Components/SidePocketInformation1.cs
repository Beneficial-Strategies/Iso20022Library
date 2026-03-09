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
/// Information that identifies a side pocket in investment fund orders.
/// </summary>
[IsoId("_Sd15dtp-Ed-ak6NoX_4Aeg_-47444681")]
[DisplayName("Side Pocket Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SidePocketInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the investor wants to participate in the optional side pocket.
    /// </summary>
    [IsoId("_Sd15d9p-Ed-ak6NoX_4Aeg_-890846613")]
    [DisplayName("Side Pocket Inclusion Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdPcktInclsnInd")]
    #endif
    [IsoXmlTag("SdPcktInclsnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SidePocketInclusionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SidePocketInclusionIndicator { get; init; } 
    #else
    public System.String? SidePocketInclusionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the side pocket.
    /// </summary>
    [IsoId("_Sd15eNp-Ed-ak6NoX_4Aeg_1426393911")]
    [DisplayName("Side Pocket Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdPcktId")]
    #endif
    [IsoXmlTag("SdPcktId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SidePocketIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SidePocketIdentification { get; init; } 
    #else
    public System.String? SidePocketIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the side pocket.
    /// </summary>
    [IsoId("_Sd_DYNp-Ed-ak6NoX_4Aeg_-1013251518")]
    [DisplayName("Side Pocket Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdPcktQty")]
    #endif
    [IsoXmlTag("SdPcktQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SidePocketUnitsOrAmountOrRate1Choice_? SidePocketQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SidePocketUnitsOrAmountOrRate1Choice_? SidePocketQuantity { get; init; } 
    #else
    public SidePocketUnitsOrAmountOrRate1Choice_? SidePocketQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
