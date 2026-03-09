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
/// Drawdown allowance check. For pensions that have a lifetime allowance, a check is made of the maximum value of benefits that may be taken from the pension without incurring a special tax. (This check or &apos;event&apos; is known as the benefit crystallisation event in the UK market.)
/// </summary>
[IsoId("_6Oo4kLGuEeirN-C08vro8Q")]
[DisplayName("Drawdown Allowance Check")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DrawdownAllowanceCheck1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the Benefit Crystallised Event (BCE).
    /// If the Benefit Crystallised Event (BCE ) is other than 1 and 6 then the BCEIndicator must contain the value &quot;true&apos;.
    /// If the Benefit Crystallised Event (BCE ) is 1 or 6 then the BCEIndicator must contain the value false&apos;.
    /// </summary>
    [IsoId("_Y6dFoLGvEeirN-C08vro8Q")]
    [DisplayName("BCE Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BCEInd")]
    #endif
    [IsoXmlTag("BCEInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BCEIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BCEIndicator { get; init; } 
    #else
    public System.String? BCEIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Species information about the drawdown allowance check.
    /// </summary>
    [IsoId("_cZUZMLGvEeirN-C08vro8Q")]
    [DisplayName("Check Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckInf")]
    #endif
    [IsoXmlTag("ChckInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CheckInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CheckInformation { get; init; } 
    #else
    public System.String? CheckInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
