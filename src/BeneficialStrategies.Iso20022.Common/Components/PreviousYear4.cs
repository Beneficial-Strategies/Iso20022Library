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
/// Information about investment plans issued during previous years.
/// </summary>
[IsoId("_zhY78U7eEeifNrXGwadPmg")]
[DisplayName("Previous Year")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PreviousYear4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PreviousYear4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PreviousYear4( PreviousYear1Choice_ reqPreviousYears )
    {
        PreviousYears = reqPreviousYears;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Investment plans issued during previous years.
    /// </summary>
    [IsoId("_zxwTM07eEeifNrXGwadPmg")]
    [DisplayName("Previous Years")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYrs")]
    #endif
    [IsoXmlTag("PrvsYrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PreviousYear1Choice_ PreviousYears { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PreviousYear1Choice_ PreviousYears { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYear1Choice_ PreviousYears { get; init; } 
    #else
    public PreviousYear1Choice_ PreviousYears { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the product contains a cash asset for transfer from previous years.
    /// </summary>
    [IsoId("_zxwTNU7eEeifNrXGwadPmg")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashComponentIndicator { get; init; } 
    #else
    public System.String? CashComponentIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
