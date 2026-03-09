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
/// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
/// </summary>
[IsoId("_jl0BAEj2EeG0Lek-7i1x-A_1558311877")]
[DisplayName("Previous Year")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PreviousYear3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PreviousYear3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PreviousYear3( PreviousYear1Choice_ reqPreviousYear,System.String reqCashComponentIndicator )
    {
        PreviousYear = reqPreviousYear;
        CashComponentIndicator = reqCashComponentIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between selected investment plans issued during previous years or the entirety of the investment plans.
    /// </summary>
    [IsoId("_jl0BAUj2EeG0Lek-7i1x-A_-1651304524")]
    [DisplayName("Previous Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsYr")]
    #endif
    [IsoXmlTag("PrvsYr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PreviousYear1Choice_ PreviousYear { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PreviousYear1Choice_ PreviousYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreviousYear1Choice_ PreviousYear { get; init; } 
    #else
    public PreviousYear1Choice_ PreviousYear { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_jl9yAEj2EeG0Lek-7i1x-A_982439671")]
    [DisplayName("Cash Component Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshCmpntInd")]
    #endif
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CashComponentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CashComponentIndicator { get; init; } 
    #else
    public System.String CashComponentIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
